using System;
using System.Collections.Generic;
using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public class DepartamentDto
{ 
    public int Id { get; set; }

    public string NameDepartament { get; set; } = null!;

    public string InfoDepartament { get; set; } = null!;

    public string ColorDepartamemnt { get; set; } = null!;

    public List<ProjectDepartamentDto> Projects { get; set; } = new List<ProjectDepartamentDto>();
}
