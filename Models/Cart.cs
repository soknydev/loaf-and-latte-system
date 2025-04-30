using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loaf_and_latte_system.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedDate { get; set; }
        public bool IsPaid { get; set; }

        public Employee Employee { get; set; }
        public Product Product { get; set; }
    }

}
