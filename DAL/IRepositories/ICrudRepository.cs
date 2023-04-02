using Microsoft.EntityFrameworkCore;
using Office.Web.DAL.Entities;
using System.Security.Principal;

namespace Office.Web.DAL.IRepositories
{
    public interface ICrudRepository
    {
        Task<T> Create<T>(T newEntity) where T : class, IEntity;
        Task<T?> Get<T>(int getId) where T : class, IEntity;
        Task<bool> Update<T>(int id, T Entity) where T : class, IEntity;
        Task<bool> Delete<T>(int deletedId) where T : class, IEntity;
    }
}
