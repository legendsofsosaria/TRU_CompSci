using System;
using System.Windows.Forms;

namespace Product_Queries
{
	public partial class Product : Form
	{
		public Product()
		{
			InitializeComponent();
		}

		private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			Validate();
			productBindingSource.EndEdit();
			tableAdapterManager.UpdateAll(productDataSet);

		}

		private void Product_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
			productTableAdapter.Fill(productDataSet.Product);

		}

		private void unitsGreater100Button_Click(object sender, EventArgs e)
		{
			productTableAdapter.FillByUnits(productDataSet.Product);
		}

		private void sortByPriceButton_Click(object sender, EventArgs e)
		{
			productTableAdapter.FillByPrice(productDataSet.Product);
		}

		private void averagePriceButton_Click(object sender, EventArgs e)
		{ 
			decimal averagePrice = (decimal)productTableAdapter.AveragePrice();

			MessageBox.Show("Average price of all items: " + averagePrice.ToString("c"));
		}
	}
}
