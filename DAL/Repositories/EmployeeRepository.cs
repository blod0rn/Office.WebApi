using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Office.Web.DAL.Entities;
using Office.Web.DAL.IRepositories;


namespace Office.Web.DAL.Repositories
{
    public class EmployeeRepository : BaseSqlRepository, IEmployeeRepository
    {
        public EmployeeRepository(OfficedbContext db) : base(db)
        {
        }

        public async Task<EmployeeEntity?> GetEmployeeInfo(int idEmployee)
        {
            var result = await Db.Employees
                .Include(x => x.Projects)
                    .ThenInclude(x => x.Project)
                .Where(x => x.Id == idEmployee)
                .FirstOrDefaultAsync();
            return result;
        }
    }
}
