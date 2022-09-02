// See https://aka.ms/new-console-template for more information
using Iterator;

Console.WriteLine("Hello, World!");

var pCollection = new ProductCollection();

pCollection.Add(new Product(1, "p1"));
pCollection.Add(new Product(2, "p2"));

var iterator = pCollection.GetIterator();

while (iterator.hasNext()) 
{
    var item = iterator.GetNextProduct();

    Console.WriteLine(item.toString());

}