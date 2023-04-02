using System.Text.Json.Serialization;

namespace Office.Web.Domain.Models
{
    public class UserModelDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string NameUser { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

    }
}
