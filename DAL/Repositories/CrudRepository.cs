using Microsoft.EntityFrameworkCore;
using Office.Web.DAL.Entities;
using Office.Web.DAL.IRepositories;

namespace Office.Web.DAL.Repositories
{
    public class CrudRepository : BaseSqlRepository, ICrudRepository
    {
        public CrudRepository(OfficedbContext db) : base(db)
        {
        }

        public async Task<T> Create<T>(T newEntity) where T : class, IEntity
        {
            var result = await Db.Set<T>().AddAsync(newEntity);
            await Db.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<T?> Get<T>(int getId) where T : class, IEntity
        {
            var entity = await Db.Set<T>().Where(x => x.Id == getId).FirstOrDefaultAsync();
            return entity;
        }

        public async Task<bool> Update<T>(int id, T Entity) where T : class, IEntity
        {
            if (await Task.Run(() => Db.Set<T>().Where(x => x.Id == id).FirstOrDefaultAsync()) is T found)
            {
                Db.Set<T>().Entry(found).State = EntityState.Detached;
                Db.Set<T>().Entry(Entity).State = EntityState.Modified;
                await Db.SaveChangesAsync();
                return true;
            }
            else return false;
        }

        public async Task<bool> Delete<T>(int deletedId) where T : class, IEntity
        {
            var rowCount = await Db.Set<T>().Where(x => x.Id == deletedId).ExecuteDeleteAsync();
            await Db.SaveChangesAsync();
            return rowCount > 0;

        }
    }
}
