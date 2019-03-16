using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollectorDemo
{
    public class Customer
    {
        [Key]
        public int CustomeerId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string CustomerZip { get; set; }

        public double MonthlyBill { get; set; }

    }
}