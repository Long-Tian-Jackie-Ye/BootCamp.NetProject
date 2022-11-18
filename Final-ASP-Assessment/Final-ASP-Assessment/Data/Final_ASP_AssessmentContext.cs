using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_ASP_Assessment.Models;

namespace Final_ASP_Assessment.Data
{
    public class Final_ASP_AssessmentContext : DbContext
    {
        public Final_ASP_AssessmentContext (DbContextOptions<Final_ASP_AssessmentContext> options)
            : base(options)
        {
        }

        public DbSet<Final_ASP_Assessment.Models.Owners> Owners { get; set; } = default!;

        public DbSet<Final_ASP_Assessment.Models.Claims> Claims { get; set; }

        public DbSet<Final_ASP_Assessment.Models.Vehicles> Vehicles { get; set; }
    }

   /*protected override void OnModelCreating(ModelBuilder modelJoin)
    {
        modelJoin.Entity<Owners>(owners =>
        {
            owners.ToTable("Owners");
            owners.HasKey(o => o.Id);
            owners.Property(o => o.FirstName);
            owners.Property(o => o.LastName);
            owners.Property(o => o.DriverLicense);
        });

        modelJoin.Entity<Claims>(claims =>
        {
            claims.ToTable("Claims");
            claims.HasKey(c => c.Id);
            claims.
            HasOne(c => c.Vehicle_Id).
            WithMany(c => c.id).
            HasForeignKey(c => c.Vehicle_Id);
            claims.Property(c => c.Description);
            claims.Property(c => c.Status);
            claims.Property(c => c.Date);
            claims.Property(c => c.Vehicle_Id);
        });

        modelJoin.Entity<Vehicles>(vehicles =>
        {
            vehicles.ToTable("Vehicles");
            vehicles.
            HasOne(v => v.Owner_Id).
            WithMany(v => v.id).
            HasForeignKey(v => v.Owner_Id);
            vehicles.Property(v => v.Brand);
            vehicles.Property(v => v.Vin);
            vehicles.Property(v => v.Color);
            vehicles.Property(v => v.Year);
            vehicles.Property(v => v.Owner_Id);
        });
    }*/

}
