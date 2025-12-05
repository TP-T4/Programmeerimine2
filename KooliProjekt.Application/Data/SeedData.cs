using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Data
{
    public static class SeedData
    {
        public static void Generate(ApplicationDbContext db)
        {
            db.Database.Migrate();

            // ära tee duplikaate
            if (db.Breweries.Any())
                return;

            // -----------------------
            // USERS
            // -----------------------
            var users = Enumerable.Range(1, 10).Select(i => new User
            {
                Username = $"user{i}",
                Password = "test"  // ainult seed, mitte päris
            }).ToList();
            db.Users.AddRange(users);
            db.SaveChanges();

            // -----------------------
            // BREWERIES
            // -----------------------
            var breweries = Enumerable.Range(1, 10).Select(i => new Brewery
            {
                Name = $"Brewery {i}",
                Mission = $"Mission of Brewery {i}"
            }).ToList();
            db.Breweries.AddRange(breweries);
            db.SaveChanges();

            // -----------------------
            // BEERS
            // -----------------------
            var beers = Enumerable.Range(1, 10).Select(i => new Beer
            {
                Name = $"Beer {i}",
                Description = $"Beer desc {i}",
                BreweryId = breweries[(i - 1) % breweries.Count].Id
            }).ToList();
            db.Beers.AddRange(beers);
            db.SaveChanges();

            // -----------------------
            // BATCHES
            // -----------------------
            var batches = Enumerable.Range(1, 10).Select(i => new Batch
            {
                BatchCode = $"BATCH-{i:000}",
                Description = $"Batch desc {i}",
                BrewDate = DateTime.UtcNow.AddDays(-i),
                BeerId = beers[(i - 1) % beers.Count].Id
            }).ToList();
            db.Batches.AddRange(batches);
            db.SaveChanges();

            // -----------------------
            // INGREDIENTS
            // -----------------------
            var ingredients = Enumerable.Range(1, 10).Select(i => new Ingredient
            {
                Name = $"Ingredient {i}",
                Unit = "kg",
                UnitPrice = 2.5f,
                QuantityUsed = i,
                TotalCost = i * 2.5f,
                BatchId = batches[(i - 1) % batches.Count].Id
            }).ToList();
            db.Ingredients.AddRange(ingredients);
            db.SaveChanges();

            // -----------------------
            // LOG ENTRIES
            // -----------------------
            var logEntries = Enumerable.Range(1, 10).Select(i => new LogEntry
            {
                Date = DateTime.UtcNow.AddDays(-i),
                Description = $"Log entry {i}",
                UserId = users[(i - 1) % users.Count].Id,
                BatchId = batches[(i - 1) % batches.Count].Id
            }).ToList();
            db.LogEntries.AddRange(logEntries);
            db.SaveChanges();

            // -----------------------
            // TASTING LOGS
            // -----------------------
            var tastingLogs = Enumerable.Range(1, 10).Select(i => new TastingLog
            {
                Date = DateTime.UtcNow.AddDays(-i),
                Explanation = $"Tasting log {i}",
                Rating = (i % 5) + 1,
                UserId = users[(i - 1) % users.Count].Id,
                BatchId = batches[(i - 1) % batches.Count].Id
            }).ToList();
            db.TastingLogs.AddRange(tastingLogs);
            db.SaveChanges();
        }
    }
}
