using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookLibrary
{
	public class TelephoneBook
	{
		public List<Person> PersonList { get; set; }

		public TelephoneBook()
		{
			PersonList = new List<Person>();
		}

		public List<Person> SortOnLastName()
		{
			var result = PersonList.OrderBy(p => p.LastName);
			return result.ToList();
		}

		public List<Person> FirstNameStartsWith(string c)
		{
			var result = PersonList.OrderBy(p => p.LastName).Where(p => p.FirstName.StartsWith(c));
			return result.ToList();
		}

		public List<Person> WhereLastNameIsLargerThan(int length)
		{
			var result = PersonList.Where(p => p.LastName.Length > length);
			return result.ToList();
		}
		


	}
}
