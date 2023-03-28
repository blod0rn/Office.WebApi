using Office.Web.Domain.IServices;
using Office.Web.Domain.Models;
using Office.Web.DAL;
using AutoMapper;
using Office.Web.DAL.Entities;

namespace Office.Web.Domain.Services
{
    public class UserService : IUserService
    {
        
        private readonly IDbRepository _dbRepository;
        private readonly IMapper _mapper;
        public UserService( IDbRepository dbRepository, IMapper mapper) 
        {             
            _dbRepository = dbRepository;
            _mapper = mapper;
        }
        public async Task<int> Create(UserModel user)
        {
            var entity = _mapper.Map<UserEntity>(user);
            var result = await _dbRepository.Create(entity);

            await _dbRepository.SaveChangesAsync();

            return result;
        }

        //public async Task Delete(int id)
        //{
        //    var entity = _dbRepository.Get<UserEntity>().FirstOrDefault(x => x.Id == id);
        //    if (entity != null)
        //    {
        //        await _dbRepository.Delete<UserEntity>(entity);
        //        await _dbRepository.SaveChangesAsync();
        //    }
         
        //}

        public  UserModel Get(int id)
        {
            var entity = _dbRepository.Get<UserEntity>().FirstOrDefault(x => x.Id == id);
            var model = _mapper.Map<UserModel>(entity);

            return model;
        }
               

        public async Task<UserModel> Update(int id,UserModel user)
        {
             var oldEntity = _dbRepository.Get<UserEntity>().FirstOrDefault(x => x.Id == id);
            var newEntity = _mapper.Map<UserEntity>(user);
            if (oldEntity != null)
            {
                
                await _dbRepository.Update<UserEntity>(newEntity);
                await _dbRepository.SaveChangesAsync();
            }

            var model = _mapper.Map<UserModel>(newEntity);

            return model;
        }
    }
}
