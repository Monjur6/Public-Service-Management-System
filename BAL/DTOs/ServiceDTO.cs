using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTOs
{
    public class ServiceDTO
    {
        //public service()
        //{
        //    this.appeals = new hashset<appeal>();
        //    this.users = new hashset<user>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }

        //public virtual ICollection<Appeal> Appeals { get; set; }
        //public virtual ICollection<User> Users { get; set; }
    }
}
