using Microsoft.EntityFrameworkCore;

namespace CretaceousPark.Models
{
  public class CretaceousParkContext : DbContext
  {
    public CretaceousParkContext(DbContextOptions<CretaceousParkContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Ronald", Species = "Woolly Mammoth", Age = 7, Gender = "Female" },
              new Animal { AnimalId = 2, Name = "Jan", Species = "Dinosaur", Age = 10, Gender = "Female" },
              new Animal { AnimalId = 3, Name = "Bobbie", Species = "Dinosaur", Age = 2, Gender = "Female" },
              new Animal { AnimalId = 4, Name = "Simon", Species = "Shark", Age = 4, Gender = "Male" },
              new Animal { AnimalId = 5, Name = "Dan", Species = "Dinosaur", Age = 22, Gender = "Male" }
          );
    }
  }

}