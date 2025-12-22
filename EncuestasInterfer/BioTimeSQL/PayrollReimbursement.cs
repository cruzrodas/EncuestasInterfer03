using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class PayrollReimbursement
{
    public int? Id { get; set; }

    public int? RmbAmount { get; set; }

    public string? RmbTime { get; set; }

    public string? RmbFile { get; set; }

    public string? RmbRemark { get; set; }

    public int? EmployeeId { get; set; }
}
