/* 
Elizabeth House
T00738901
COMP 2211 Programming Methods
C# Assignment 5
08/10/2024
*/

namespace Assignment5
{
	public class Person
	{
		/* Private variables for storing peron's info */
		private string _name;
		private string _address;
		private string _telephoneNum;

		/* Property to get or set the person's name */
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/* Property to get or set the person's address */
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/* Property to get or set the person's telephone number */
		public string TelephoneNum
		{
			get { return _telephoneNum; }
			set { _telephoneNum = value; }
		}

		/* Default constructor initializes fields to empty strings */
		public Person()
		{
			_name = string.Empty;
			_address = string.Empty;
			_telephoneNum = string.Empty;
		}
	}
}
