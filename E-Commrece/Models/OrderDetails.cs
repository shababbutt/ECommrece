using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commrece.Models
{
    public class OrderDetails
    {
        public int OrderDetaileId { get; set; }
        public int OrderId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public DateTime  ShipDate { get; set; }
        public bool Fullfilled { get; set; }
        public DateTime BillDate { get; set; }


    }
}