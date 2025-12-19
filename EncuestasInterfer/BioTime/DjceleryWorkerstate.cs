using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTime;

public partial class DjceleryWorkerstate
{
    public int Id { get; set; }

    public string Hostname { get; set; } = null!;

    public DateTime? LastHeartbeat { get; set; }

    public virtual ICollection<DjceleryTaskstate> DjceleryTaskstates { get; set; } = new List<DjceleryTaskstate>();
}
