﻿using System;
using System.Collections.Generic;

namespace coreDatabaseFirstApproachProject.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public string? OrderNumber { get; set; }

    public int CustomerId { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}