using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Office.Web.DAL.Entities;

namespace Office.Web.DAL.Repositories
{
    public class DepartamentRepository : BaseSqlRepository, IDepartamentRepository
    {
        public DepartamentRepository(OfficedbContext db) : base(db)
        {
        }

        public async Task<DepartamentEntity?> GetGeneralInfo(int departamentId)
        {
            var result = await Db.Departaments              
                .Where(x => x.Id == departamentId)
                .FirstOrDefaultAsync();
            return result;
        }

        public async Task<EmployeeEntity?> GetDepartamentHead(int departamentId)
        {
            var result = await Db.Employees
                .Where(e => e.DepartamentId == departamentId)
                .Where(e => e.IsDepartamentHead == true)
                .FirstOrDefaultAsync();   
            return result;
        }

        public async Task<DepartamentEntity?> GetDepartamentInfo(int departamentId)
        {
            var result = await Db.Departaments
               .Include(x => x.Projects)
                .ThenInclude(x => x.Employees)
                    .ThenInclude (x => x.Employee)
                        .ThenInclude(x => x.Workload)
               .Where(x => x.Id == departamentId)
               .FirstOrDefaultAsync();
            return result;
        }
    }
}
