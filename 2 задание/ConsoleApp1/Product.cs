using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Product
    {
        private decimal basePrice;
        public string name { get; set; }
        public string ImagePath { get; set; }
        public Product (decimal basePrice, string name, string imagePath)
        {
            this.basePrice = basePrice;
            this.name = name;
            ImagePath = imagePath;
        }
        public abstract decimal GetPrice ();

    }
}
