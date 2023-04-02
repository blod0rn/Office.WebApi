using Office.Web.Domain.Models;

namespace Office.Web.DAL.IRepositories
{
    public interface IEmployeeRepository
    {
        Task<EmployeeInfoDto> GetEmployeeInfo(int idEmployee);

    }
}
