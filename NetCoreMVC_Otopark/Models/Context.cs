using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC_Otopark.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JC8BJ6K\\SQLEXPRESS;database=coreotopark;integrated security=true;") ;
        }

        public DbSet<Arac> aracs { get; set; }
    }
}
