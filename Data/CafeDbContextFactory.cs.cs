using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BoardGameCafeApp.Data;

public class CafeDbContextFactory : IDesignTimeDbContextFactory<CafeDbContext>
{
    public CafeDbContext CreateDbContext(string[] args)
    {
        // Ensure EF tools can find appsettings.json when running migrations
        var basePath = Directory.GetCurrentDirectory();

        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<CafeDbContext>();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("CafeDb"));

        return new CafeDbContext(optionsBuilder.Options);
    }
}