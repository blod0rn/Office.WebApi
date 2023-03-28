using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public partial class EmployeesProjectModel
{
  
    public EmployeeModel Employee { get; set; } = null!;
    public int EmployeeId { get; set; }

   
    public ProjectModel Project { get; set; } = null!;
    public int ProjectId { get; set; }

    public float ActualEmployment { get; set; }

    public float? PlannedEmployment { get; set; }
}
