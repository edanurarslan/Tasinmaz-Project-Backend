using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace tasinmaz.Models
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string kullaniciad { get; set; }

        public string kullanicisoyad { get; set; }

        public string email { get; set; }

        public string rol { get; set; }

        public string adres { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }



    }
}
