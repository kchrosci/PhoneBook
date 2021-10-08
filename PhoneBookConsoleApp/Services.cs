using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp
{
	public static class Services
	{
		internal static void AddContact(Dictionary<string, PhoneContact> phoneBook)
		{
			Console.Clear();
			Console.WriteLine("For adding a new contact please use input:");
			Console.Write("Name: ");
			var name = Console.ReadLine();
			Console.Write("Number: ");
			var number = Console.ReadLine();
			Console.WriteLine("Adding...");
			PhoneContact phoneContact = new PhoneContact(name, number);
			phoneBook.Add(number, phoneContact);
			Console.WriteLine("Added Successfully! Press key to continue!");
			Console.ReadLine();
			Console.Clear();
		}

		internal static void ShowByNr(Dictionary<string, PhoneContact> phoneBook)
		{
			Console.Clear();
			Console.WriteLine("Show a contact by phone number.");
			Console.Write("Insert number: ");
			var number = Console.ReadLine(); ;
			Console.WriteLine("Checking...");

			var searchResult = phoneBook.TryGetValue(number, out PhoneContact phoneContact);

			if(searchResult)
					Console.WriteLine($"Number {phoneContact.PhoneNumber} was found. It is assigned to {phoneContact.PhoneName}");
			else
				Console.WriteLine($"Number {number} was NOT found in Contact book.");
			Console.WriteLine("Press key to continue!");
			Console.ReadLine();
			Console.Clear();
		}

		internal static void ShowAll(Dictionary<string, PhoneContact> phoneBook)
		{
			Console.Clear();
			Console.WriteLine("Displaying whole Contact book...");

			foreach(var user in phoneBook)
			{
				Console.WriteLine($"Name: {user.Value.PhoneName}, Number: {user.Key}");
			}

			Console.WriteLine("Press key to continue!");
			Console.ReadLine();
			Console.Clear();
		}

		internal static void Search(Dictionary<string, PhoneContact> phoneBook)
		{
			Console.Clear();
			Console.WriteLine("Search for someone in the book.");
			Console.Write("Insert his name: ");
			var name = Console.ReadLine();;
			Console.WriteLine("Checking...");
			
			var searchResult = phoneBook.Where(p => p.Value.PhoneName == name);
			Console.WriteLine($"Found {searchResult.Count()}");
			
			if(searchResult.Any())
				foreach(var user in searchResult)
				{
					Console.WriteLine($"User {user.Value.PhoneName} was found. His number {user.Value.PhoneNumber}");
				}			
			else
				Console.WriteLine($"User {name} was NOT found.");
			
			Console.WriteLine("Press key to continue!");
			Console.ReadLine();
			Console.Clear();
		}
	}
}
