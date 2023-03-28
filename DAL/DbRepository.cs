using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Office.Web.DAL.Entities;

namespace Office.Web.DAL
{
    public class DbRepository : IDbRepository
    {
        private readonly OfficedbContext _context;

        public DbRepository (OfficedbContext context)
        {
            _context = context;
        }

        public async Task<int> Create<T>(T newEntity) where T : class, IEntity
        {
            var entity = await _context.Set<T>().AddAsync(newEntity);
            return entity.Entity.Id;
        }

        public async Task Delete<T>(T Entity) where T : class, IEntity
        {
            await Task.Run(() => _context.Set<T>().Remove(Entity));
        }

        public IQueryable<T> Get<T>() where T : class, IEntity
        {
            return _context.Set<T>().AsQueryable();
        }

        public async Task Update<T>(T Entity) where T : class, IEntity
        {
            await Task.Run(() => _context.Set<T>().Update(Entity));
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
