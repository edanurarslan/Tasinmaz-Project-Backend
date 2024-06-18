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
    public class mahalleConfiguration : IEntityTypeConfiguration<mahalleler>
    {
        public void Configure(EntityTypeBuilder<mahalleler> builder)
        {
            builder.Property(s => s.mahalleid);
            builder.Property(s => s.mahallename);
            builder.Property(s => s.ilceid);
            
        }
    }
}