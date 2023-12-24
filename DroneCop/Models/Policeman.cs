using System;
using System.Collections.Generic;

namespace DroneCop.Models;

public partial class Policeman
{
    public int PoliceId { get; set; }

    public string? Rank { get; set; }

    public string? FName { get; set; }

    public string? LName { get; set; }

    public string? Gender { get; set; }

    public DateTime? JoiningDate { get; set; }

    public string? Email { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Cnic { get; set; }
}
