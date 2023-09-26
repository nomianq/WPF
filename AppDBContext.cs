using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWpfApp.Models;

namespace MyWpfApp
{
    internal class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;username=root;password=root;database=wpfapp");
        }
    }
}
