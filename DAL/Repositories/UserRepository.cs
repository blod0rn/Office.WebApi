using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Office.Web.DAL;
using Office.Web.DAL.Entities;
using Office.Web.DAL.Repositories;
using Office.Web.Domain.Models;

namespace Office.Web.DAL.Repositories
{
    public class UserRepository : BaseSqlRepository, IUserRepository
    {
        private readonly IMapper _mapper;
        public UserRepository(OfficedbContext db, IMapper mapper) : base(db)
        {
            _mapper = mapper;
        }

        public async Task<UserModel?> Create(UserModel user)
        {
            var entity = _mapper.Map<UserEntity>(user);
            var result = await Db.Users.AddAsync(entity);
            await Db.SaveChangesAsync();
            var model = _mapper.Map<UserModel>(result.Entity);
            return model;
        }

        public async Task<bool> Delete(int usertId)
        {
            var rowCount = await Db.Users.Where(x => x.Id == usertId).ExecuteDeleteAsync();
            await Db.SaveChangesAsync();
            return rowCount > 0;
        }

        public async Task<UserModel?> Get(int userId)
        {
            var result = await Db.Users.Where(x => x.Id == userId).FirstOrDefaultAsync();
            var resultModel = _mapper.Map<UserModel>(result);
            return resultModel;
        }

    }
}
