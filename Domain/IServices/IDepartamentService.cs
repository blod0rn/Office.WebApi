using Office.Web.Domain.Models;

namespace Office.Web.Domain.IServices
{
    public interface IDepartamentService
    {
        Task<DepartamentDto> GetInfoDepartament(int departamentId);

        Task <EmployeeDto> GetDepartamentHead(int departamentId);

        Task <DepartamentDto> GetInfo(int departamentId);
    }
}
