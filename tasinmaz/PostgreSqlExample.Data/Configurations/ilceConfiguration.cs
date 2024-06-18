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
    public class ilceConfiguration : IEntityTypeConfiguration<ilceler>
    {
        public void Configure(EntityTypeBuilder<ilceler> builder)
        {
            builder.Property(s => s.ilceid);
            builder.Property(s => s.ilcename);
            builder.Property(s => s.ilid);
        }
    }
}

