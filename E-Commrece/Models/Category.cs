using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commrece.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public bool Active { get; set; }
    }
}