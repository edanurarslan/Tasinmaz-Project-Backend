using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostgreSqlExample.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlExample.Data.Configurations
{
    public class logConfiguration
    {
        public void Configure(EntityTypeBuilder<loglar> builder)
        {
            builder.Property(s => s.id);

        }
    }
}
