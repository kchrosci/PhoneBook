using System;
using System.Collections.Generic;

namespace PhoneBookConsoleApp
{ 
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to PhoneBook program!");
			Information();
			int decision = int.Parse(Console.ReadLine());
			Dictionary<string, PhoneContact> phoneBook = new Dictionary<string, PhoneContact>();
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
				decision = int.Parse(Console.ReadLine());
			}
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
