
using System.Text.Json.Serialization;

namespace Office.Web.Domain.Models
{
    public class DepartamentModel
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string NameDepartament { get; set; } = null!;

        public string InfoDepartament { get; set; } = null!;

        public string ColorDepartamemnt { get; set; } = null!;
    }
}
