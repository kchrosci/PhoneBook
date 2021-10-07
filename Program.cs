using System;

namespace PhoneBook
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Phone Book program!");
			Information();
			int decision = int.Parse(Console.ReadLine());
			while (decision != 0) 
			{
				PhoneContact phoneContact = new PhoneContact("Jano", "123123123131");


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
