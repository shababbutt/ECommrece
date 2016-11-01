using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commrece.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetaileId { get; set; }
        public int OrderId { get; set; }
        [Required (ErrorMessage ="Please Enter the Unit Price")]
        public double Price { get; set; }
        [Required(ErrorMessage ="Please Enter the Quantity")]
        public int Quantity { get; set; }
        public double Total
        {
            get {
                return (int)Price * Quantity;
                }
        }
        public DateTime?  ShipDate { get; set; }
        [Required]
        public bool Fullfilled { get; set; }
        public DateTime BillDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}