using System.Text.Json.Serialization;

namespace Office.Web.Domain.Models
{
    public class EmployeeModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = null!;
        public string? Info { get; set; }
        public string Post { get; set; } = null!;

        public int DepartamentId { get; set; }

        public string? Skills { get; set; }

        public bool IsDepartamentHead { get; set; }

    }
}
