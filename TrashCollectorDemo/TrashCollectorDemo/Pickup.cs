using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollectorDemo
{
    public class Pickup
    {
        [Key]
        public int PIckupId { get; set; }

        public string Day { get; set; }

        DateTime SuspendStart { get; set; }

        DateTime SuspendEnd { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
         
       public bool Collected { get; set; }
    }
}