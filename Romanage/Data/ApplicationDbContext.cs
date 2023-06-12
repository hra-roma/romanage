using Romanage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanage.Data
{
    public class ApplicationDbContext
    {
        public List<User> Users { get; set; }
        public List<UserEvent> UserEvents { get; set; }

        public List<Event> Events { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
