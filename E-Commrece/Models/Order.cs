using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commrece.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int Frieght { get; set; }
        public DateTime? RequireDate { get; set; }
        public bool Fullfiled{ get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<shipper> Shippers { get; set; }

    }
}