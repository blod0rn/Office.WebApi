using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public class EmployeesProjectModel
{

    public ProjectEmployeeDto Project { get; set; } = null!;
    
    public float ActualEmployment { get; set; }

    public float? PlannedEmployment { get; set; }
}
