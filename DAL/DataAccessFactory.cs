using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static PSEntities db;
        static DataAccessFactory()
        {
            db = new PSEntities();
        }
        public static IRepo<User, int> UserDataAccess()
        {
            return new UserRepo(db);
        }
        public static IRepo<Service, int> ServiceDataAccess()
        {
            return new ServiceRepo(db);
        }
        public static IRepo<Appeal, int> AppealDataAccess()
        {
            return new AppealRepo(db);
        }
        public static IRepo<UserAppeal, int> UserAppealDataAccess()
        {
            return new UserAppealRepo(db);
        }
    }
}
