using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Models;

public class WorkloadModel
{
    [JsonIgnore]
    public int Id { get; set; }

    public string DegreeWorkload { get; set; } = null!;
}
