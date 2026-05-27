using BoardGameCafeApp.Data;
using BoardGameCafeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardGameCafeApp.Services;

public class BookingService
{
    private readonly CafeDbContext _db;

    public BookingService(CafeDbContext db)
    {
        _db = db;
    }

    public IQueryable<CafeTable> GetActiveTables()
    {
        return _db.CafeTables.AsNoTracking().Where(t => t.IsActive);
    }

    public void CreateBooking(Booking booking)
    {
        // basic guard clauses
        if (booking.CafeTableId <= 0)
            throw new InvalidOperationException("Invalid table selection.");

        if (string.IsNullOrWhiteSpace(booking.CustomerName))
            throw new InvalidOperationException("Customer name is required.");

        if (booking.EndTime <= booking.StartTime)
            throw new InvalidOperationException("End time must be after start time.");

        var table = _db.CafeTables.FirstOrDefault(t => t.CafeTableId == booking.CafeTableId);
        if (table == null)
            throw new InvalidOperationException("Selected table was not found.");

        if (!table.IsActive)
            throw new InvalidOperationException("Selected table is not active.");

        // Overlap rule: no other booking for same table intersects [StartTime, EndTime)
        bool overlaps = _db.Bookings.Any(b =>
            b.CafeTableId == booking.CafeTableId &&
            booking.StartTime < b.EndTime &&
            booking.EndTime > b.StartTime);

        if (overlaps)
            throw new InvalidOperationException("This table is already booked during the selected time.");

        _db.Bookings.Add(booking);
        _db.SaveChanges();
    }

    public List<CafeTable> GetAllTables()
    {
        return _db.CafeTables
            .AsNoTracking()
            .OrderBy(t => t.TableName)
            .ToList();
    }

    public List<Booking> GetBookingHistory(
        DateTime? from = null,
        DateTime? to = null,
        string? customerSearch = null,
        int? tableId = null)
    {
        IQueryable<Booking> q = _db.Bookings
            .AsNoTracking()
            .Include(b => b.CafeTable);

        if (from != null) q = q.Where(b => b.StartTime >= from.Value);
        if (to != null) q = q.Where(b => b.StartTime <= to.Value);

        if (!string.IsNullOrWhiteSpace(customerSearch))
        {
            customerSearch = customerSearch.Trim();
            q = q.Where(b => b.CustomerName.Contains(customerSearch));
        }

        if (tableId != null && tableId.Value > 0)
            q = q.Where(b => b.CafeTableId == tableId.Value);

        return q.OrderByDescending(b => b.StartTime).ToList();
    }
}