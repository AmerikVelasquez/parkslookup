using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
      :base (options)
      {
      }
      public DbSet<Park> Parks {get;set;} 

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name= "Big Hole", Type = "National Park", Location= "Montana" },
          new Park { ParkId = 2, Name= "Fort Vancouver", Type = "National Park", Location= "Washington" },
          new Park { ParkId = 3, Name= "Eleanor Roosevelt", Type = "National Park", Location= "New York" },
          new Park { ParkId = 4, Name= "Goldendale Observatory", Type = "State Park", Location= "Washington" },
          new Park { ParkId = 5, Name= "Big Hole", Type = "National Park", Location= "Montana" }
        );
    }
  }
}