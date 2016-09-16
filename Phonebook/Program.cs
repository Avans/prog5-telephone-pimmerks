using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhonebookLibrary;
namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			string character = "e";


			TelephoneBook phoneBook = new TelephoneBook();
			phoneBook.PersonList.Add(new Person("aaa", "a"));
			phoneBook.PersonList.Add(new Person("aaa", "b"));
			phoneBook.PersonList.Add(new Person("bbb", "b"));
			phoneBook.PersonList.Add(new Person("bbb", "b"));
			phoneBook.PersonList.Add(new Person("bbb", "c"));
			phoneBook.PersonList.Add(new Person("ccc", "c"));
			phoneBook.PersonList.Add(new Person("ddd", "d"));
			phoneBook.PersonList.Add(new Person("eee", "e"));
			phoneBook.PersonList.Add(new Person("fff", "b"));
			phoneBook.PersonList.Add(new Person("ggg", "d"));

			Console.WriteLine("PersonList:");
			PrintPersonList(phoneBook.PersonList);
			Console.WriteLine();

			Console.WriteLine("Sorted on last name:");
			PrintPersonList(phoneBook.SortOnLastName());
			Console.WriteLine();

			Console.WriteLine("First name starts with: " + character);
			PrintPersonList(phoneBook.FirstNameStartsWith(character));
			Console.WriteLine();



			Console.ReadKey();
		}


		static void PrintPersonList(List<Person> list)
		{
			int i = 0;
			foreach (var item in list)
			{
				Console.WriteLine(i + ". " + item.FullName);
				i++;
			}
		}
	}
}
