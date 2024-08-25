using System;
using System.Windows.Forms;

namespace Multiform_Products
{
	public partial class DetailsForm : Form
	{
		public DetailsForm()
		{
			InitializeComponent();
		}

		private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			Validate();
			productBindingSource.EndEdit();
			tableAdapterManager.UpdateAll(productDataSet);

		}

		private void DetailsForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
			productTableAdapter.Fill(productDataSet.Product);

		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
