using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlExample.Data.Entities
{
    public class kullanicilar
    {
        public int id { get; set; }

        public string name { get; set; }

        public string lastname { get; set; }

        public string email { get; set; }

        public string role { get; set; }

        public string adres { get; set; }

        public string salt { get; set; }

        public string hash { get; set; }

    }
}
