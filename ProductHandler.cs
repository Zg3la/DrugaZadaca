using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class ProductHandler
    {
        List<Product> Products;

        public ProductHandler(List<Product> inventory)
        {
            Products = inventory;
        }

        public void Renew(Product renewedProduct)
        {
            foreach (Product product in Products)
            {
                if (product == renewedProduct)
                    product.InStock = true;
            }
        }
        public void RemoveUnavailable()
        {
            Products.RemoveAll(product => product.InStock == false);
        }

    }
}
