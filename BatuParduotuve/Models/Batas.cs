using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatuParduotuve.Models
{
    public class Batas
    {
        [Key]
        public int Id { get; set; }
        public string BatuPavadinimas { get; set; }
        public string BatuRusis { get; set; }
        public decimal Kaina { get; set; }
        public List<BatuDydis> BatuDydis { get; set; }

        public void PirktiBatus(string butuRusis, int dydis, int poruKiekis)
        {

        }


    }
}
