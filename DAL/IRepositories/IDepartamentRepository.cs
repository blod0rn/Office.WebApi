using Office.Web.Domain.Models;

namespace Office.Web.DAL.Repositories
{
    public interface IDepartamentRepository
    {
        Task<DepartamentDto> GetGeneralInfo(int departamentId);

        Task <EmployeeDto> GetDepartamentHead(int departamentId);

        Task<List<DepartamentDto>> GetProjectDepartament(int departamentId);
    }
}
