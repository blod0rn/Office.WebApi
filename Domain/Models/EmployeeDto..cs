

using Newtonsoft.Json;
using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public class EmployeeDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;
    public string? Info { get; set; }

    public string Post { get; set; } = null!;

    public string? Skills { get; set; }

    public bool IsDepartamentHead { get; set; }

    public List<EmployeesProjectModel> Projects { get; set; } = new List<EmployeesProjectModel>();
}
