// HOMEWORK 2 - 02 -  Instantiated Classes
//Create a Console Application that has two different classes in separated files.
//This homework is about a number of features regarding classes and objects in the C# language. 
//We saw how to define a class, as well as how to define a constructor in that class. 
//The constructor of a class was optional and it can be used to set up initial values or perform 
//some basic tasks right when an object is first created.
//We use the new keyword in combination with the name of a class to create a new object from that class. 
//There can be more than one instance of any given class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    public class Program
    {
        static void Main(string[] args)
        {
            StockPortfolio portfolio = new StockPortfolio();

            portfolio.AddStock(1000);
            portfolio.AddStock(25000);
            portfolio.AddStock(8500);
            portfolio.AddStock(2900);
            portfolio.AddStock(7000);
            portfolio.AddStock(11700);
            portfolio.AddStock(9000);

            StockStatistics stats = portfolio.ComputeStatistics();

            Console.WriteLine("The average price is " + stats.AverageStock);
            Console.WriteLine("The highest price is " + stats.HighestStock);
            Console.WriteLine("The lowest price is " + stats.LowestStock);
        }
    }
}
