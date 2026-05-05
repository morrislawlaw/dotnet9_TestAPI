using System;
using System.Collections.Generic;

namespace ACXBookingSystem.Entities;

public partial class VisitorCardInfo
{
    public long Id { get; set; }

    public string? BookingId { get; set; }

    public long TxNo { get; set; }

    public string? CardId { get; set; }

    public string? QrCode { get; set; }

    public string? ScambleQrCodeUid { get; set; }

    public string? ScambleQrCodeClientToken { get; set; }

    public DateTime? From { get; set; }

    public DateTime? To { get; set; }

    public DateTime? AddDt { get; set; }

    public DateTime? UpdDt { get; set; }

    public string? Name { get; set; }

    public string? Building { get; set; }

    public string? Floor { get; set; }

    public string? Unit { get; set; }
}
