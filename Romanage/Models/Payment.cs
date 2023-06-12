using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romanage.Models
{
    public class Payment :Entity
    {
        public int UserId { get; set; }
        public float Price { get; set; }
        public int EventId { get; set; }

        public int PaymentStatusId { get; set; } //10 - approved , 20 - denied , 30 - canceled
    }
}
