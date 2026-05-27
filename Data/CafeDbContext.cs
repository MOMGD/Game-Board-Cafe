using BoardGameCafeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGameCafeApp.Data
{
    public class CafeDbContext : DbContext
    {
        public CafeDbContext(DbContextOptions<CafeDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games => Set<Game>();
        public DbSet<Rental> Rentals => Set<Rental>();
        public DbSet<CafeTable> CafeTables => Set<CafeTable>();
        public DbSet<Booking> Bookings => Set<Booking>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Game (1) -> Rentals (many)
            modelBuilder.Entity<Rental>()
                .HasOne(r => r.Game)
                .WithMany(g => g.Rentals)
                .HasForeignKey(r => r.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            // CafeTable (1) -> Bookings (many)
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.CafeTable)
                .WithMany(t => t.Bookings)
                .HasForeignKey(b => b.CafeTableId)
                .OnDelete(DeleteBehavior.Restrict);

            // Helpful indexes for filtering/search
            modelBuilder.Entity<Game>()
                .HasIndex(g => g.Title);

            modelBuilder.Entity<Rental>()
                .HasIndex(r => r.CustomerName);

            modelBuilder.Entity<Booking>()
                .HasIndex(b => b.CustomerName);
        }
    }

}
