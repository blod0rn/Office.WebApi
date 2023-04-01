using Newtonsoft.Json;

namespace Office.Web.Domain.Models
{
    public class EmployeeProjectDto
    {
        public EmployeeDto Employee { get; set; } = null!;

        //[JsonIgnore]
        //public int EmployeeId { get; set; }


       

    }
}
