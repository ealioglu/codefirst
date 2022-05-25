using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst.classlar
{
    public class Urunler
    {
        [Key]
        public string _id { get; set; }
        public string isim { get; set; }
        public int adet { get; set; }
        public string Marka { get; set; }
    }
}
