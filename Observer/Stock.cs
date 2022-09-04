using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Stock: Subject
    {
        private String symbol;
        private float price;

        public Stock(String symbol, float price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public float GetPrice()
        {
            return price;
        }

        public void SetPrice(float price)
        {
            this.price = price;
            NotifyObservers();
        }

        public String ToString()
        {
            return "Stock{" +
                    "symbol='" + symbol + '\'' +
                    ", price=" + price +
                    '}';
        }
    }
}
