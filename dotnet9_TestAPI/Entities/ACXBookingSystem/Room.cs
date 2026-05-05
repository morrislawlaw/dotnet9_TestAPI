using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class Room
{
    public int Id { get; set; }

    public string CompanyId { get; set; } = null!;

    public string RoomId { get; set; } = null!;

    public string? AcxDoorController { get; set; }

    public string? RoomDetails { get; set; }

    public bool? EnableBooking { get; set; }

    public DateTime? AddDt { get; set; }
}
