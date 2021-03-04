// HOMEWORK - 04 -  Namespaces
//Create a class file and change the namespaces to be different. Call a method within that class.

using System;
using Mathematical;

namespace Distingt
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Basic.PI);
			Console.WriteLine(Basic.GetPi());
			Console.WriteLine(Mathematical.Basic.PI);
			
		}
	}
}
