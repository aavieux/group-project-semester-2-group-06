using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Company
    {
        public List<Product> products { get; private set; }
        public Company()
        {
            products = new List<Product>();
        }
        public Product? findProductById(int id)
        {
            foreach(Product product in products)
            {
                if(product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
