using Office.Web.Domain.Models;

namespace Office.Web.Domain.IServices
{
    public interface IUserService
    {
        Task<int> Create(UserModel user);
        UserModel Get(int Id);
        Task<UserModel> Update(int id, UserModel user);
       
    }
}
