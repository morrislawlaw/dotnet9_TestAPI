using dotnet9_TestAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Entities;

public partial class HotelBookingSystemDbContext : DbContext
{
    public HotelBookingSystemDbContext()
    {
    }

    public HotelBookingSystemDbContext(DbContextOptions<HotelBookingSystemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingRoom> BookingRooms { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomType> RoomTypes { get; set; }

    public virtual DbSet<VwBookingReport> VwBookingReports { get; set; }

    public virtual DbSet<VwCustomerBooking> VwCustomerBookings { get; set; }

    // Keyless entities for stored procedures + view
    public DbSet<RoomAvailabilityDto> RoomAvailabilityResults { get; set; }
    public DbSet<BookingDetailsDto> BookingDetailsResults { get; set; }
    public DbSet<BookingReportDto> BookingReports { get; set; }   // for the VIEW
    public DbSet<BookingCreationResultDto> BookingCreationResults { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=MorrisComputer;Database=HotelBookingSystem;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasIndex(e => e.CheckInDate, "IX_Bookings_CheckInDate");

            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.BookingDate).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pending");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(12, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bookings_Customers");
        });

        modelBuilder.Entity<BookingRoom>(entity =>
        {
            entity.HasKey(e => new { e.BookingId, e.RoomId });

            entity.ToTable(tb => tb.HasTrigger("trg_PreventDoubleBooking"));

            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.PricePerNight).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingRooms)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK_BookingRooms_Bookings");

            entity.HasOne(d => d.Room).WithMany(p => p.BookingRooms)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookingRooms_Rooms");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasIndex(e => e.Email, "IX_Customers_Email");

            entity.HasIndex(e => e.Email, "UQ_Customers_Email").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.HotelName).HasMaxLength(100);
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasIndex(e => new { e.HotelId, e.RoomTypeId }, "IX_Rooms_HotelID_RoomTypeID");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.RoomNumber).HasMaxLength(10);
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");

            entity.HasOne(d => d.Hotel).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.HotelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rooms_Hotels");

            entity.HasOne(d => d.RoomType).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.RoomTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rooms_RoomTypes");
        });

        modelBuilder.Entity<RoomType>(entity =>
        {
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
            entity.Property(e => e.BasePricePerNight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<VwBookingReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_BookingReport");

            entity.Property(e => e.BookingCategory)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.BookingDateFriendly)
                .HasMaxLength(4000)
                .HasColumnName("BookingDate_Friendly");
            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.CheckInFriendly)
                .HasMaxLength(4000)
                .HasColumnName("CheckIn_Friendly");
            entity.Property(e => e.CheckOutFriendly)
                .HasMaxLength(4000)
                .HasColumnName("CheckOut_Friendly");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(101);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.HotelName).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.RoomsBooked).HasMaxLength(4000);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TotalAmountHkd)
                .HasMaxLength(4000)
                .HasColumnName("TotalAmount_HKD");
        });

        modelBuilder.Entity<VwCustomerBooking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_CustomerBookings");

            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.HotelName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
