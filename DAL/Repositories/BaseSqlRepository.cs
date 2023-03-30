using Office.Web.DAL;

namespace Office.Web.DAL.Repositories
{
    public abstract class BaseSqlRepository
    {
        protected OfficedbContext Db;

        public BaseSqlRepository(OfficedbContext db)
        {
            Db = db;
        }
    }
}