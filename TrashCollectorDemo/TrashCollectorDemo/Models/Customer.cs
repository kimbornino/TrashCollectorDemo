using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TrashCollectorDemo.Models;

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

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}