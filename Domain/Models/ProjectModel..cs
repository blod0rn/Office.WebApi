

using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public class ProjectModel
{
    public int Id { get; set; }
    public string NameProject { get; set; } = null!;

    public string? InfoProject { get; set; }

    public List<EmployeesProjectModel> Employees { get; set; } = new List<EmployeesProjectModel>();

}
