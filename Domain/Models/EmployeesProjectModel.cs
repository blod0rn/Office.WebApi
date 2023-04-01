using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public partial class EmployeesProjectModel
{
  
    public EmployeeDto Employee { get; set; } = null!;

    [JsonIgnore]
    public int EmployeeId { get; set; }


    public float ActualEmployment { get; set; }

    public float? PlannedEmployment { get; set; }
}
