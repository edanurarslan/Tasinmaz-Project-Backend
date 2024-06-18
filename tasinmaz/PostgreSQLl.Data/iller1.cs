using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQLl.Data
{
    public class iller1
    {
        public int id { get; set; }
        [Required]
        public string ilname { get; set; }
    }
}
