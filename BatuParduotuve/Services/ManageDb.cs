using BatuParduotuve.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatuParduotuve.Services
{
    public class ManageDb
    {
        public static void AddBatai(string batuPavadinimas, string batuRusis, decimal kaina, List<BatuDydis> batuDydis)
        {
            using(var context = new Context())
            {
                var batas = new Batas
                {
                    BatuPavadinimas = batuPavadinimas,
                    BatuRusis = batuRusis,
                    Kaina = kaina,
                    BatuDydis = batuDydis
                };
                context.Batai.Add(batas);
                context.SaveChanges();
                
            }
        }
    }
}
