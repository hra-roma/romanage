using Romanage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanage.Data
{
    public static class ApplicationDbContext
    {
        public static List<User> Users { get; set; }
        public static List<UserEvent> UserEvents { get; set; }

        public static List<Event> Events { get; set; }
        public  static List<Payment> Payments { get; set; }
        public static List<UserRole> UserRoles { get; set; }

        static ApplicationDbContext()
        {
            Users = new List<User>();
        }

    }
}
