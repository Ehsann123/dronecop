
using System;
using System.Collections.Generic;

namespace DroneCop.Models;

public partial class Criminal
{
    public int CriminalId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public decimal? Height { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Cnic { get; set; }
}
