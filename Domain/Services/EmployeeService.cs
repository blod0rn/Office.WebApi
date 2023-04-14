using AutoMapper;
using Office.Web.DAL.Entities;
using Office.Web.DAL.IRepositories;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Models;
using Office.Web.Migrations;
using System.Drawing.Imaging;

namespace Office.Web.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        private readonly ICrudRepository _crudRepository;

        public EmployeeService (IEmployeeRepository employeeService, IMapper mapper, ICrudRepository crudRepository)
        {
            _employeeRepository = employeeService;
            _mapper = mapper;
            _crudRepository = crudRepository;   
        }

        public async Task<EmployeeModel?> CreateEmployee(
            string FirstName, 
            string MiddleName, 
            string LastName, 
            string Info,
            string Post,  
            int DepartamentId,
            string Skills,
            bool IsDepartamentHead
            )
        {
            var employee = new EmployeeModel()
            {
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                Info = Info,
                Post = Post,
                DepartamentId = DepartamentId,
                Skills = Skills,
                IsDepartamentHead = IsDepartamentHead
            };
            var employeeEntity = _mapper.Map<EmployeeEntity>(employee);
            var result = await _crudRepository.Create(employeeEntity);
            employee = _mapper.Map<EmployeeModel>(result);
            return employee;
        }
        public async Task<EmployeeModel?> GetEmployee(int employeeId)
        {
            var result = await _crudRepository.Get<EmployeeEntity>(employeeId);
            var employee = _mapper.Map<EmployeeModel>(result);
            return employee;
        }
        public async Task<bool> UpdateEmployee(
            int id,
            string FirstName,
            string MiddleName,
            string LastName,
            string Info,
            string Post,
            int DepartamentId,
            string Skills,
            bool IsDepartamentHead
            )
        {
            var employee = new EmployeeModel()
            {
                Id = id,
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                Info = Info,
                Post = Post,
                DepartamentId = DepartamentId,
                Skills = Skills,
                IsDepartamentHead = IsDepartamentHead
            };
            var employeeEntity = _mapper.Map<EmployeeEntity>(employee);
            var result = await _crudRepository.Update(id, employeeEntity);
            return result;
        }
        public async Task<bool> DeleteEmployee(int employeeId)
        {
            return await _crudRepository.Delete<EmployeeEntity>(employeeId);
        }
        public async Task<EmployeeInfoDto> GetEmployeeInfo(int idEmployee)
        {
            var result = await _employeeRepository.GetEmployeeInfo(idEmployee);
            var resultModel = _mapper.Map<EmployeeInfoDto>(result);
            return resultModel;
        }

        
    }
}
