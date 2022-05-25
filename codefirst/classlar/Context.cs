using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace codefirst.classlar
{
    class Context:DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
    }
}
