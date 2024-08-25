/* 
Elizabeth House
T00738901
COMP 2211 Programming Methods
C# Assignment 5
08/10/2024
*/

namespace Assignment5
{
	public class PreferredCustomer : Customer
	{
		/* Private variables for preferred customer-specific information */
		private double _purchaseTotal;
		private double _discountAmount;

		/* Property to get or set the purchase total */
		public double PurchaseTotal
		{
			get { return _purchaseTotal; }
			set
			{
				_purchaseTotal = value;
				SetDiscount(value);
			}
		}

		/* Property to get the discount amount */
		public double DiscountAmount => _discountAmount;

		/* Default constructor initializes fields */
		public PreferredCustomer()
		{
			_purchaseTotal = 0;
			_discountAmount = 0;
		}

		/* Constructor with purchase total to initialize fields and calculate discount */
		public PreferredCustomer(double purchaseTotal)
		{
			_purchaseTotal = purchaseTotal;
			SetDiscount(purchaseTotal);
		}

		/* Method to set the discount based on the customer's purchase total */
		public void SetDiscount(double purchaseTotal)
		{
			if (purchaseTotal >= 500 && purchaseTotal < 1000)
			{
				_discountAmount = .05;
			}
			else if (purchaseTotal >= 1000 && purchaseTotal < 1500)
			{
				_discountAmount = .06;
			}
			else if (purchaseTotal >= 1500 && purchaseTotal < 2000)
			{
				_discountAmount = .07;
			}
			else if (purchaseTotal >= 2000)
			{
				_discountAmount = .10;
			}
			else
			{
				_discountAmount = 0;
			}
		}
	}
}
