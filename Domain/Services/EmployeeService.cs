using Office.Web.DAL.IRepositories;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Models;

namespace Office.Web.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService (IEmployeeRepository employeeService)
        {
            _employeeRepository = employeeService;
        }

        public async Task<EmployeeInfoDto> GetEmployeeInfo(int idEmployee)
        {
            return await _employeeRepository.GetEmployeeInfo(idEmployee);
        }

        
    }
}
