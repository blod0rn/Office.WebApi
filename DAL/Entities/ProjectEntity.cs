using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Office.Web.DAL.Entities;

public  class ProjectEntity : BaseEntity
{

    public string NameProject { get; set; } = null!;

    public string? InfoProject { get; set; }

   public List<EmployeesProjectEntity> Employees { get; set; } = new List<EmployeesProjectEntity>();




}
