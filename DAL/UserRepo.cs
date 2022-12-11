using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo : IRepo<User, int>
    {
        PSEntities db;
        public UserRepo(PSEntities db)
        {
            this.db = db;
        }
        public void Add(User e)
        {
            db.Users.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var u = db.Users.FirstOrDefault(e=>e.Id == id);
            db.Users.Remove(u);
            db.SaveChanges();
        }

        public void Edit(User e)
        {
            var u = db.Users.FirstOrDefault(ak => ak.Id == e.Id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(e => e.Id == id);
        }
       
    }
}
