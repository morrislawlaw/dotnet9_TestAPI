using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace dotnet9_TestAPI.Services
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public EmailService(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        public async Task<bool> SendBookingConfirmationEmailAsync(string recipientEmail, string recipientName, int bookingId, string checkIn, string checkOut, string roomDetails, string totalPaidHkd)
        {
            var apiKey = _configuration["Brevo:ApiKey"];
            var fromEmail = _configuration["Brevo:FromEmail"];
            var fromName = _configuration["Brevo:FromName"];

            if (string.IsNullOrEmpty(apiKey))
            {
                Console.WriteLine("❌ Email Configuration Error: Brevo API Key is missing.");
                return false;
            }

            // Define the JSON payload layout expected by Brevo's v3 API
            var emailPayload = new
            {
                sender = new { name = fromName, email = fromEmail },
                to = new[] { new { email = recipientEmail, name = recipientName } },
                subject = "Your HotelBook Reservation is Confirmed! 🎉",
                htmlContent = $@"
                    <div style='font-family: sans-serif; max-width: 600px; margin: 0 auto; border: 1px solid #e2e8f0; border-radius: 24px; overflow: hidden; box-shadow: 0 4px 6px -1px rgba(0,0,0,0.05);'>
                        <div style='background: linear-gradient(135deg, #2563eb, #4f46e5); padding: 32px; text-align: center; color: white;'>
                            <h1 style='margin: 0; font-size: 28px; font-weight: 800;'>Booking Confirmed!</h1>
                            <p style='margin: 8px 0 0 0; opacity: 0.9;'>Thank you for choosing HotelBook</p>
                        </div>
                        <div style='padding: 32px; background-color: #ffffff;'>
                            <h3 style='margin-top: 0; color: #0f172a; font-size: 20px;'>Hi {recipientName},</h3>
                            <p style='color: #475569; line-height: 1.6;'>Your card payment cleared successfully via Stripe. Your room inventory is locked down and your itinerary details are ready below:</p>
                            
                            <div style='background-color: #f8fafc; border-radius: 16px; padding: 24px; margin: 24px 0;'>
                                <table style='width: 100%; border-collapse: collapse; font-size: 15px;'>
                                    <tr><td style='padding: 6px 0; color: #64748b;'><strong>Booking Reference:</strong></td><td style='text-align: right; color: #0f172a; font-family: monospace; font-weight: bold;'>#{bookingId}</td></tr>
                                    <tr><td style='padding: 6px 0; color: #64748b;'><strong>Check-In Date:</strong></td><td style='text-align: right; color: #0f172a;'>{checkIn}</td></tr>
                                    <tr><td style='padding: 6px 0; color: #64748b;'><strong>Check-Out Date:</strong></td><td style='text-align: right; color: #0f172a;'>{checkOut}</td></tr>
                                    <tr><td style='padding: 6px 0; color: #64748b;'><strong>Assigned Rooms:</strong></td><td style='text-align: right; color: #0f172a;'>{roomDetails}</td></tr>
                                    <tr style='border-top: 1px solid #e2e8f0;'><td style='padding: 12px 0 0 0; color: #0f172a; font-weight: bold; font-size: 18px;'>Total Paid:</td><td style='padding: 12px 0 0 0; text-align: right; color: #10b981; font-weight: 900; font-size: 20px;'>HKD {totalPaidHkd}</td></tr>
                                </table>
                            </div>

                            <p style='color: #475569; font-size: 14px;'>You can view, update, or cancel your itinerary rules anytime by logging into your account dashboard profile under the 'My Bookings' tab.</p>
                            <hr style='border: 0; border-top: 1px solid #f1f5f9; margin: 32px 0;' />
                            <p style='text-align: center; color: #94a3b8; font-size: 12px; margin: 0;'>&copy; 2026 HotelBook Inc. Hong Kong • Taipei • Singapore</p>
                        </div>
                    </div>"
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.brevo.com/v3/smtp/email");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("api-key", apiKey);
            request.Content = new StringContent(JsonSerializer.Serialize(emailPayload), Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request);
            return response.IsSuccessStatusCode;
        }
    }
}