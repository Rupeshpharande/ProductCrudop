using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCrudop
{
    public class ProductCrud
    {
        List<Product> products;

        public ProductCrud()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product prod)
        {
            products.Add(prod);
        }

        public void ModifyProduct(Product prod) //prod object contain new value
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == prod.Id)
                {
                    products[i].Name = prod.Name;
                    products[i].Price = prod.Price;
                    break;
                }
            }
        }
        public void DeleteProduct(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == id)
                {
                    products.Remove(products[i]);
                    break;
                }
            }
        }
        public List<Product> ProductLists()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            Product p = new Product();
            foreach (var items in products)
            {
                if (items.Id == id)
                {

                    p.Id = items.Id;
                    p.Name = items.Name;
                    p.Price = items.Price;
                    break;

                }
            }

            return p;

        }

    }
}
