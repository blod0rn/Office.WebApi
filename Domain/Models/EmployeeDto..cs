

using Newtonsoft.Json;
using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public class EmployeeDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string Post { get; set; } = null!;

    public WorkloadModel? Workload { get; set; }

    //[JsonIgnore]
    //public int WorkloadId { get; set; }
  
    public string? Skills { get; set; }

  
    //public List<EmployeesProjectModel> EmployeesProjects { get; set; } = new List<EmployeesProjectModel>();



}
