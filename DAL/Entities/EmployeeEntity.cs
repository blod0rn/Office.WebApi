using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Office.Web.DAL.Entities;

[Table("Employees")]
public class EmployeeEntity : BaseEntity
{

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;
    public string? Info { get; set; }

    public string Post { get; set; } = null!;
    
    [ForeignKey("DepartamentId")]
    public DepartamentEntity Departament { get; set; } = null!;
    public int DepartamentId { get; set; }

    public string? Skills { get; set; }

    public bool IsDepartamentHead { get; set; }

    public List<EmployeesProjectEntity> Projects { get; set; } = new List<EmployeesProjectEntity>();


}
