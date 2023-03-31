using System;
using System.Collections.Generic;

namespace Office.Web.DAL.Entities;

public  class ProjectEntity : BaseEntity
{

    public string NameProject { get; set; } = null!;

    public string? InfoProject { get; set; }  

    
}
