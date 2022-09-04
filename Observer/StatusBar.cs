using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StatusBar: IObserver
    {
        private List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
        }

        public void show()
        {
            foreach (var stock in stocks)
                Console.WriteLine(stock.ToString());
        }

        public void NotifyUpdate()
        {
            show();
        }
    }
}
