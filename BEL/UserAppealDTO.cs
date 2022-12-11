using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class UserAppealDTO
    {
        public int Id { get; set; }
        public int UId { get; set; }
        public int AId { get; set; }

        public virtual AppealDTO Appeal { get; set; }
        public virtual UserDTO User { get; set; }
    }
}
