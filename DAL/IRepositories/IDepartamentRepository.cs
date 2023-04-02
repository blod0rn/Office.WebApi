using Office.Web.DAL.Entities;

namespace Office.Web.DAL.Repositories
{
    public interface IDepartamentRepository
    {
        Task<DepartamentEntity?> GetGeneralInfo(int departamentId);

        Task <EmployeeEntity?> GetDepartamentHead(int departamentId);

        Task <DepartamentEntity?> GetDepartamentInfo(int departamentId);
    }
}
