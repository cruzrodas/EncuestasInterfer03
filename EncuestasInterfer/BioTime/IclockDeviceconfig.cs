using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class IclockDeviceconfig
{
    public string Uuid { get; set; } = null!;

    public bool EnableRegistration { get; set; }

    public bool EnableResignedFilter { get; set; }

    public bool EnableAutoAdd { get; set; }

    public bool EnableNameUpload { get; set; }

    public bool EnableCardUpload { get; set; }

    public int TransactionRetention { get; set; }

    public int CommandRetention { get; set; }

    public int DevLogRetention { get; set; }

    public int UploadLogRetention { get; set; }

    public short EditPolicy { get; set; }

    public short ImportPolicy { get; set; }

    public short MobilePolicy { get; set; }

    public short DevicePolicy { get; set; }
}
