using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ProductCollection
    {
        private int index = 0;
        private List<Product> products { get; set; }

        public ProductCollection()
        {
            products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public IProductIterator GetIterator() 
        {
            return new ProductIterator(this);
        }

        public class ProductIterator : IProductIterator
        {
            ProductCollection productCollection;

            public ProductIterator(ProductCollection productCollection) 
            {
                this.productCollection = productCollection;
            }

            public Product GetNextProduct()
            {
                var itemToReturn = productCollection.products[productCollection.index];
                productCollection.index++;

                return itemToReturn;
            }

            public bool hasNext()
            {
                var size = productCollection.products.Count;

                if (size - 1 >= productCollection.index) 
                {
                    return true;
                }

                return false;
            }
        }
    }
}
