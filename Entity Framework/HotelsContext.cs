using Entity_Framework.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    class HotelsContext : DbContext
    {
        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SYTNYKPC\SQLEXPRESS;Database=HotelsDB;Trusted_Connection=True;");
        }
    }
}
