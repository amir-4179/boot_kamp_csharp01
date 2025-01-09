using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class MyAppContext:DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-63G6AP6\\SQLSERVER2022; Database = MyDatabase; User Id = sa; Password = amir2229;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
