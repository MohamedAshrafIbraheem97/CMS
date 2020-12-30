using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            var product = new Product(3)
            {
                

            };

            if (productId == 3)
            {
                product.ProductName = "Oranges";
                product.CurrentPrice = 5;
                product.Description = "this is oranges";
            }

            return product;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //do save
                    }
                    else
                    {
                        // do update
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
