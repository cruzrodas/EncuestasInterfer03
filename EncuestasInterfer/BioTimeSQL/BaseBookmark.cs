using System;
using System.Collections.Generic;

namespace EncuestasInterfer.BioTimeSQL;

public partial class BaseBookmark
{
    public int? Id { get; set; }

    public string? Title { get; set; }

    public string? Filters { get; set; }

    public bool? IsShare { get; set; }

    public string? TimeSaved { get; set; }

    public int? ContentTypeId { get; set; }

    public int? UserId { get; set; }
}
