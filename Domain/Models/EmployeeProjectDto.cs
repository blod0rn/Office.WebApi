using Newtonsoft.Json;

namespace Office.Web.Domain.Models
{
    public class EmployeeProjectDto
    {
        public string FirstName { get; set; } = null!;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = null!;

       
        public WorkloadModel? Workload { get; set; }

        [JsonIgnore]
        public int WorkloadId { get; set; }

        public string? Skills { get; set; }

    }
}
