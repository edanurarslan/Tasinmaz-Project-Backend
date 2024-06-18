using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlExample.Data.Entities
{
    public abstract class BaseEntity
    {
        public int id { get; set; }
    }
}
