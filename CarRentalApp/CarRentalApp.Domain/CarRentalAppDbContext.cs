using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Domain;

public class CarRentalAppDbContext(DbContextOptions<CarRentalAppDbContext> options) : DbContext(options)
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<RentalPlace> RentalPlaces { get; set; }
    public DbSet<RentedCar> RentedCars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<RentedCar>()
            .HasOne(r => r.Car)
            .WithMany()
            .HasForeignKey("car")
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<RentedCar>()
            .HasOne(r => r.Client)
            .WithMany()
            .HasForeignKey("client")
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RentedCar>()
            .HasOne(r => r.RentalPlace)
            .WithMany()
            .HasForeignKey("rentalPlace")
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<RentedCar>()
            .HasOne(r => r.ReturnRentalPlace)
            .WithMany()
            .HasForeignKey("returnRentalPlace")
            .OnDelete(DeleteBehavior.Cascade);
    }
}
