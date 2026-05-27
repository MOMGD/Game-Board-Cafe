using BoardGameCafeApp.Data;

namespace BoardGameCafeApp.Services;

public class GameService
{
    private readonly CafeDbContext _db;

    public GameService(CafeDbContext db)
    {
        _db = db;
    }
}