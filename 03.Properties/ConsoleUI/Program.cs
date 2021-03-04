// HOMEWORK - 03 -  Properties
// Create a Console Application with a class that has properties (street address, zipcode, city, state),
// then add a full property that is read-only.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();  
            person.StreetAddress = "Rua D 14 -";
            person.ZipCode = 1900;
            person.City = "- Lisbon";
            person.State = "- Estremadura";

            Console.WriteLine(person.FullAddress);
            
            Console.ReadLine();
        }
    }
}
