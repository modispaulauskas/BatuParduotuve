using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatuParduotuve.Models
{
    public class Pardavimas
    {
        [Key]
        public int Id { get; set; }
        public string KokieBatai { get; set; }
        public int KiekPoru { get; set; }
        public double PiniguIsleista { get; set; }

    }
}
