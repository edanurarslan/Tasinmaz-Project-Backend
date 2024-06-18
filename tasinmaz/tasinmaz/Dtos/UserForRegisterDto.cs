using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tasinmaz.Dtos
{
    public class UserForRegisterDto
    {
        public string kullaniciad { get; set; }

        public string kullanicisoyad { get; set; }

        public string email { get; set; }

        public string rol { get; set; }

        public string adres { get; set; }
        public string Password { get; set; }

        //adres eklenecek adres bilgisi
    }
}
