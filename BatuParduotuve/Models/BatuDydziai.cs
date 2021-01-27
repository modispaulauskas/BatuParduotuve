using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatuParduotuve.Models
{
    class BatuDydziai : Batai
    {
        [Key]
        public int Id { get; set; }
        public int Dydis { get; set; }
        public int kiekis { get; set; }

    }
}
