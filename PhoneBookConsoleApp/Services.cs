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
			throw new NotImplementedException();
		}

		internal static void ShowAll(Dictionary<string, PhoneContact> phoneBook)
		{
			throw new NotImplementedException();
		}

		internal static void Search(Dictionary<string, PhoneContact> phoneBook)
		{
			Console.Clear();
			Console.WriteLine("Search for someone in the book.");
			Console.Write("Insert his name: ");
			var name = Console.ReadLine();;
			Console.WriteLine("Checking...");
			var result = phoneBook.TryGetValue(name, out PhoneContact phoneContact);
			
			if(result)
				Console.WriteLine($"User {phoneContact.PhoneName} was found. His number {phoneContact.PhoneNumber}");
			else
				Console.WriteLine($"User {name} was NOT found.");
			
			Console.WriteLine("Press key to continue!");
			Console.ReadLine();
			Console.Clear();
		}
	}
}
