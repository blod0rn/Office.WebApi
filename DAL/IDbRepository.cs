using Microsoft.EntityFrameworkCore;
using Office.Web.DAL.Entities;
using System.Security.Principal;

namespace Office.Web.DAL
{
    public interface IDbRepository
    {
        public IQueryable<T> Get<T>() where T : class, IEntity;
        public Task<int> Create<T>(T newEntity) where T : class, IEntity;


        public Task Update<T>(T Entity) where T : class, IEntity;

        Task<int> SaveChangesAsync();

    }
}
