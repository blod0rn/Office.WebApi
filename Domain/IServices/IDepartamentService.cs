using Office.Web.Domain.Models;

namespace Office.Web.Domain.IServices
{
    public interface IDepartamentService
    {
        Task<DepartamentModel> GetDepartament(int departamentId);

        Task<List<EmployeeModel>> GetEmployees(int departamentId);
    }
}
