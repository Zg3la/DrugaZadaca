using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Product
    {
        public string Name { get; private set; }
        public string Price { get; private set; }
        public bool InStock { get; set; }

        public Product(string name, string price)
        {
            this.Name = name;
            this.Price = price;
            this.InStock = false;
        }

    }

}
