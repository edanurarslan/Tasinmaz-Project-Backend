using Microsoft.EntityFrameworkCore;
using PostgreSqlExample.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlExample.Data
{
    public class PostgreSqlExampleDbContext :DbContext
    {
        public PostgreSqlExampleDbContext(DbContextOptions<PostgreSqlExampleDbContext> options) :base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgreSqlExampleDbContext).Assembly);
            modelBuilder.Entity<ilceler>().HasKey(e => e.ilceid);
            modelBuilder.Entity<iller>().HasKey(e => e.ilid);
            modelBuilder.Entity<ilceler>().HasKey(e => e.ilceid);
            modelBuilder.Entity<mahalleler>().HasKey(e => e.mahalleid);
            modelBuilder.Entity<tasinmazlar>().HasKey(e => e.Id);
            modelBuilder.Entity<ilceler>().HasKey(e => e.ilceid);
            modelBuilder.Entity<kullanicilar>().HasKey(e => e.id);
            modelBuilder.Entity<loglar>().HasKey(e => e.id);


        }
    }
}
