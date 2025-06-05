using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzepNev.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }


        public Game(string title, string description, int price)
        {
            Title = title;
            Description = description;
            Price = price;
        }
    }
}
