using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loaf_and_latte_system.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? PaymentId { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public Payment Payment { get; set; }
    }

}
