using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Address
    {

		protected int door;

		public void SetDoorNumber(int n)
		{
			door = n;
		}

		public void Street()
        {
            Console.WriteLine("My street name is Malcolm X road, ");
        }

        public void ShowDoorNumber()
        {
            Console.WriteLine("and my door number is: {0} ", door);
        }

        public void ShowCity()
        {
            Console.WriteLine("In the City of Kuala Lumpur");
        }

        public void ShowCountry()
        {
            Console.WriteLine("In Malaysia.");
        }
    }
}
