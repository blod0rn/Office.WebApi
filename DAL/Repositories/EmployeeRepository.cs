using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Office.Web.DAL.IRepositories;
using Office.Web.Domain.Models;

namespace Office.Web.DAL.Repositories
{
    public class EmployeeRepository : BaseSqlRepository, IEmployeeRepository
    {
        private readonly IMapper _mapper;
        public EmployeeRepository(OfficedbContext db, IMapper mapper) : base(db)
        {
            _mapper = mapper;
        }

        public async Task<EmployeeInfoDto> GetEmployeeInfo(int idEmployee)
        {
            var result = await Db.Employees
                .Include(x => x.Projects)
                    .ThenInclude(x => x.Project)
                .Where(x => x.Id == idEmployee)
                .FirstOrDefaultAsync();

            var resultModel = _mapper.Map<EmployeeInfoDto>(result);
            return resultModel;
        }
    }
}
