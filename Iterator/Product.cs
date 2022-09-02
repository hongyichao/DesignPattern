using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Product
    {
        private int id;
        private String name;

        public Product(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public String toString()
        {
            return "Product{" +
                    "id=" + id +
                    ", name='" + name + '\'' +
                    '}';
        }
    }
}
