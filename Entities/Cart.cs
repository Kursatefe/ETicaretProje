using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cart
    {
       
        public string UserId { get; set; }

        private List<CartLine> products = new(); 
        public List<CartLine> Products => products; 
        public void AddProduct(Product product, int quantity)
        {
            var prd = products.Where(i => i.Product.Id == product.Id).FirstOrDefault();

            if (prd == null)
            {
                products.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity,
                });
            }
            else
            {
                prd.Quantity += quantity;
            }
        }

        public void RemoveProducts(Product product)
        {
            products.RemoveAll(i => i.Product.Id == product.Id);
        }

        public decimal TotalPrice()
        {
            return products.Sum(i => i.Product.Price * i.Quantity);
        }

        public void ClearAll()
        {
            products.Clear();
        }
    }
}
