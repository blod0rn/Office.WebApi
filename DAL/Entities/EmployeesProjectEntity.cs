using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Office.Web.DAL.Entities;

[PrimaryKey(nameof(EmployeeId), nameof(ProjectId))]
public  class EmployeesProjectEntity
{
    
    [JsonIgnore]
    [ForeignKey("EmployeeId")]
    public EmployeeEntity Employee { get; set; } = null!; 
    public int EmployeeId { get; set; }

    [JsonIgnore]
    [ForeignKey("ProjectId")]
    public ProjectEntity Project { get; set; } = null!;
    public int ProjectId { get; set; }  

    public float ActualEmployment { get; set; }

    public float? PlannedEmployment { get; set; }

    
}
