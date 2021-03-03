//01 - HOMEWORK - Static Classes
// Create a Console Application with static class that handles calculations
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        public static void Main()
        {
            var result = Calculator.Sum(10, 25); // calling static method
            var result2 = Calculator.Mult(10, 5); // calling static method

            Calculator.Store(result);
            Calculator.Calc(result2);

            Console.WriteLine(result);  // prints out result Store
            Console.WriteLine(result2);  // prints out result2 Calc

            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific"; // assign value to static variable
        }
    }

    public static class Calculator
    {
        private static int _resultStorage = 0;


        public static string Type = "Arithmetic";

        public static int Sum(int numSum1, int numSum2)
        {
            return numSum1 + numSum2;
        }
        public static int Mult(int numMult1, int numMult2)
        {
            return numMult1 * numMult2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }

        public static void Calc(int result2)
        {
            _resultStorage = result2;
        }
    }
}
