using Office.Web.Domain.Models;

namespace Office.Web.DAL.Repositories;

public interface IUserRepository
{
    Task<UserModel?> Create(UserModel user);
    Task<bool> Delete(int usertId);
    Task<UserModel?> Get(int userId);
}
