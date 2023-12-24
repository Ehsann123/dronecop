using System;
using System.Collections.Generic;

namespace DroneCop.Models;

public partial class User
{
    public int UserId { get; set; }

    public int? DesignationId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? Cnic { get; set; }
}
