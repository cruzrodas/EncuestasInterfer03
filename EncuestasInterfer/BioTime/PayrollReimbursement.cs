using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class PayrollReimbursement
{
    public int Id { get; set; }

    public int RmbAmount { get; set; }

    public DateTime RmbTime { get; set; }

    public string? RmbFile { get; set; }

    public string? RmbRemark { get; set; }

    public int? EmployeeId { get; set; }

    public virtual PersonnelEmployee? Employee { get; set; }
}
