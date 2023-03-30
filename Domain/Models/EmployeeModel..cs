

using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public class EmployeeModel
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;
    
    public WorkloadModel? Workload { get; set; }
    public int WorkloadId { get; set; }
  
    public DepartamentModel Departament { get; set; } = null!;
    public int DepartamentId { get; set; }

    public string? Skills { get; set; }

    public bool IsDepartamentHead { get; set; }

   
}
