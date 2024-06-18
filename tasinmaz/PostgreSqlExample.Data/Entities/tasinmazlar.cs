using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSqlExample.Data.Entities
{
    public class tasinmazlar
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string il { get; set; }

        public string ilce { get; set; }

        public string mahalle { get; set; }

        public int ada { get; set; }

        public int parsel { get; set; }

        public string nitelik { get; set; }

        public int coordinateX { get; set; }

        public int coordinateY { get; set;}

        public int kullaniciid { get; set;}
    }
}
