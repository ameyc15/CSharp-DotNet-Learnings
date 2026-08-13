using System;
using System.Collections.Generic;

namespace Day39_DbFirstApproach.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public decimal? Salary { get; set; }

    public bool? IsActive { get; set; }
}
