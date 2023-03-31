using Office.Web.Domain.Models;

namespace Office.Web.DAL.Repositories
{
    public interface IDepartamentRepository
    {
        Task<DepartamentModel> Get(int departamentId);

        Task<List<EmployeeModel>> GetEmployees(int departamentId);
    }
}
