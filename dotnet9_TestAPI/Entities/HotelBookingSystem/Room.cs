using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Entities;

public partial class Room
{
    public int RoomId { get; set; }

    public int HotelId { get; set; }

    public string RoomNumber { get; set; } = null!;

    public int RoomTypeId { get; set; }

    public short? Floor { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<BookingRoom> BookingRooms { get; set; } = new List<BookingRoom>();

    public virtual Hotel Hotel { get; set; } = null!;

    public virtual RoomType RoomType { get; set; } = null!;
}
