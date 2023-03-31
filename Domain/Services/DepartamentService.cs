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


        public async Task<DepartamentModel> GetDepartament(int departamentId)
        {
            return await _departamentRepository.Get(departamentId);
        }

        public async Task<List<EmployeeModel>> GetEmployees(int departamentId)
        {
            return await _departamentRepository.GetEmployees(departamentId);
        }
    }
}
