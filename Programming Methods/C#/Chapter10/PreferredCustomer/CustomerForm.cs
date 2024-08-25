/* 
Elizabeth House
T00738901
COMP 2211 Programming Methods
C# Assignment 5
08/10/2024
*/

namespace Assignment5
{
	public partial class CustomerForm : Form
	{
		public CustomerForm()
		{
			InitializeComponent();
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			/* Create a new PreferredCustomer object */
			PreferredCustomer customer = new PreferredCustomer();

			string name = nameTextBox.Text;
			string address = addressTextBox.Text;
			string phoneNumber = phoneTextBox.Text;
			string customerNumber = customerNumTextBox.Text;
			double purchaseTotal;

			/* Ensure all required fields are filled out */
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address)
				|| string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(customerNumber))
			{
				MessageBox.Show("Please fill out all fields");
				return;
			}

			/* Ensure a mailing list option is selected */
			if (!yesButton.Checked && !noButton.Checked)
			{
				MessageBox.Show("Please select an option for the mailing list");
				return;
			}

			/* Set properties on the customer object */
			customer.Name = name;
			customer.Address = address;
			customer.TelephoneNum = phoneNumber;
			customer.CustomerNum = customerNumber;
			customer.MailList = yesButton.Checked;

			/* Parse the purchase total and display the discount amount */
			if (double.TryParse(purchaseTotalTextBox.Text, out purchaseTotal))
			{
				customer.PurchaseTotal = purchaseTotal;
				discountTextBox.Text = customer.DiscountAmount.ToString("p0");
			}
			else
			{
				MessageBox.Show("Invalid purchase total");
			}
		}

		/* Close the form when the exit button is clicked */
		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}