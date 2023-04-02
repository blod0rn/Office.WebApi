using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Office.Web.Domain.Models;

namespace Office.Web.DAL.Repositories
{
    public class DepartamentRepository : BaseSqlRepository, IDepartamentRepository
    {
        private readonly IMapper _mapper;
        public DepartamentRepository(OfficedbContext db, IMapper mapper) : base(db)
        {
            _mapper = mapper;
        }

        public async Task<DepartamentDto> GetGeneralInfo(int departamentId)
        {
            var result = await Db.Departaments              
                .Where(x => x.Id == departamentId)
                .FirstOrDefaultAsync();
           
            var resultModel = _mapper.Map<DepartamentDto>(result);
            return resultModel;
        }

        public async Task<EmployeeDto> GetDepartamentHead(int departamentId)
        {
            var result = await Db.Employees
                .Where(e => e.DepartamentId == departamentId)
                .Where(e => e.IsDepartamentHead == true)
                .FirstOrDefaultAsync();
            
             var resultModel = _mapper.Map<EmployeeDto>(result);

          
            
            return resultModel;
        }

        public async Task<DepartamentDto> GetDepartamentInfo(int departamentId)
        {
            var result = await Db.Departaments
               .Include(x => x.Projects)
                .ThenInclude(x => x.Employees)
                    .ThenInclude (x => x.Employee)
                        .ThenInclude(x => x.Workload)
               .Where(x => x.Id == departamentId)
               .FirstOrDefaultAsync();

            var resultModel = _mapper.Map<DepartamentDto>(result);
            return resultModel;
        }
    }
}
