using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commrece.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string BillingAddress { get; set; }
        public int BillingPhone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ShippingAddress { get; set; }
        public int ShippingPhone { get; set; }
        public bool DataEnterd { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }

    }
}