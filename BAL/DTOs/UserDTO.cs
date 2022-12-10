using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTOs
{
    public class UserDTO
    {
        //public User()
        //{
        //    this.UserAppeals = new HashSet<UserAppeal>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public int SId { get; set; }

        public virtual ServiceDTO Service { get; set; }
        //public virtual ICollection<UserAppeal> UserAppeals { get; set; }
    }
}
