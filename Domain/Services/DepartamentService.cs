using AutoMapper;
using Office.Web.DAL.Entities;
using Office.Web.DAL.IRepositories;
using Office.Web.DAL.Repositories;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Models;
using System.Xml.Linq;

namespace Office.Web.Domain.Services
{
    public class DepartamentService : IDepartamentService

    {
        private readonly IDepartamentRepository _departamentRepository;
        private readonly ICrudRepository _crudRepository;
        private readonly IMapper _mapper;

       public DepartamentService ( IDepartamentRepository departamentRepository, IMapper mapper, ICrudRepository crudRepository)
        {
            _departamentRepository = departamentRepository;
            _mapper = mapper;
            _crudRepository = crudRepository;
        }
        public async Task<DepartamentModel?> CreateDepartament(string nameDep, string infoDep, string colorDep)
        {
            var dep = new DepartamentModel()
            {
                NameDepartament = nameDep,
                InfoDepartament = infoDep,
                ColorDepartamemnt = colorDep

            };
            var depEntity = _mapper.Map<DepartamentEntity>(dep);
            var result = await _crudRepository.Create(depEntity);
            dep = _mapper.Map<DepartamentModel>(result);
            return dep;
        }

      

        public async Task<DepartamentModel?> GetDepartament(int departamentId)
        {
            var result = await _crudRepository.Get<DepartamentEntity>(departamentId);
            var dep = _mapper.Map<DepartamentModel>(result);
            return dep;
        }
        public async Task<bool> UpdateDepartament(int id, string nameDep, string infoDep, string colorDep)
        {
            var dep= new DepartamentModel() 
            {
                Id = id, 
                NameDepartament = nameDep, 
                InfoDepartament = infoDep, 
                ColorDepartamemnt = colorDep 
            };
            var depEntity = _mapper.Map<DepartamentEntity>(dep);
            var result = await _crudRepository.Update(id, depEntity);
            return result;
        }
        public async Task<bool> DeleteDepartament(int depId)
        {
            return await _crudRepository.Delete<DepartamentEntity>(depId);
        }

        public async Task <EmployeeDto> GetDepartamentHead(int departamentId)
        {
            var result = await _departamentRepository.GetDepartamentHead(departamentId);
            var resultModel = _mapper.Map<EmployeeDto>(result);
            return resultModel;
        }

        public async Task<DepartamentDto> GetInfo(int departamentId)
        {
            var result = await _departamentRepository.GetDepartamentInfo(departamentId);
            var resultModel = _mapper.Map<DepartamentDto>(result);
            return resultModel;
        }

        public async Task <List<DepartamentDto>> GetAllInfo()
        {
            var result = await _departamentRepository.GetAllDepartamentInfo();
            var resultModel = _mapper.Map<List<DepartamentDto>>(result);
            return resultModel;
        }
    }
}
