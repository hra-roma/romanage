using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanage.Models
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public string Password { get; set; }

        public string Photo { get; set; }

        public int UserRoleId { get; set; }

        public int UserStatusId { get; set; } // 10 - active , 20 - deactive
    }
}
