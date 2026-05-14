using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OVSMS_Desktop.Data
{
    // --- ENUM DEFINITIONS ---
    public enum UserRole { Customer, Provider, Admin }
    public enum BookingStatus { Pending, Confirmed, InProgress, Completed, Cancelled }
    public enum PaymentStatus { Unpaid, Paid, Refunded }
    public enum PaymentMethod { CreditCard, Cash, BankTransfer, ManualOverride }

    // --- USER MODEL ---
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public UserRole Role { get; set; } = UserRole.Customer;
        public bool IsApproved { get; set; } = false;

        public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public virtual ICollection<Booking> CustomerBookings { get; set; } = new List<Booking>();
        public virtual ICollection<Booking> ProviderBookings { get; set; } = new List<Booking>();
        public virtual ICollection<ProviderService> OfferedServices { get; set; } = new List<ProviderService>();
    }

    // --- SERVICE MODEL ---
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Category { get; set; }
        public decimal BasePrice { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        public virtual ICollection<ProviderService> ProvidersOffering { get; set; } = new List<ProviderService>();
    }

    // --- PROVIDER SERVICE JUNCTION TABLE ---
    public class ProviderService
    {
        public int ProviderId { get; set; }
        public int ServiceId { get; set; }
        public virtual User? Provider { get; set; }
        public virtual Service? Service { get; set; }
    }

    // --- VEHICLE MODEL ---
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? VehicleType { get; set; }

        [NotMapped]
        public string DisplayName => $"{Year} {Make} {Model}";

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }

    // --- BOOKING MODEL ---
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public int ServiceId { get; set; }
        public virtual Service? Service { get; set; }

        public int? ProviderId { get; set; }
        public virtual User? Provider { get; set; }

        public System.DateTime BookingDate { get; set; }

        public BookingStatus Status { get; set; } = BookingStatus.Pending;

        public decimal Price { get; set; }

        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Unpaid;

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }

    // --- PAYMENT MODEL ---
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.CreditCard;

        public string TransactionId { get; set; } = string.Empty;

        public int BookingId { get; set; }
        public virtual Booking? Booking { get; set; }
    }
}