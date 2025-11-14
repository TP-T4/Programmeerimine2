using System;
using System.Collections.Generic;

namespace KooliProjekt.Application.Data
{
    public class Brewery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mission { get; set; }

        public ICollection<Beer> Beers { get; set; }
    }

    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int BreweryId { get; set; }
        public Brewery Brewery { get; set; }

        public ICollection<Batch> Batches { get; set; }
    }

    public class Batch
    {
        public int Id { get; set; }
        public DateTime BrewDate { get; set; }
        public string BatchCode { get; set; }
        public string Description { get; set; }

        public int BeerId { get; set; }
        public Beer Beer { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<LogEntry> LogEntries { get; set; }
        public ICollection<TastingLog> TastingLogs { get; set; }
    }

    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public float UnitPrice { get; set; }
        public float QuantityUsed { get; set; }
        public float TotalCost { get; set; }

        public int BatchId { get; set; }
        public Batch Batch { get; set; }
    }

    public class LogEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public int BatchId { get; set; }
        public Batch Batch { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class TastingLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Rating { get; set; }
        public string Explanation { get; set; }

        public int BatchId { get; set; }
        public Batch Batch { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<LogEntry> LogEntries { get; set; }
        public ICollection<TastingLog> TastingLogs { get; set; }
    }
}
