// HOMEWORK - 05 -  Class Libraries
//Create a Console Application that has a class library that holds Person class. Add more classes if needed.

using DemoLibrary;
using DemoLibrary.Models;
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
			List<PersonModel> people = new List<PersonModel>();

			string firstName;
			do
			{
				Console.Write("What is your first name (or type exit to stop): ");
				firstName = Console.ReadLine();

				Console.Write("What is your last name: ");
				string lastName = Console.ReadLine();

				if (firstName.ToLower() != "exit")
				{
					PersonModel person = new PersonModel();
					person.FirstName = firstName;
					person.LastName = lastName;
					people.Add(person);
				}
			} while (firstName.ToLower() != "exit");

			foreach (PersonModel p in people)
			{
				ProcessPerson.GreetPerson(p);
			}
			Console.ReadLine();
        }
    }
}
