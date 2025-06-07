using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webshop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public DateTime OrderDate { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }

        [NotMapped]
        public int TotalPrice => UnitPrice * Quantity;

        public Order() 
        { 
        }

        public Order(string line) { 
            var parts = line.Split(',');
            CustomerName = parts[0];
            Product = parts[1];
            OrderDate = DateTime.ParseExact(parts[2],"yyyy-MM-dd",CultureInfo.InvariantCulture);
            UnitPrice = int.Parse(parts[3]);
            Quantity = int.Parse(parts[4]);
        }

        public override string ToString() 
        {
            return $"{OrderDate} - {CustomerName} ({Product}) ";
        }
    }
}
