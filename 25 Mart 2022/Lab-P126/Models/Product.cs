using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_P126.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public double NewPrice { get; set; }
        public double OldPrice { get; set; }
        public bool IsDelete { get; set; }
    }
}
