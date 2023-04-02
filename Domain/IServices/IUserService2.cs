

using Office.Web.Domain.Models;

namespace Office.Web.Domain.IServices
{
    public interface IUserService2
    {
        Task<UserModel?> Create(string name, string email, string password);
        Task<UserModel?> Get(int userId);
        Task<bool> Update(int id, string name, string email, string password);
        Task<bool> Delete(int userId);
    }
}
