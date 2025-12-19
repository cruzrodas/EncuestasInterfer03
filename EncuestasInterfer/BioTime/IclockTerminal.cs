using System;
using System.Collections.Generic;
using System.Net;

namespace EncuestasInterfer.BioTime;

public partial class IclockTerminal
{
    public int Id { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short Status { get; set; }

    public string Sn { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public IPAddress IpAddress { get; set; } = null!;

    public IPAddress? RealIp { get; set; }

    public int State { get; set; }

    public short TerminalTz { get; set; }

    public int Heartbeat { get; set; }

    public short TransferMode { get; set; }

    public int TransferInterval { get; set; }

    public string TransferTime { get; set; } = null!;

    public short? ProductType { get; set; }

    public short IsAttendance { get; set; }

    public short IsRegistration { get; set; }

    public short? Purpose { get; set; }

    public short? ControllerType { get; set; }

    public short Authentication { get; set; }

    public string? Style { get; set; }

    public string? UploadFlag { get; set; }

    public string? FwVer { get; set; }

    public string PushProtocol { get; set; } = null!;

    public string? PushVer { get; set; }

    public int? Language { get; set; }

    public bool IsTft { get; set; }

    public string? TerminalName { get; set; }

    public string? Platform { get; set; }

    public string? OemVendor { get; set; }

    public string? LogStamp { get; set; }

    public string? OpLogStamp { get; set; }

    public string? CaptureStamp { get; set; }

    public int? UserCount { get; set; }

    public int? UserCapacity { get; set; }

    public bool PhotoFuncOn { get; set; }

    public int? TransactionCount { get; set; }

    public int? TransactionCapacity { get; set; }

    public bool FpFuncOn { get; set; }

    public int? FpCount { get; set; }

    public int? FpCapacity { get; set; }

    public string? FpAlgVer { get; set; }

    public bool FaceFuncOn { get; set; }

    public int? FaceCount { get; set; }

    public int? FaceCapacity { get; set; }

    public string? FaceAlgVer { get; set; }

    public bool FvFuncOn { get; set; }

    public int? FvCount { get; set; }

    public int? FvCapacity { get; set; }

    public string? FvAlgVer { get; set; }

    public bool PalmFuncOn { get; set; }

    public int? PalmCount { get; set; }

    public int? PalmCapacity { get; set; }

    public string? PalmAlgVer { get; set; }

    public short LockFunc { get; set; }

    public DateTime? LastActivity { get; set; }

    public DateTime? UploadTime { get; set; }

    public DateTime? PushTime { get; set; }

    public short IsAccess { get; set; }

    public int? AreaId { get; set; }

    public int? CompanyId { get; set; }

    public virtual ICollection<AccAccterminal> AccAccterminals { get; set; } = new List<AccAccterminal>();

    public virtual PersonnelArea? Area { get; set; }

    public virtual PersonnelCompany? Company { get; set; }

    public virtual ICollection<EpEptransaction> EpEptransactions { get; set; } = new List<EpEptransaction>();

    public virtual ICollection<IclockErrorcommandlog> IclockErrorcommandlogs { get; set; } = new List<IclockErrorcommandlog>();

    public virtual ICollection<IclockPublicmessage> IclockPublicmessages { get; set; } = new List<IclockPublicmessage>();

    public virtual ICollection<IclockTerminalcommandlog> IclockTerminalcommandlogs { get; set; } = new List<IclockTerminalcommandlog>();

    public virtual ICollection<IclockTerminalcommand> IclockTerminalcommands { get; set; } = new List<IclockTerminalcommand>();

    public virtual ICollection<IclockTerminallog> IclockTerminallogs { get; set; } = new List<IclockTerminallog>();

    public virtual ICollection<IclockTerminalparameter> IclockTerminalparameters { get; set; } = new List<IclockTerminalparameter>();

    public virtual ICollection<IclockTerminaluploadlog> IclockTerminaluploadlogs { get; set; } = new List<IclockTerminaluploadlog>();

    public virtual ICollection<IclockTransactionproofcmd> IclockTransactionproofcmds { get; set; } = new List<IclockTransactionproofcmd>();

    public virtual ICollection<IclockTransaction> IclockTransactions { get; set; } = new List<IclockTransaction>();
}
