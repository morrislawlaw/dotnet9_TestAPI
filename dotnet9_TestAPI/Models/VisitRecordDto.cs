namespace Anderson_Road.Models
{
    public class VisitRecordCreateDto
    {
        public string? ResidentCardId { get; set; }

        public List<DoorGroupDto> DoorGroup { get; set; } = new();

        public DateTime? BookingCommence { get; set; }
        public DateTime? BookingExpiry { get; set; }

        // You can add more fields later as needed
    }

    public class VisitRecordEditDto
    {
        public required string Booking_id { get; set; }
        public string? ResidentCardId { get; set; }

        public List<DoorGroupDto> DoorGroup { get; set; } = new();

        public DateTime? BookingCommence { get; set; }
        public DateTime? BookingExpiry { get; set; }

        // You can add more fields later as needed
    }

    public class VisitRecordDeleteDto
    {
        public required string Booking_id { get; set; }
    }

    public class DoorGroupDto
    {
        public string GroupId { get; set; } = string.Empty;
    }

    public class AccessEventLogDto
    {
        public int page { get; set; }

        public int pageSize { get; set; }

        public string? DeviceId { get; set; }

        // You can add more fields later as needed
    }
    public class AccessEventRecordsAction
    {
        public int id { get; set; }
        public string? device_id { get; set; }
        public int? panel_id { get; set; }
        public string? panel_desc { get; set; }
        public DateTime? event_time { get; set; }
        public int? event_id { get; set; }
        public string? event_desc { get; set; }
        public string? contact { get; set; }
    }

    //Response Area
    public class ResponseVisitorRecordCount
    {
        public int count { get; set; }
    }
    public class ResponseVisitorRecordCreate
    {
        public string? Booking_id { get; set; }
    }
    public class ResponseVisitorRecordBulkCreate
    {
        public int? Inserted_Success_Count { get; set; }
    }
    public class ResponseVisitorRecordBulkUpdate
    {
        public int? Updated_Success_Count { get; set; }
    }
    public class ResponseDummy
    {
        public string? result { get; set; }
    }
}