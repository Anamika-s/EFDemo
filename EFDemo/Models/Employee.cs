using System;
using System.Collections.Generic;

namespace EFDemo.Models;

public partial class Employee
{
    public int Id { get; set; }

    public int? EmpType { get; set; }

    public string? Name { get; set; }

    public string? ReportingManager { get; set; }

    public DateTime? ContractBasis { get; set; }

    public int? DurationInDays { get; set; }

    public int? ChargersPerDay { get; set; }

    public double? OnContractFinalSalary { get; set; }

    public DateTime? JoiningDate { get; set; }

    public int? Experience { get; set; }

    public int? BasicSalary { get; set; }

    public double? NetSalary { get; set; }

    public double? Da { get; set; }

    public double? Hra { get; set; }

    public int? Pf { get; set; }
}
