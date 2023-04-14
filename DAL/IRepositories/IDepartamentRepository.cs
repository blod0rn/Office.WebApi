using Office.Web.DAL.Entities;

namespace Office.Web.DAL.Repositories
{
    public interface IDepartamentRepository
    {
        Task <EmployeeEntity?> GetDepartamentHead(int departamentId);

        Task <DepartamentEntity?> GetDepartamentInfo(int departamentId);

        Task <List<DepartamentEntity>> GetAllDepartamentInfo();
    }
}
