using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tasinmaz.Models;

namespace tasinmaz.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Log> Loglar { get; set; }

        public DbSet<Kullanici> Kullanicilar{ get; set; }

        public DbSet<Tasinmaz> Tasinmazlar { get; set; }
    }
}