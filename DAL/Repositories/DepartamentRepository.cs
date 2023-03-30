using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Office.Web.Domain.Models;
using System.Runtime.CompilerServices;

namespace Office.Web.DAL.Repositories
{
    public class DepartamentRepository : BaseSqlRepository, IDepartamentRepository
    {
        private readonly IMapper _mapper;
        public DepartamentRepository(OfficedbContext db, IMapper mapper) : base(db)
        {
            _mapper = mapper;
        }

        public async Task<DepartamentModel> Get(int departamentId)
        {
            var result = await Db.Departaments.Where(x => x.Id == departamentId).FirstOrDefaultAsync();
            var resultModel = _mapper.Map<DepartamentModel>(result);
            return resultModel;
        }

        public async Task<List<EmployeeModel>> GetEmployees(int departamentId)
        {
            var result = await Db.Employees.Include(u => u.Workload).Include(x => x.Departament).Where(e => e.DepartamentId == departamentId).ToListAsync();
            
             var resultModel = _mapper.Map<List<EmployeeModel>>(result);

          
            
            return resultModel;
        }

       


    }
}
