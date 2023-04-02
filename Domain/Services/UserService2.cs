using Office.Web.Domain.IServices;
using Office.Web.Domain.Models;
using Office.Web.DAL.Repositories;
using Office.Web.DAL.Entities;
using AutoMapper;
using Office.Web.DAL.IRepositories;

namespace Office.Web.Domain.Services
{
    public class UserService2 : IUserService2
    {
        readonly ICrudRepository _crudRepository;
        private readonly IMapper _mapper;
        public UserService2 (ICrudRepository crudRepository, IMapper mapper)
        {
            _crudRepository = crudRepository;
            _mapper = mapper;
        }

        public async Task<UserModel?> Create(string name, string email, string password)
        {
            var user = new UserModel() { NameUser = name, Email = email, Password = password };
            var userEntity = _mapper.Map<UserEntity>(user);
            var result = await _crudRepository.Create(userEntity);
            user = _mapper.Map<UserModel>(result);
            return user;
        }

        public async Task<UserModel?> Get(int userId)
        {
            var result = await _crudRepository.Get<UserEntity>(userId);
            var user = _mapper.Map<UserModel>(result);
            return user;
        }
        public async Task<bool> Update(int id, string name, string email, string password)
        {
            var user = new UserModel() { Id = id, NameUser = name, Email = email, Password = password };
            var userEntity = _mapper.Map<UserEntity>(user);
            var result = await _crudRepository.Update(id,userEntity);
            return result;
        }
            public async Task<bool> Delete(int userId)
        {
            return await _crudRepository.Delete<UserEntity>(userId);
        }

        
    }
}
