using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanage.Models
{
    public class Event :Entity
    {
        public string Name { get; set; }
        public string BackgroundImage { get; set; }
        public DateTime EventDate { get; set; }
        public string Address { get; set; }
        public int TicketLimit { get; set; }

        public float Price { get; set; }
        public int EventStatusId { get; set; } //10 - active,20 - canceled, 30 - finished

    }
}
