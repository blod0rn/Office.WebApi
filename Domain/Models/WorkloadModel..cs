using System;
using System.Collections.Generic;
using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public class WorkloadModel
{
    public int Id { get; set; }

    public string DegreeWorkload { get; set; } = null!;
}
