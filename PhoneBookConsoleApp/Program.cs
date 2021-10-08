using System;
using System.Collections.Generic;

namespace PhoneBookConsoleApp
{ 
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to PhoneBook program!");
			Dictionary<string, PhoneContact> phoneBook = ContactsSeeder();
			Information();
			int decision = int.Parse(Console.ReadLine());	
			while (decision != 0)
			{
				if(decision == (int)ChoiceEnum.Add)
				{
					Services.AddContact(phoneBook);
				}
				else if(decision == (int)ChoiceEnum.ShowByNr)
				{
					Services.ShowByNr(phoneBook);
				}
				else if(decision == (int)ChoiceEnum.ShowAll)
				{
					Services.ShowAll(phoneBook);
				}
				else if (decision == (int)ChoiceEnum.Search)
				{
					Services.Search(phoneBook);
				}			
				Information();
				var result = int.TryParse(Console.ReadLine(),out decision);
				if(!result)
				{
					Console.WriteLine("Bad input format.");
				}	
			}
		}

		private static Dictionary<string, PhoneContact> ContactsSeeder()
		{
			return new Dictionary<string, PhoneContact>()
			{
				{"965832147", new PhoneContact("Jan","965832147")},
				{"895832147", new PhoneContact("Kamil","895832147")},
				{"365822147", new PhoneContact("Andrzej","365822147")},
				{"115832147", new PhoneContact("Paweł","115832147")},
				{"965832545", new PhoneContact("Jan","965832545")},
			};
		}

		public static void Information()
		{
			Console.WriteLine("Please input a number depending on your choice: ");
			Console.WriteLine("1. Add new contact");
			Console.WriteLine("2. Display a contact depending on phone number");
			Console.WriteLine("3. Show all the numbers");
			Console.WriteLine("4. Find all the numbers for specific name");
			Console.WriteLine("0. Exit the program");
		}
	}
}
