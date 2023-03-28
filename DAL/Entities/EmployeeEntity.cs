using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Office.Web.DAL.Entities;

public class EmployeeEntity : BaseEntity
{

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string FullName { get; set; } = null!;

    [JsonIgnore]
    [ForeignKey("WorkloadId")]
    public WorkloadEntity? Workload { get; set; }
    public int WorkloadId { get; set; }
    [JsonIgnore]
    [ForeignKey("DepartamentId")]
    public DepartamentEntity Departament { get; set; } = null!;
    public int DepartamentId { get; set; }

    public string? skills { get; set; }

    public bool isDepartamentHead { get; set; }


}
