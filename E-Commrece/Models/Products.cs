using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commrece.Models
{
    public class Products
    {
        public int Id {get; set;}
        public string ProductName{ get; set;}
        public string Description { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int ReOrderLeval { get; set; }
        public string Photo { get; set; }
        public string Note { get; set; }
        public virtual ICollection<Category> Categorys { get; set; }

    }
}