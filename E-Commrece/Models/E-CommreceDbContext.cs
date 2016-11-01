using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace E_Commrece.Models
{
    public class E_CommreceDbContext:DbContext
    {
        public E_CommreceDbContext() : base("E_CommreceDbContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Category>Categorys  { get; set; }
        public DbSet<Order>Orders  { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<shipper>Shippers  { get; set; }
        public DbSet<Customer> Customers { get; set; }
       
    }
}