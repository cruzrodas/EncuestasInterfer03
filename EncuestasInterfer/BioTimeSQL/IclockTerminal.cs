using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class IclockTerminal
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? Sn { get; set; }

    public string? Alias { get; set; }

    public string? IpAddress { get; set; }

    public string? RealIp { get; set; }

    public int? State { get; set; }

    public short? TerminalTz { get; set; }

    public int? Heartbeat { get; set; }

    public short? TransferMode { get; set; }

    public int? TransferInterval { get; set; }

    public string? TransferTime { get; set; }

    public short? ProductType { get; set; }

    public short? IsAttendance { get; set; }

    public short? IsRegistration { get; set; }

    public short? Purpose { get; set; }

    public short? ControllerType { get; set; }

    public short? Authentication { get; set; }

    public string? Style { get; set; }

    public string? UploadFlag { get; set; }

    public string? FwVer { get; set; }

    public string? PushProtocol { get; set; }

    public string? PushVer { get; set; }

    public int? Language { get; set; }

    public bool? IsTft { get; set; }

    public string? TerminalName { get; set; }

    public string? Platform { get; set; }

    public string? OemVendor { get; set; }

    public string? LogStamp { get; set; }

    public string? OpLogStamp { get; set; }

    public string? CaptureStamp { get; set; }

    public int? UserCount { get; set; }

    public int? UserCapacity { get; set; }

    public bool? PhotoFuncOn { get; set; }

    public int? TransactionCount { get; set; }

    public int? TransactionCapacity { get; set; }

    public bool? FpFuncOn { get; set; }

    public int? FpCount { get; set; }

    public int? FpCapacity { get; set; }

    public string? FpAlgVer { get; set; }

    public bool? FaceFuncOn { get; set; }

    public int? FaceCount { get; set; }

    public int? FaceCapacity { get; set; }

    public string? FaceAlgVer { get; set; }

    public bool? FvFuncOn { get; set; }

    public int? FvCount { get; set; }

    public int? FvCapacity { get; set; }

    public string? FvAlgVer { get; set; }

    public bool? PalmFuncOn { get; set; }

    public int? PalmCount { get; set; }

    public int? PalmCapacity { get; set; }

    public string? PalmAlgVer { get; set; }

    public short? LockFunc { get; set; }

    public string? LastActivity { get; set; }

    public string? UploadTime { get; set; }

    public string? PushTime { get; set; }

    public short? IsAccess { get; set; }

    public int? AreaId { get; set; }

    public int? CompanyId { get; set; }
}
