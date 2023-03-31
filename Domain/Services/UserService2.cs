using Office.Web.Domain.IServices;
using Office.Web.Domain.Models;
using Office.Web.DAL.Repositories;

namespace Office.Web.Domain.Services
{
    public class UserService2 : IUserService2
    {
        readonly IUserRepository _userRepository;
        public UserService2(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserModel?> Create(string name, string email, string password)
        {
            var user = new UserModel() { NameUser = name, Email = email, Password = password };
            return await _userRepository.Create(user);
        }

        public async Task<bool> Delete(int userId)
        {
            return await _userRepository.Delete(userId);
        }

        public async Task<UserModel?> Get(int userId)
        {
            return await _userRepository.Get(userId);
        }
    }
}
