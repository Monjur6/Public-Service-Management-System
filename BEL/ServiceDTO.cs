using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ServiceDTO
    {
        //public ServiceDTO()
        //{
        //    this.Appeals = new HashSet<Appeal>();
        //    this.Users = new HashSet<User>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<Appeal> Appeals { get; set; }
        //public virtual ICollection<User> Users { get; set; }
    }
}
