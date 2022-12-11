using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAppealRepo : IRepo<UserAppeal, int>
    {
        PSEntities db;
        public UserAppealRepo(PSEntities db)
        {
            this.db = db;
        }
        public void Add(UserAppeal e)
        {
            db.UserAppeals.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var up = db.UserAppeals.FirstOrDefault(e => e.Id == id);
            db.UserAppeals.Remove(up);
            db.SaveChanges();
        }

        public void Edit(UserAppeal e)
        {
            var up = db.UserAppeals.FirstOrDefault(ak => ak.Id == e.Id);
            db.Entry(up).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<UserAppeal> Get()
        {
            return db.UserAppeals.ToList();
        }

        public UserAppeal Get(int id)
        {
            return db.UserAppeals.FirstOrDefault(e => e.Id == id);
        }
    }
}
