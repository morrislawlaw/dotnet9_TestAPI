using dotnet9_TestAPI.Models;
using HotelBookingSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace dotnet9_TestAPI.Services
{
    public class BookingService
    {
        private readonly HotelBookingSystemDbContext _context;

        public BookingService(HotelBookingSystemDbContext context)
        {
            _context = context;
        }

        // 1. CreateBooking
        public async Task<BookingCreationResultDto?> CreateBookingAsync(
            int customerId, DateOnly checkIn, DateOnly checkOut, string roomIdsCsv, bool paymentSuccess = true)
        {
            var result = await _context.Set<BookingCreationResultDto>()
                .FromSqlInterpolated($"""
                EXEC dbo.CreateBooking 
                    @CustomerID = {customerId}, 
                    @CheckInDate = {checkIn}, 
                    @CheckOutDate = {checkOut}, 
                    @RoomIDs = {roomIdsCsv}, 
                    @PaymentSuccess = {paymentSuccess}
                """)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return result;
        }

        // 2. CancelBooking
        public async Task CancelBookingAsync(int bookingId, string? reason = null)
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($"""
            EXEC dbo.CancelBooking @BookingID = {bookingId}, @Reason = {reason}
            """);
        }

        // 3. CheckRoomAvailability
        public async Task<List<RoomAvailabilityDto>> CheckRoomAvailabilityAsync(
            int? hotelId, DateOnly checkIn, DateOnly checkOut, int? roomTypeId = null)
        {
            return await _context.Set<RoomAvailabilityDto>()
                .FromSqlInterpolated($"""
                EXEC dbo.CheckRoomAvailability 
                    @HotelID = {hotelId}, 
                    @CheckInDate = {checkIn}, 
                    @CheckOutDate = {checkOut}, 
                    @RoomTypeID = {roomTypeId}
                """)
                .AsNoTracking()
                .ToListAsync();
        }

        // 4. CheckInBooking
        public async Task CheckInBookingAsync(int bookingId)
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($"""
            EXEC dbo.CheckInBooking @BookingID = {bookingId}
            """);
        }

        // 5. CheckOutBooking
        public async Task CheckOutBookingAsync(int bookingId)
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($"""
            EXEC dbo.CheckOutBooking @BookingID = {bookingId}
            """);
        }

        // 6. UpdateBooking
        public async Task<BookingDetailsDto?> UpdateBookingAsync(
            int bookingId,
            DateOnly? newCheckIn = null,
            DateOnly? newCheckOut = null,
            string? newRoomIdsCsv = null,
            string? newStatus = null)
        {
            var result = await _context.Set<BookingDetailsDto>()
                .FromSqlInterpolated($"""
                EXEC dbo.UpdateBooking 
                    @BookingID = {bookingId},
                    @NewCheckInDate = {newCheckIn},
                    @NewCheckOutDate = {newCheckOut},
                    @NewRoomIDs = {newRoomIdsCsv},
                    @NewStatus = {newStatus}
                """)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return result;
        }

        // 7. GetBookingDetails
        public async Task<BookingDetailsDto?> GetBookingDetailsAsync(int bookingId)
        {
            return await _context.Set<BookingDetailsDto>()
                .FromSqlInterpolated($"""
                EXEC dbo.GetBookingDetails @BookingID = {bookingId}
                """)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        // Bonus: Use the View directly (no stored proc needed)
        public IQueryable<BookingReportDto> GetBookingReport()
            => _context.BookingReports.AsNoTracking();
    }
}
