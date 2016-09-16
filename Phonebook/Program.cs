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

		}
	}
}
