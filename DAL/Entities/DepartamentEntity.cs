using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Web.DAL.Entities;

public class DepartamentEntity : BaseEntity
{

    public string NameDepartament { get; set; } = null!;

    public string InfoDepartament { get; set; } = null!;
    
    public List<EmployeeEntity> Employees { get; set; } = new List<EmployeeEntity>();


}
