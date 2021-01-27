using BatuParduotuve.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatuParduotuve.Services
{
    public class Context : DbContext
    {
        public DbSet<Batas> Batai { get; set; }
        public Context() : base("Batai")
        {

        }
    }
}
