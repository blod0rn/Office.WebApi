﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Web.DAL.Entities;


[Table("Departaments")]
public class DepartamentEntity : BaseEntity
{

    public string NameDepartament { get; set; } = null!;

    public string InfoDepartament { get; set; } = null!;
    
    
    public List<EmployeeEntity> Employees { get; set; } = new List<EmployeeEntity>();

    public List<ProjectEntity> Projects { get; set; } = new List<ProjectEntity>();


}
