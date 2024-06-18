using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSqlExample.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlExample.Data.Configurations
{
    public class kullanicilarConfiguration : IEntityTypeConfiguration<kullanicilar>
    {
        public void Configure(EntityTypeBuilder<kullanicilar> builder)
        {
            builder.Property(s => s.id);
            builder.Property(s => s.name);
            builder.Property(s => s.lastname);
            builder.Property(s => s.email);
            builder.Property(s => s.role);
            builder.Property(s => s.adres);
            builder.Property(s => s.salt);
            builder.Property(s => s.hash);
        }
    }
}