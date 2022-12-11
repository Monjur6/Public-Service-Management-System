using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class AppealDTO
    {
        //public Appeal()
        //{
        //    this.UserAppeals = new HashSet<UserAppeal>();
        //}

        public int Id { get; set; }
        public string AppliedFor { get; set; }
        public int Sid { get; set; }

        public virtual ServiceDTO Service { get; set; }
        //public virtual ICollection<UserAppeal> UserAppeals { get; set; }
    }
}
