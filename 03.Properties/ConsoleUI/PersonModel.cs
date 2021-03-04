using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
		public string StreetAddress { get; set;  }
		public int ZipCode { get; set; }
		public string City { get; set; }
		public string State { get; set; }

		public string FullAddress
		{
			get  //read-only property
			{
				return $"My Full Address is: { StreetAddress} { ZipCode } {  City } { State }";
			}
		}
	}
}
