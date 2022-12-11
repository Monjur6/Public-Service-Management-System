using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ServiceRepo : IRepo<Service, int>
    {
        PSEntities db;
        public ServiceRepo(PSEntities db)
        {
            this.db = db;
        }
        public void Add(Service e)
        {
            db.Services.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.Services.FirstOrDefault(ak => ak.Id == id);
            db.Services.Remove(e);
            db.SaveChanges();
        }

        public void Edit(Service e)
        {
            var d = db.Services.FirstOrDefault(ak => ak.Id == e.Id);
            db.Entry(d).CurrentValues.SetValues(e);
            db.SaveChanges();

        }

        public List<Service> Get()
        {
            return db.Services.ToList();
        }

        public Service Get(int id)
        {
            return db.Services.FirstOrDefault(e => e.Id == id);
        }
    }
}
