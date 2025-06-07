using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webshop.Models;

namespace webshop.Data
{
    public class WebshopContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Server=172.16.16.148; User ID=alma; Password=alma; Database=webshophn";
            base.OnConfiguring(optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection)));
        }
    }
}
