using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppealRepo : IRepo<Appeal, int>
    {
        PSEntities db;
        public AppealRepo(PSEntities db)
        {
            this.db = db;
        }

        public void Add(Appeal e)
        {
            db.Appeals.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var ap = db.Appeals.FirstOrDefault(e => e.Id == id);
            db.Appeals.Remove(ap);
            db.SaveChanges();
        }

        public void Edit(Appeal e)
        {
            var ap = db.Appeals.FirstOrDefault(ak => ak.Id == e.Id);
            db.Entry(ap).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Appeal> Get()
        {
            return db.Appeals.ToList();
        }

        public Appeal Get(int id)
        {
            return db.Appeals.FirstOrDefault(e => e.Id == id);
        }
    }
}
