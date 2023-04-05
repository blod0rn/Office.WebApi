using Office.Web.Domain.Models;

namespace Office.Web.Domain.IServices
{
    public interface IDepartamentService
    {
        Task<DepartamentModel?> CreateDepartament(string nameDep, string infoDep, string colorDep);
        Task<DepartamentModel?> GetDepartament(int departamentId);
        Task<bool> UpdateDepartament(int id, string nameDep, string infoDep, string colorDep);
        Task<bool> DeleteDepartament(int depId);

        Task <EmployeeDto> GetDepartamentHead(int departamentId);

        Task <DepartamentDto> GetInfo(int departamentId);
        Task <List<DepartamentDto>> GetAllInfo();
    }
}
