using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Application.Data
{
    public class Brewery : Entity
    {

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Mission { get; set; }

        public ICollection<Beer> Beers { get; set; }
    }

    public class Beer : Entity
    {
        
        [Required]
        [MaxLength(120)]
        public string Name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public int BreweryId { get; set; }
        public Brewery Brewery { get; set; }

        public ICollection<Batch> Batches { get; set; }
    }

    public class Batch : Entity
    {
        
        [Required]
        public DateTime BrewDate { get; set; }

        [Required]
        [MaxLength(60)]
        public string BatchCode { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public int BeerId { get; set; }
        public Beer Beer { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
        public ICollection<LogEntry> LogEntries { get; set; }
        public ICollection<TastingLog> TastingLogs { get; set; }
    }

    public class Ingredient : Entity
    {
        
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Unit { get; set; }

        [Range(0, double.MaxValue)]
        public float UnitPrice { get; set; }

        [Range(0, double.MaxValue)]
        public float QuantityUsed { get; set; }

        [Range(0, double.MaxValue)]
        public float TotalCost { get; set; }

        public int BatchId { get; set; }
        public Batch Batch { get; set; }
    }

    public class LogEntry : Entity
    {
        
        [Required]
        public DateTime Date { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        public int BatchId { get; set; }
        public Batch Batch { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class TastingLog : Entity
    {
        
        [Required]
        public DateTime Date { get; set; }

        [Range(0, 10)]
        public float Rating { get; set; }

        [MaxLength(2000)]
        public string Explanation { get; set; }

        public int BatchId { get; set; }
        public Batch Batch { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

    public class User : Entity
    {
        
        [Required]
        [MaxLength(80)]
        public string Username { get; set; }

        [Required]
        [MaxLength(256)]
        public string Password { get; set; }

        public ICollection<LogEntry> LogEntries { get; set; }
        public ICollection<TastingLog> TastingLogs { get; set; }
    }
}
