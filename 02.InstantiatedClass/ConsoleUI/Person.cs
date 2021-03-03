using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Person
    {
        protected string fullName;

        public void SetFullName(string fN)
        {
            fullName = fN;
        }

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowFullName()
        {
            Console.WriteLine("My name is: {0} ", fullName);
        }
    }
}
