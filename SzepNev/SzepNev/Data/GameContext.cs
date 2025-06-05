using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzepNev.Models;

namespace SzepNev.Data
{
    public class GameContext:DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=172.16.16.148; User ID=alma; Password=alma; Database=GamesDB";
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
        }
    }
}
