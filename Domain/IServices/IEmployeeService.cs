using Office.Web.Domain.Models;

namespace Office.Web.Domain.IServices
{
    public interface IEmployeeService
    {
        Task<EmployeeModel?> CreateEmployee(
            string FirstName, 
            string MiddleName, 
            string LastName,
            string Post,
            int WorkloadId,
            int DepartamentId,
            string Skills,
            bool IsDepartamentHead
            );
        Task<EmployeeModel?> GetEmployee(int employeeId);
        Task<bool> UpdateEmployee(
            int id,
            string FirstName,
            string MiddleName,
            string LastName,
            string Post,
            int WorkloadId,
            int DepartamentId,
            string Skills,
            bool IsDepartamentHead
            );
        Task<bool> DeleteEmployee(int employeeId);
        Task<EmployeeInfoDto> GetEmployeeInfo(int idEmployee);
    }
}
