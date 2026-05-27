using BoardGameCafeApp.Data;
using BoardGameCafeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardGameCafeApp.Services;

public class GameService
{
    private readonly CafeDbContext _db;

    public GameService(CafeDbContext db)
    {
        _db = db;
    }

    public List<string> GetGenres()
    {
        return _db.Games
            .AsNoTracking()
            .Select(g => g.Genre)
            .Where(g => g != null && g != "")
            .Distinct()
            .OrderBy(g => g)
            .ToList();
    }

    public List<Game> GetGames(string? titleSearch = null, string? genre = null)
    {
        IQueryable<Game> q = _db.Games.AsNoTracking();

        if (!string.IsNullOrWhiteSpace(titleSearch))
        {
            titleSearch = titleSearch.Trim();
            q = q.Where(g => g.Title.Contains(titleSearch));
        }

        if (!string.IsNullOrWhiteSpace(genre) && genre != "All")
        {
            q = q.Where(g => g.Genre == genre);
        }

        return q.OrderBy(g => g.Title).ToList();
    }

    public Game? GetById(int gameId)
    {
        return _db.Games.FirstOrDefault(g => g.GameId == gameId);
    }

    public void Add(Game game)
    {
        ValidateGame(game);

        _db.Games.Add(game);
        _db.SaveChanges();
    }

    public void Update(Game game)
    {
        ValidateGame(game);

        _db.Games.Update(game);
        _db.SaveChanges();
    }

    public void Delete(int gameId)
    {
        // Restrict delete if there are rentals (keeps relationship consistent)
        bool hasRentals = _db.Rentals.Any(r => r.GameId == gameId);
        if (hasRentals)
            throw new InvalidOperationException("Cannot delete this game because it has rentals in history.");

        var game = _db.Games.FirstOrDefault(g => g.GameId == gameId);
        if (game == null)
            throw new InvalidOperationException("Game not found.");

        _db.Games.Remove(game);
        _db.SaveChanges();
    }

    private static void ValidateGame(Game game)
    {
        if (string.IsNullOrWhiteSpace(game.Title))
            throw new InvalidOperationException("Title is required.");

        if (string.IsNullOrWhiteSpace(game.Genre))
            throw new InvalidOperationException("Genre is required.");

        if (game.TotalCopies < 0)
            throw new InvalidOperationException("Total copies cannot be negative.");

        if (game.PricePerHour < 0)
            throw new InvalidOperationException("Price per hour cannot be negative.");
    }
}