using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirstExamples.Entity
{
    public class Customer
    {
        [Key]
        public int CostomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerStyle { get; set; }
        public string City { get; set; }
    }
}
