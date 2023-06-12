using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanage.Models
{
    public class UserEvent : Entity
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
        
        public List<string> Ticket { get; set; }

    }
}
