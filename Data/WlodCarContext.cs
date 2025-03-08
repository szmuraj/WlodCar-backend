// Ignore Spelling: Wlod

using WlodCarBackend.Models;
using Microsoft.EntityFrameworkCore;


namespace WlodCarBackend.Data;
public class WlodCarContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().ToTable("Cars");
        modelBuilder.Entity<Customer>().ToTable("Customers");
        modelBuilder.Entity<Reservation>().ToTable("Reservations");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=WlodCar;User Id=sa;Password=Password123;");
    }
}
