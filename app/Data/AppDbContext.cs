using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace OVSMS_Desktop.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ProviderService> ProviderServices { get; set; }
        public DbSet<Payment> Payments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Database=ovsms_db;User=root;Password=;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- RELATIONSHIP CONFIGURATION ---

            // ProviderService 
            modelBuilder.Entity<ProviderService>().HasKey(ps => new { ps.ProviderId, ps.ServiceId });
            modelBuilder.Entity<ProviderService>().HasOne(ps => ps.Provider).WithMany(u => u.OfferedServices).HasForeignKey(ps => ps.ProviderId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ProviderService>().HasOne(ps => ps.Service).WithMany(s => s.ProvidersOffering).HasForeignKey(ps => ps.ServiceId).OnDelete(DeleteBehavior.Cascade);

            // Booking 
            modelBuilder.Entity<Booking>().HasOne(b => b.User).WithMany(u => u.CustomerBookings).HasForeignKey(b => b.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Booking>().HasOne(b => b.Provider).WithMany(u => u.ProviderBookings).HasForeignKey(b => b.ProviderId).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Booking>().HasOne(b => b.Vehicle).WithMany(v => v.Bookings).HasForeignKey(b => b.VehicleId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Booking>().HasOne(b => b.Service).WithMany(s => s.Bookings).HasForeignKey(b => b.ServiceId).OnDelete(DeleteBehavior.Restrict);

            // Payment
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Booking)
                .WithMany(b => b.Payments)
                .HasForeignKey(p => p.BookingId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        // --- DATABASE INITIALIZATION AND SEEDING CONTROL ---
        public static void InitializeDatabase()
        {
            using (var context = new AppDbContext())
            {
                try
                {
                    context.Database.EnsureCreated();

                    // CRITICAL CHECK: If data exists (because it was inserted manually), skip seeding.
                    if (context.Users.Any())
                    {
                        return;
                    }

                    // ----------------------------------------------------
                    // --- SEEDING LOGIC (Executed ONLY if empty) ---
                    // ----------------------------------------------------

                    // SEED SERVICES
                    var services = new Service[] {
                        new Service { ServiceId = 1, Name = "Regular Maintenance", Description = "Complete vehicle checkup, oil change, filter replacement", Category="Maintenance", BasePrice = 9990.00m },
                        new Service { ServiceId = 2, Name = "Brake Service", Description = "Brake inspection, pad replacement, fluid check", Category="Repairs", BasePrice = 14990.00m },
                        new Service { ServiceId = 3, Name = "Engine Diagnostics", Description = "Computer diagnostics, error code reading", Category="Diagnostics", BasePrice = 7990.00m },
                        new Service { ServiceId = 4, Name = "Tire Service (Balance/Rotate)", Description = "Tire rotation, balancing, alignment, pressure check", Category="Maintenance", BasePrice = 5990.00m },
                        new Service { ServiceId = 5, Name = "Full Detailing", Description = "Full body polish, interior deep clean, paint protection", Category="Detailing", BasePrice = 25000.00m }
                       };
                    context.Services.AddRange(services);


                    // SEED USERS (Using specific Admin name and UserRole Enums)
                    context.Users.AddRange(
                        new User { UserId = 100, Name = "M.J.ZAID AHAMED", Email = "admin@demo.com", Password = "password123", Phone = "+94740279364", Role = UserRole.Admin, IsApproved = true },
                        new User { UserId = 201, Name = "Customer", Email = "customer@demo.com", Password = "password123", Phone = "+94123456789", Role = UserRole.Customer, IsApproved = true },
                        new User { UserId = 202, Name = "Customer Ahamed", Email = "ahamed@demo.com", Password = "password123", Phone = "+94123456789", Role = UserRole.Customer, IsApproved = true },
                        new User { UserId = 301, Name = "Master Mechanic", Email = "provider1@demo.com", Password = "password123", Phone = "+94123456789", Role = UserRole.Provider, IsApproved = true },
                        new User { UserId = 302, Name = "QuickFix", Email = "provider2@demo.com", Password = "password123", Phone = "+94123456789", Role = UserRole.Provider, IsApproved = false }
                    );

                    // SEED VEHICLES
                    context.Vehicles.AddRange(
                        new Vehicle { VehicleId = 1, UserId = 201, Make = "Toyota", Model = "Vios", Year = 2019, RegistrationNumber = "LKR-V801", VehicleType = "Car" },
                        new Vehicle { VehicleId = 2, UserId = 201, Make = "Honda", Model = "Hornet", Year = 2022, RegistrationNumber = "LKR-H202", VehicleType = "Bike" },
                        new Vehicle { VehicleId = 3, UserId = 202, Make = "Suzuki", Model = "Alto", Year = 2015, RegistrationNumber = "LKR-A103", VehicleType = "Car" }
                    );

                    // PROVIDER OFFERINGS
                    context.ProviderServices.AddRange(
                        new ProviderService { ProviderId = 301, ServiceId = 1 },
                        new ProviderService { ProviderId = 301, ServiceId = 2 },
                        new ProviderService { ProviderId = 301, ServiceId = 4 },
                        new ProviderService { ProviderId = 302, ServiceId = 3 },
                        new ProviderService { ProviderId = 302, ServiceId = 5 }
                    );

                    // SEED BOOKINGS (Note: BookingDate uses C# DateTime for CURRENT time)
                    context.Bookings.AddRange(
                        // Completed & Paid
                        new Booking
                        {
                            BookingId = 1001,
                            UserId = 201,
                            VehicleId = 1,
                            ServiceId = 1,
                            ProviderId = 301,
                            BookingDate = DateTime.Now.AddDays(-10),
                            Status = BookingStatus.Completed,
                            Price = 9990.00m,
                            PaymentStatus = PaymentStatus.Paid
                        },
                        // In Progress & Unpaid
                        new Booking
                        {
                            BookingId = 1002,
                            UserId = 201,
                            VehicleId = 2,
                            ServiceId = 2,
                            ProviderId = 301,
                            BookingDate = DateTime.Now.AddDays(-1),
                            Status = BookingStatus.InProgress,
                            Price = 14990.00m,
                            PaymentStatus = PaymentStatus.Unpaid
                        },
                        // Pending & Unpaid
                        new Booking
                        {
                            BookingId = 1003,
                            UserId = 201,
                            VehicleId = 1,
                            ServiceId = 4,
                            ProviderId = 301,
                            BookingDate = DateTime.Now.AddDays(3),
                            Status = BookingStatus.Pending,
                            Price = 5990.00m,
                            PaymentStatus = PaymentStatus.Unpaid
                        },
                        // Cancelled & Unpaid
                        new Booking
                        {
                            BookingId = 1004,
                            UserId = 202,
                            VehicleId = 3,
                            ServiceId = 4,
                            ProviderId = 301,
                            BookingDate = DateTime.Now.AddDays(-20),
                            Status = BookingStatus.Cancelled,
                            Price = 5990.00m,
                            PaymentStatus = PaymentStatus.Unpaid
                        },
                        // Pending & Unassigned
                        new Booking
                        {
                            BookingId = 1005,
                            UserId = 202,
                            VehicleId = 3,
                            ServiceId = 3,
                            ProviderId = null,
                            BookingDate = DateTime.Now.AddDays(5),
                            Status = BookingStatus.Pending,
                            Price = 7990.00m,
                            PaymentStatus = PaymentStatus.Unpaid
                        }
                    );

                    // SEED PAYMENTS
                    context.Payments.Add(new Payment
                    {
                        PaymentId = 1,
                        BookingId = 1001,
                        Amount = 9990.00m,
                        PaymentDate = DateTime.Now.AddDays(-10),
                        PaymentMethod = PaymentMethod.CreditCard,
                        TransactionId = "CC_PAID_7890"
                    });

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error initializing database: {ex.Message}");
                    MessageBox.Show($"Database Error: {ex.Message}\nCould not initialize database.", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}