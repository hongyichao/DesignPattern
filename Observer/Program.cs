/*
 * Observer pattern is used when there is a  single data source and multiple objects need to act 
 * when the data changed
 */

using Observer;

List<IObserver> observers = new List<IObserver>();

var statusBar = new StatusBar();
var listView= new StockListView();

observers.Add(statusBar);
observers.Add(listView);
    
var stock1 = new Stock("stock1", 124.5f);
foreach (var o in observers) 
{
    stock1.AddObserver(o);
    o.AddStock(stock1);
}


var stock2 = new Stock("stock2", 224.5f);
foreach (var o in observers)
{
    stock2.AddObserver(o);
    o.AddStock(stock2);
}


stock1.SetPrice(123.99f);

stock2.SetPrice(201.5f);





