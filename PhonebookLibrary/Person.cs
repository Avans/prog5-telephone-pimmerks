using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookLibrary
{
	public class Person
	{
		public String FirstName { get; set; }
		public String LastName { get; set; }
		public int PhoneNumber { get; set; }

		public String FullName { get { return FirstName + " " + LastName; }}

		public Person(String firstName, String lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}


	}
}
