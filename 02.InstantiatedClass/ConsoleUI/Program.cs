// HOMEWORK - 02 -  Instantiated Classes
//Create a Console Application that has a class Person and a class Address.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
	class Program
	{
        public static void Main()
        {
            Person myPerson = new Person();
            myPerson.Greet();
            myPerson.SetFullName("Jennifer Ambrosio");
            myPerson.ShowFullName();

            Address myAddress = new Address();
            myAddress.SetDoorNumber(210);
            myAddress.Street();
            myAddress.ShowDoorNumber();
            myAddress.ShowCity();
            myAddress.ShowCountry();
        }
    }
}







