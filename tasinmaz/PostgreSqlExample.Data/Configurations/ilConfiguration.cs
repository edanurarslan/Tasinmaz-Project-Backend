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
    public class ilConfiguration : IEntityTypeConfiguration<iller>
    {
        public void Configure(EntityTypeBuilder<iller> builder)
        {
            builder.Property(s => s.ilid);
            builder.Property(s => s.ilname);
        }
    }
}

