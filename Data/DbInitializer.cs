using BoardGameCafeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardGameCafeApp.Data;

public static class DbInitializer
{
    public static void Initialize(CafeDbContext db)
    {
        // Make sure DB exists and all migrations are applied
        db.Database.Migrate();

        // Seed CafeTables (needed for bookings)
        if (!db.CafeTables.Any())
        {
            db.CafeTables.AddRange(
                new CafeTable { TableName = "T1", Capacity = 4, IsActive = true },
                new CafeTable { TableName = "T2", Capacity = 4, IsActive = true },
                new CafeTable { TableName = "T3", Capacity = 2, IsActive = true },
                new CafeTable { TableName = "VIP-1", Capacity = 6, IsActive = true }
            );
        }

        // Seed Games (helps testing rentals/catalog)
        if (!db.Games.Any())
        {
            db.Games.AddRange(
                new Game { Title = "Catan", Genre = "Strategy", TotalCopies = 3, PricePerHour = 5m },
                new Game { Title = "UNO", Genre = "Card", TotalCopies = 5, PricePerHour = 2m },
                new Game { Title = "Chess", Genre = "Classic", TotalCopies = 4, PricePerHour = 1m }
            );
        }

        db.SaveChanges();
    }
}