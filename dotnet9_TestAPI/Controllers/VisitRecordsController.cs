using Anderson_Road.Entities;
using Anderson_Road.Models;
using Azure;
using dotnet9_TestAPI.Entities.Anderson_Road;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet9_TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VisitRecordsController : ControllerBase
    {
        private readonly Anderson_RoadDbContext _context;

        public VisitRecordsController(Anderson_RoadDbContext context)
        {
            _context = context;
        }

        //GET: api/VisitRecord/count  → Get Visitor Record count
        [HttpGet("count")]
        public async Task<ActionResult<ResponseVisitorRecordCount>> GetAllVisitRecordsCount()
        {
            //var targetDate = new DateTime(2026, 1, 1, 0, 0, 0);   // January 1, 2026, 00:00:00
            //var targetDate = DateTime.Parse("2026-01-01T00:00:00");
            //var targetDate = DateTime.ParseExact("2026-01-01 00:00:00","yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

            var StartTime = DateTime.Parse("2026-01-01T00:00:00");

            var count = await _context.VisitRecords.Where(v => v.BookingFromTime >= StartTime).CountAsync();
            ResponseVisitorRecordCount response = new ResponseVisitorRecordCount
            {
                count = count
            };

            return Ok(ApiResponse<ResponseVisitorRecordCount>.Success(response));
        }

        // GET: api/VisitRecord  → Get all records
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VisitRecord>>> GetAllVisitRecords()
        {
            var records = await _context.VisitRecords
                                        .OrderByDescending(v => v.AddDt)   // Latest first
                                        .Take(100)                          // Limit to 100 records
                                        .ToListAsync();

            return Ok(ApiResponse<List<VisitRecord>>.Success(records));
        }

        // Post: api/VisitRecord  → Get all records
        [HttpPost("GetAccessEvent")]
        public async Task<ActionResult<List<AccessEventRecordsAction>>> GetAcessEventLog([FromBody] AccessEventLogDto dto)
        {
            var data = await GetRecentAccessEventsAsync(dto.page, dto.pageSize, dto.DeviceId);

            return Ok(ApiResponse<List<AccessEventRecordsAction>>.Success(data));
        }


        //// POST: api/VisitRecords/Create  → Create new visit record
        [HttpPost("Create")]
        public async Task<ActionResult<ApiResponse<VisitRecordCreateDto>>> Create([FromBody] VisitRecordCreateDto dto)
        {
            if (dto == null)
                return Ok(ApiResponse<object>.Error(-1, "Invalid input data."));

            bool update_flag = false;

            //check card_id
            string latestVisitorID = await GetLatestVisitorID();

            string Visitor_ID_Date = latestVisitorID.Substring(0, 6);
            int PersonNumber = Int32.Parse(latestVisitorID.Substring(2, latestVisitorID.Length - 2));
            string addZero = "0000" + PersonNumber.ToString();

            string card_id = "";
            //Reset Visitor_id_date to current date if required
            if (DateTime.Now.ToString("yyMMdd") != Visitor_ID_Date)
            {
                //Update the card_id
                card_id = DateTime.Now.ToString("yyMMdd") + "00001";
                update_flag = await UpdateLatestVisitorID(card_id);
            }
            latestVisitorID = await GetLatestVisitorID();
            Visitor_ID_Date = latestVisitorID.Substring(0, 6);
            PersonNumber = Int32.Parse(latestVisitorID.Substring(2, latestVisitorID.Length - 2)) + 1;
            addZero = "0000" + PersonNumber.ToString();
            //MessageBox.Show(addZero);
            string NextVisitorID = Visitor_ID_Date + addZero.Substring(addZero.Length - 5, 5);

            //Set NextVisitorID
            update_flag = await UpdateLatestVisitorID(NextVisitorID);

            // Map DTO → Entity
            var entity = new VisitRecord
            {
                HomeId = Guid.NewGuid().ToString(),
                Interviewer = dto.ResidentCardId ?? "",
                CardId = latestVisitorID,
                BookingDate = dto.BookingCommence?.Date,
                BookingFromTime = dto.BookingCommence,
                BookingToTime = dto.BookingExpiry,
                AddDt = DateTime.Now,
                // Map other fields as needed...
                IsUpdate = false,
                Status = null
            };

            _context.VisitRecords.Add(entity);
            await _context.SaveChangesAsync();

            ResponseVisitorRecordCreate response = new ResponseVisitorRecordCreate
            {
                Booking_id = entity.HomeId,
            };

            return Ok(ApiResponse<ResponseVisitorRecordCreate>.Success(response));
        }

        //POST: api/VisitRecords/Create  → Create new visit record
        [HttpPost("BulkCreate")]
        public async Task<ActionResult<ApiResponse<VisitRecordCreateDto>>> BulkCreate([FromBody] List<VisitRecordCreateDto> dtos)
        {
            if (dtos == null || dtos.Count == 0)
                return Ok(ApiResponse<object>.Error(-1, "Bulk Insert Failed: The list is empty."));

            bool update_flag = false;

            try
            {
                string latestVisitorID = await GetLatestVisitorID();
                string Visitor_ID_Date = latestVisitorID.Substring(0, 6);
                string card_id = "";
                //Reset Visitor_id_date to current date if required
                if (DateTime.Now.ToString("yyMMdd") != Visitor_ID_Date)
                {
                    //Update the card_id
                    card_id = DateTime.Now.ToString("yyMMdd") + "00001";
                    update_flag = await UpdateLatestVisitorID(card_id);
                    latestVisitorID = await GetLatestVisitorID();
                    Visitor_ID_Date = latestVisitorID.Substring(0, 6);
                }
                int PersonNumber = Int32.Parse(latestVisitorID.Substring(2, latestVisitorID.Length - 2)) + 1;
                string addZero = "";
                string NextVisitorID = "";

                //Set NextVisitorID
                //update_flag = await UpdateLatestVisitorID(NextVisitorID);

                var entities = new List<VisitRecord>();

                //revise the dtos and insert back the Card_id from the database.
                foreach (var dto in dtos)
                {
                    PersonNumber++;
                    addZero = "0000" + PersonNumber.ToString();
                    NextVisitorID = Visitor_ID_Date + addZero.Substring(addZero.Length - 5, 5);

                    var entity = new VisitRecord
                    {
                        HomeId = Guid.NewGuid().ToString(),
                        Interviewer = dto.ResidentCardId ?? "",
                        CardId = NextVisitorID,
                        BookingDate = dto.BookingCommence?.Date,
                        BookingFromTime = dto.BookingCommence,
                        BookingToTime = dto.BookingExpiry,
                        AddDt = DateTime.Now,
                        // Map other fields as needed...
                        IsUpdate = false,
                        Status = null
                    };
                    entities.Add(entity);
                }

                //update the unused Visitor_card_id back to DB
                latestVisitorID = NextVisitorID;
                Visitor_ID_Date = latestVisitorID.Substring(0, 6);
                PersonNumber = Int32.Parse(latestVisitorID.Substring(2, latestVisitorID.Length - 2)) + 1;
                addZero = "0000" + PersonNumber.ToString();
                NextVisitorID = Visitor_ID_Date + addZero.Substring(addZero.Length - 5, 5);

                //Set NextVisitorID
                update_flag = await UpdateLatestVisitorID(NextVisitorID);

                //Bulk insert here
                await _context.VisitRecords.AddRangeAsync(entities);
                int rowsInserted = await _context.SaveChangesAsync();

                ResponseVisitorRecordBulkCreate response = new ResponseVisitorRecordBulkCreate
                {
                    Inserted_Success_Count = rowsInserted
                };

                return Ok(ApiResponse<ResponseVisitorRecordBulkCreate>.Success(response));
            }
            catch (Exception ex)
            {
                return Ok(ApiResponse<object>.Error(-1, "Bulk Insert Failed: " + ex.Message));
            }
        }

        // POST: api/VisitRecords/Update → Update existing record
        [HttpPost("Update")]
        public async Task<ActionResult<ApiResponse<VisitRecordCreateDto>>> UpdateVisitRecord([FromBody] VisitRecordEditDto dto)
        {
            bool exists = await VisitRecordExists(dto.Booking_id);
            if (!exists)
                return Ok(ApiResponse<object>.Error(-1, "Record does not exist."));

            // Pre-compute values outside the lambda (this solves the null operator issue)
            DateTime? bookingDate = dto.BookingCommence?.Date;
            string interviewer = dto.ResidentCardId ?? "";
            DateTime? fromTime = dto.BookingCommence;
            DateTime? toTime = dto.BookingExpiry;
            DateTime addDt = DateTime.Now;   // or UtcNow

            int rowsAffected = await _context.VisitRecords.Where(v => v.HomeId == dto.Booking_id)
                                        .ExecuteUpdateAsync(v => v.SetProperty(r => r.Interviewer, interviewer)
                                                                  .SetProperty(r => r.BookingDate, bookingDate)
                                                                  .SetProperty(r => r.BookingFromTime, fromTime)
                                                                  .SetProperty(r => r.BookingToTime, toTime)
                                                                  .SetProperty(r => r.AddDt, addDt));

            ResponseVisitorRecordCreate response = new ResponseVisitorRecordCreate
            {
                Booking_id = dto.Booking_id
            };

            if (rowsAffected > 0)
                return Ok(ApiResponse<ResponseVisitorRecordCreate>.Success(response));
            else
                return Ok(ApiResponse<object>.Error(-1, "Update Failed"));

        }

        //Classic way
        ////// POST: api/VisitRecords/Update → Update existing record
        ////[HttpPost("Update")]
        ////public async Task<ActionResult<ApiResponse<VisitRecordCreateDto>>> UpdateVisitRecord([FromBody] VisitRecordEditDto dto)
        ////{
        ////    bool exists = await VisitRecordExists(dto.Booking_id);
        ////    if (!exists)
        ////        return Ok(ApiResponse<object>.Error(-1, "Record does not exist."));

        ////    var record = await _context.VisitRecords.Where(v => v.HomeId == dto.Booking_id).FirstOrDefaultAsync();
        ////    if (record != null)
        ////    {
        ////        record.Interviewer = dto.ResidentCardId ?? "";
        ////        record.BookingDate = dto.BookingCommence?.Date;
        ////        record.BookingFromTime = dto.BookingCommence;
        ////        record.BookingToTime = dto.BookingExpiry;
        ////        record.AddDt = DateTime.Now;
        ////    }
        ////    int rowsAffected = await _context.SaveChangesAsync();

        ////    ResponseVisitorRecordCreate response = new ResponseVisitorRecordCreate
        ////    {
        ////        Booking_id = dto.Booking_id
        ////    };

        ////    if (rowsAffected > 0)
        ////        return Ok(ApiResponse<ResponseVisitorRecordCreate>.Success(response));
        ////    else
        ////        return Ok(ApiResponse<object>.Error(-1, "Update Failed"));

        ////}

        // POST: api/VisitRecords/Update → Update existing record
        [HttpPost("BulkUpdate")]
        public async Task<ActionResult<ApiResponse<VisitRecordCreateDto>>> BulkUpdateVisitRecord([FromBody] List<VisitRecordEditDto> dtos)
        {
            foreach (var dto in dtos)
            {
                bool exists = await VisitRecordExists(dto.Booking_id);
                if (!exists)
                    return Ok(ApiResponse<object>.Error(-1, dto.Booking_id + "Record does not exist."));
            }

            int totalRowsAffected = 0;

            foreach (var dto in dtos)
            {
                // Pre-compute values outside the lambda (this solves the null operator issue)
                DateTime? bookingDate = dto.BookingCommence?.Date;
                string interviewer = dto.ResidentCardId ?? "";
                DateTime? fromTime = dto.BookingCommence;
                DateTime? toTime = dto.BookingExpiry;
                DateTime addDt = DateTime.Now;   // or UtcNow

                int rowsAffected = await _context.VisitRecords.Where(v => v.HomeId == dto.Booking_id)
                                            .ExecuteUpdateAsync(v => v.SetProperty(r => r.Interviewer, interviewer)
                                                                      .SetProperty(r => r.BookingDate, bookingDate)
                                                                      .SetProperty(r => r.BookingFromTime, fromTime)
                                                                      .SetProperty(r => r.BookingToTime, toTime)
                                                                      .SetProperty(r => r.AddDt, addDt));

                totalRowsAffected += rowsAffected;
            }




            ResponseVisitorRecordBulkUpdate response = new ResponseVisitorRecordBulkUpdate
            {
                Updated_Success_Count = totalRowsAffected
            };

            if (totalRowsAffected > 0)
                return Ok(ApiResponse<ResponseVisitorRecordBulkUpdate>.Success(response));
            else
                return Ok(ApiResponse<object>.Error(-1, "Update Failed"));

        }

        // Post: api/VisitRecords/Cancel  → Delete record
        [HttpPost("Cancel")]
        public async Task<ActionResult<ApiResponse<VisitRecordCreateDto>>> DeleteVisitRecord([FromBody] VisitRecordDeleteDto dto)
        {
            bool exists = await VisitRecordExists(dto.Booking_id);
            if (!exists)
                return Ok(ApiResponse<object>.Error(-1, "Record does not exist."));

            int rowAffected = await _context.VisitRecords.Where(v => v.HomeId == dto.Booking_id).ExecuteDeleteAsync();

            ResponseVisitorRecordCreate response = new ResponseVisitorRecordCreate
            {
                Booking_id = dto.Booking_id
            };

            if (rowAffected > 0)
                return Ok(ApiResponse<ResponseVisitorRecordCreate>.Success(response));
            else
                return Ok(ApiResponse<object>.Error(-1, "Delete Failed"));
        }

        // Helper method
        private async Task<bool> VisitRecordExists(string id)
        {
            return await _context.VisitRecords.AnyAsync(e => e.HomeId == id);
        }

        private async Task<string> GetLatestVisitorID()
        {
            var latestVisitorID = await _context.SysInfos.Where(v => v.SysKey == "Anderson_Visitor_Card_id").Select(v => v.SysValues).FirstOrDefaultAsync();

            return latestVisitorID ?? "00000000000";
        }

        private async Task<bool> UpdateLatestVisitorID(string card_id)
        {
            int rowsAffected = 0;
            var record = await _context.SysInfos.Where(v => v.SysKey == "Anderson_Visitor_Card_id").FirstOrDefaultAsync();

            if (record != null)
            {
                record.SysValues = card_id;
                _context.SysInfos.Update(record);
                rowsAffected = await _context.SaveChangesAsync();
            }

            return rowsAffected > 0;
        }

        private async Task<List<AccessEventRecordsAction>> GetRecentAccessEventsAsync(int pageNumber = 1, int pageSize = 50, string? deviceId = null)
        {
            DateTime startTime = DateTime.Now.AddYears(-5);
            DateTime endTime = DateTime.Now;

            var query = from a in _context.AccessEventRecords.AsNoTracking()

                            // LEFT JOIN B: DeviceInfo
                        join b in _context.DeviceInfos
                        on new { DeviceId = a.DeviceId, PanelId = a.PanelId }
                        equals new { DeviceId = b.DeviceId, PanelId = (short?)b.PanelId } into bGroup
                        from b in bGroup.DefaultIfEmpty()

                            // LEFT JOIN C: AccessEventTypeDiction
                        join c in _context.AccessEventTypeDictions
                        on (a.EventType ?? 0).ToString() equals c.EventType into cGroup   // <-- Fixed here
                        from c in cGroup.DefaultIfEmpty()

                            // LEFT JOIN D: IOInputParams
                        join d in _context.IoinputParams
                        on new
                        {
                            DeviceId = a.DeviceId,
                            PanelId = a.PanelId,
                            IOIndex = a.IoIndex
                        }
                        equals new
                        {
                            DeviceId = d.DeviceId,
                            PanelId = (short?)d.PanelId,
                            IOIndex = (short?)d.IoIndex
                        } into dGroup
                        from d in dGroup.DefaultIfEmpty()

                        where a.EventDt >= startTime
                           && a.EventDt <= endTime
                           && (a.EventType == 31
                               //|| a.EventType == 4
                               //|| a.EventType == 16
                               //|| (a.EventType >= 902 && a.EventType <= 921)
                               )
                           && (string.IsNullOrEmpty(deviceId) || a.DeviceId == deviceId)
                           && (d == null || a.IoIndex == d.IoIndex || d.IoIndex == 0)

                        select new AccessEventRecordsAction
                        {
                            id = a.Recno,
                            device_id = a.DeviceId ?? "",
                            panel_id = a.PanelId ?? 0,
                            panel_desc = b != null ? b.PanelDesc ?? "" : "",
                            event_time = a.EventDt ?? DateTime.MinValue,
                            event_id = a.EventType ?? 0,
                            event_desc = (c != null ? c.English ?? "" : "")
                                        + " + "
                                        + (d != null ? d.IoDesc ?? "" : ""),
                            contact = ""
                        };

            // === DEBUG SQL ===
            var sql = query.ToQueryString();
            Console.WriteLine("=== EF Core Generated SQL ===");
            Console.WriteLine(sql);
            Console.WriteLine($"StartTime: {startTime}, EndTime: {endTime}");
            // =====================

            return await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

    }
}
