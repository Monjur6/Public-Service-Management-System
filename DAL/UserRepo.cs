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
        //static PSEntities db;
        //static UserRepo()
        //{
        //    db = new PSEntities();
        //}
        //public static List<User> Get()
        //{
        //    return db.Users.ToList();
        //}
        //public static User Get(int id)
        //{
        //    return db.Users.FirstOrDefault(e => e.Id == id);
        //}
        //public static void Edit(User u)
        //{
        //    var du = db.Users.FirstOrDefault(e => e.Id == u.Id);
        //    db.Entry(du).CurrentValues.SetValues(u);
        //    db.SaveChanges();
        //}
        //public static void Delete(int Id)
        //{
        //    var du = db.Users.FirstOrDefault(e => e.Id == Id);
        //    db.Users.Remove(du);
        //}
        //public static void Add(User u)
        //{
        //    db.Users.Add(u);
        //    db.SaveChanges();
        //}
    }
}
