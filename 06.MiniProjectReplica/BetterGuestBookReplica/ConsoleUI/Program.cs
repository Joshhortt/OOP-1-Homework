// HOMEWORK - 06 -  Mini Project Replica - Putting all together
//Recreate the GuestBook project without looking back. Just take the concept and create the application.

using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Capture the information about each guest (assumtion is at least one guest and unknown maximum)
// Info to capture: First name, last name, message to the host
// Once done, loop through each guest and print their info

namespace ConsoleUI
{
	public class Program
	{
		private static List<GuestModel> guests = new List<GuestModel>();
		static void Main(string[] args)
		{
			PrintGuestInformation();

			GetGuestInformation();

			Console.ReadLine();
		}

		private static void PrintGuestInformation()
		{
			foreach (GuestModel guest in guests)
			{
				Console.WriteLine(guest.GuestInfo);
			}
		}

		private static void GetGuestInformation()
		{
			string moreGuestsArriving = "";

			do
			{
				GuestModel guest = new GuestModel();
				guest.FirstName = GetInfoFromConsole("What is your first name: ");
				guest.LastName = GetInfoFromConsole("What is your last name: ");
				guest.MessageToHost = GetInfoFromConsole("What do you want to say: ");
				moreGuestsArriving = GetInfoFromConsole("Are more guest arriving today (yes/no): ");

				guests.Add(guest);
				Console.Clear();

			} while (moreGuestsArriving.ToLower() == "yes");
		}

		private static string GetInfoFromConsole(string message)
		{
			string output = "";
			Console.WriteLine(message);
			output = Console.ReadLine();

			return output;
		}
	} 
}
