using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class DjangoMigration
{
    public int? Id { get; set; }

    public string? App { get; set; }

    public string? Name { get; set; }

    public string? Applied { get; set; }
}
