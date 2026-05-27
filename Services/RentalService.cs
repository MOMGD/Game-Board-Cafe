using BoardGameCafeApp.Data;
using BoardGameCafeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardGameCafeApp.Services;

public class RentalService
{
    private readonly CafeDbContext _db;

    public RentalService(CafeDbContext db)
    {
        _db = db;
    }

    public List<Game> GetRentableGames()
    {
        // Load games and compute availability = TotalCopies - active rentals
        // Active rental = ReturnDate is null
        var activeRentalCounts = _db.Rentals
            .AsNoTracking()
            .Where(r => r.ReturnDate == null)
            .GroupBy(r => r.GameId)
            .Select(g => new { GameId = g.Key, Count = g.Count() })
            .ToDictionary(x => x.GameId, x => x.Count);

        var games = _db.Games.AsNoTracking().OrderBy(g => g.Title).ToList();

        // Only return games with available copies > 0
        var rentable = new List<Game>();
        foreach (var game in games)
        {
            activeRentalCounts.TryGetValue(game.GameId, out int activeCount);
            var available = game.TotalCopies - activeCount;
            if (available > 0)
                rentable.Add(game);
        }

        return rentable;
    }

    public int GetAvailableCopies(int gameId)
    {
        var game = _db.Games.AsNoTracking().FirstOrDefault(g => g.GameId == gameId);
        if (game == null) throw new InvalidOperationException("Game not found.");

        int activeCount = _db.Rentals.AsNoTracking()
            .Count(r => r.GameId == gameId && r.ReturnDate == null);

        return game.TotalCopies - activeCount;
    }

    public void CreateRental(int gameId, string customerName, DateTime rentDate)
    {
        if (gameId <= 0) throw new InvalidOperationException("Please select a game.");
        if (string.IsNullOrWhiteSpace(customerName)) throw new InvalidOperationException("Customer name is required.");

        int available = GetAvailableCopies(gameId);
        if (available <= 0)
            throw new InvalidOperationException("This game is not available right now (no copies left).");

        var rental = new Rental
        {
            GameId = gameId,
            CustomerName = customerName.Trim(),
            RentDate = rentDate,
            ReturnDate = null
        };

        _db.Rentals.Add(rental);
        _db.SaveChanges();
    }

    public void ReturnRental(int rentalId, DateTime returnDate)
    {
        var rental = _db.Rentals.FirstOrDefault(r => r.RentalId == rentalId);
        if (rental == null) throw new InvalidOperationException("Rental not found.");

        if (rental.ReturnDate != null)
            throw new InvalidOperationException("This rental is already returned.");

        if (returnDate < rental.RentDate)
            throw new InvalidOperationException("Return date cannot be before rent date.");

        rental.ReturnDate = returnDate;
        _db.SaveChanges();
    }

    public List<Rental> GetRentalHistory(DateTime? from = null, DateTime? to = null, string? customerSearch = null, bool? activeOnly = null)
    {
        IQueryable<Rental> q = _db.Rentals
            .AsNoTracking()
            .Include(r => r.Game);

        if (from != null) q = q.Where(r => r.RentDate >= from.Value);
        if (to != null) q = q.Where(r => r.RentDate <= to.Value);

        if (!string.IsNullOrWhiteSpace(customerSearch))
        {
            customerSearch = customerSearch.Trim();
            q = q.Where(r => r.CustomerName.Contains(customerSearch));
        }

        if (activeOnly == true)
            q = q.Where(r => r.ReturnDate == null);
        else if (activeOnly == false)
            q = q.Where(r => r.ReturnDate != null);

        return q.OrderByDescending(r => r.RentDate).ToList();
    }
}