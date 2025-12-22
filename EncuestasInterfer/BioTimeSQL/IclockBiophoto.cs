using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class IclockBiophoto
{
    public int? Id { get; set; }

    public string? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ChangeTime { get; set; }

    public string? ChangeUser { get; set; }

    public short? Status { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? EnrollSn { get; set; }

    public string? RegisterPhoto { get; set; }

    public string? RegisterTime { get; set; }

    public string? ApprovalPhoto { get; set; }

    public short? ApprovalState { get; set; }

    public string? ApprovalTime { get; set; }

    public string? Remark { get; set; }

    public int? EmployeeId { get; set; }
}
