using Office.Web.DAL.Repositories;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Models;

namespace Office.Web.Domain.Services
{
    public class DepartamentService : IDepartamentService

    {
        private readonly IDepartamentRepository _departamentRepository;

       public DepartamentService ( IDepartamentRepository departamentRepository)
        {
            _departamentRepository = departamentRepository;
        }


        public async Task<DepartamentDto> GetInfoDepartament(int departamentId)
        {
            return await _departamentRepository.GetGeneralInfo(departamentId);
        }

        public async Task <EmployeeDto> GetDepartamentHead(int departamentId)
        {
            return await _departamentRepository.GetDepartamentHead(departamentId);
        }

        public async Task<List<DepartamentDto>> GetProjectDepartament(int departamentId)
        {
            return await _departamentRepository.GetProjectDepartament(departamentId);
        }
    }
}
