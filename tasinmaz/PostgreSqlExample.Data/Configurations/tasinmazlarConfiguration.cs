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
    public class tasinmazlarConfiguration : IEntityTypeConfiguration<tasinmazlar>
    {
        public void Configure(EntityTypeBuilder<tasinmazlar> builder)
        {
            builder.Property(s => s.Id);
            builder.Property(s => s.il);
            builder.Property(s => s.ilce);
            builder.Property(s => s.mahalle);
            builder.Property(s => s.ada);
            builder.Property(s => s.parsel);
            builder.Property(s => s.nitelik);
            builder.Property(s => s.coordinateX);
            builder.Property(s => s.coordinateY);
            builder.Property(s => s.kullaniciid);

        }
    }
}