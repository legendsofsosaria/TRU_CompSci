/* 
Elizabeth House
T00738901
COMP 2211 Programming Methods
C# Assignment 5
08/10/2024
*/

namespace Assignment5
{
	public class Customer : Person
	{
		/* Private variables for customer-specific information */
		private string _customerNum;
		private bool _mailList;

		/* Property to get or set the customer's address */
		public string CustomerNum
		{
			get { return _customerNum; }
			set { _customerNum = value; }
		}

		/* Property to get or set the customer's mailing list preference */
		public bool MailList
		{
			get { return _mailList; }
			set { _mailList = value; }
		}

		/* Default constructor initializes fields */
		public Customer()
		{
			_customerNum = string.Empty;
			_mailList = false;
		}
	}
}
