using System;
using System.Collections.Generic;
using System.Text;
using BoardGameCafeApp.Data;

namespace BoardGameCafeApp.Services;

public class BookingService
{
    private readonly CafeDbContext _db;

    public BookingService(CafeDbContext db)
    {
        _db = db;
    }
}
