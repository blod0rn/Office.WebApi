using Office.Web.Domain.Models;

namespace Office.Web.Domain.IServices
{
    public interface IEmployeeService
    {
        Task<EmployeeInfoDto> GetEmployeeInfo(int idEmployee);
    }
}
