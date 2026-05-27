using BoardGameCafeApp.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGameCafeApp.Services;

public class RentalService
{
    private readonly CafeDbContext _db;

    public RentalService(CafeDbContext db)
    {
        _db = db;
    }
}
