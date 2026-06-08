using dotnet9_TestAPI.Models;
using HotelBookingSystem.Entities;
using Humanizer;
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
            var results = await _context.Set<BookingCreationResultDto>()
            .FromSqlInterpolated($"""
            EXEC dbo.CreateBooking 
                @CustomerID = {customerId}, 
                @CheckInDate = {checkIn}, 
                @CheckOutDate = {checkOut}, 
                @RoomIDs = {roomIdsCsv}, 
                @PaymentSuccess = {paymentSuccess}
            """)
            .AsNoTracking()
            .ToListAsync();                    // This executes the proc

            return results.FirstOrDefault();
        }

        // 2. CancelBooking
        public async Task<OperationResultDto> CancelBookingAsync(int bookingId, string? reason = null)
        {
            var results = await _context.Set<OperationResultDto>()
            .FromSqlInterpolated($"""
            EXEC dbo.CancelBooking 
                @BookingID = {bookingId}, 
                @Reason = {reason}
            """)
            .AsNoTracking()
            .ToListAsync();

            return results.FirstOrDefault()
                   ?? new OperationResultDto
                   {
                       Success = false,
                       Message = "Unknown error occurred."
                   };
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

        // 3.5 GetAvailableHotelsList
        public async Task<List<AvailableHotelQueryResultDto>> GetAvailableHotelsListAsync(
            DateOnly checkIn, DateOnly checkOut, int guests)
        {
            return await _context.Set<AvailableHotelQueryResultDto>()
            .FromSqlInterpolated($@"
                EXEC [dbo].[GetAvailableHotels] 
                    @CheckInDate = {checkIn}, 
                    @CheckOutDate = {checkOut}, 
                    @MaxGuests = {guests}"
            )
            .AsNoTracking()
            .ToListAsync();
        }


        // 4. CheckInBooking
        public async Task<OperationResultDto> CheckInBookingAsync(int bookingId)
        {
            var result = await _context.Set<OperationResultDto>().FromSqlInterpolated($"""
            EXEC dbo.CheckInBooking @BookingID = {bookingId}
            """).AsNoTracking().ToListAsync();

            return result.FirstOrDefault() ?? new OperationResultDto
            {
                Success = false,
                Message = "Unknown error occurred."
            };
        }

        // 5. CheckOutBooking
        public async Task<OperationResultDto> CheckOutBookingAsync(int bookingId)
        {
            var result = await _context.Set<OperationResultDto>().FromSqlInterpolated($"""
            EXEC dbo.CheckOutBooking @BookingID = {bookingId}
            """).AsNoTracking().ToListAsync();

            return result.FirstOrDefault() ?? new OperationResultDto
            {
                Success = false,
                Message = "Unknown error occurred."
            };
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
                .ToListAsync();

            return result.FirstOrDefault();
        }

        // 7. GetBookingDetails
        public async Task<BookingDetailsDto?> GetBookingDetailsAsync(int bookingId)
        {
            var result = await _context.Set<BookingDetailsDto>()
                .FromSqlInterpolated($"""
                EXEC dbo.GetBookingDetails @BookingID = {bookingId}
                """)
                .AsNoTracking()
                .ToListAsync();

            return result.FirstOrDefault();
        }

        // Bonus: Use the View directly (no stored proc needed)
        public IQueryable<BookingReportDto> GetBookingReport()
            => _context.Set<BookingReportDto>().AsNoTracking();   // Use Set<T>() instead


        public async Task<List<BookingReportDto>> GetBookingReportListAsync(string? statusFilter = null, DateOnly? fromDate = null, DateOnly? toDate = null)
        {
            var query = GetBookingReport();

            if (!string.IsNullOrEmpty(statusFilter))
                query = query.Where(r => r.Status == statusFilter);

            if (fromDate.HasValue)
                query = query.Where(r => r.CheckInDate >= fromDate.Value);

            if (toDate.HasValue)
                query = query.Where(r => r.CheckInDate <= toDate.Value);

            return await query
                .OrderByDescending(r => r.CheckInDate)
                .ThenBy(r => r.BookingID)
                .ToListAsync();
        }


        // Helper method
        public async Task<bool> BookingIDExists(int id)
        {
            return await _context.Bookings.AnyAsync(e => e.BookingId == id);
        }
    }
}
