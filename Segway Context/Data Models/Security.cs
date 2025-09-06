using System;
using System.Collections.Generic;

namespace SpenSoft.EF.Segway;

public partial class Security
{
    public int RecId { get; set; }

    public string? UnitIdSerialNumber { get; set; }

    public string? UnitIdPartNumber { get; set; }

    public string? FobRadioSid { get; set; }

    public string? FobRadioWid { get; set; }

    public string? ConsoleRadioSid { get; set; }

    public string? ConsoleRadioWid { get; set; }

    public string? UserKeyCode { get; set; }

    public string? ServiceKeyCode { get; set; }

    public string? BsaJtagLock { get; set; }

    public string? CuAJtagLock { get; set; }

    public string? CuBJtagLock { get; set; }

    public string? RadioEncryptionKey { get; set; }

    public string? RadioChannelConfiguration { get; set; }

    public DateTime? DateTimeEntered { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}
