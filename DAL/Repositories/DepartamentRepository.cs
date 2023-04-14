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

        public async Task <List<DepartamentEntity>> GetAllDepartamentInfo()
        {
            var result = await Db.Departaments
                .Include(x => x.Employees)
                    .ThenInclude(x => x.Projects)
               .ToListAsync();
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
                .Include(x => x.Employees)
                    .ThenInclude (x => x.Projects)                      
               .Where(x => x.Id == departamentId)
               .FirstOrDefaultAsync();
            return result;
        }
    }
}
