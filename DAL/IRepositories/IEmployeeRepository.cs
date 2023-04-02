using Office.Web.DAL.Entities;


namespace Office.Web.DAL.IRepositories
{
    public interface IEmployeeRepository
    {
        Task<EmployeeEntity?> GetEmployeeInfo(int idEmployee);

    }
}
