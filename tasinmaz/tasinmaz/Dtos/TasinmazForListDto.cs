using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tasinmaz.Models;

namespace tasinmaz.Dtos
{
    public class TasinmazForListDto
    {
        public int Id { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string mahalle { get; set; }

        public int ada { get; set; }

        public int parsel { get; set; }

        public string nitelik { get; set; }

        public string adres { get; set; }


    }
}
