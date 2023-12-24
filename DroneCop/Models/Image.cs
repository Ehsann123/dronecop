using System;
using System.Collections.Generic;

namespace DroneCop.Models;

public partial class Image
{
    public int ImgId { get; set; }

    public string? ImgExtension { get; set; }

    public string? ImgPath { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DateCreated { get; set; }
}
