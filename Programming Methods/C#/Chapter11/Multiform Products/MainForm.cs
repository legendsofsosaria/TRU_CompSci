using System;
using System.Windows.Forms;

namespace Multiform_Products
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			Validate();
			productBindingSource.EndEdit();
			tableAdapterManager.UpdateAll(productDataSet);

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
			productTableAdapter.Fill(productDataSet.Product);

		}

		private void showDetailsButton_Click(object sender, EventArgs e)
		{
			DetailsForm details = new DetailsForm();

			details.ShowDialog();

			productTableAdapter.Fill(productDataSet.Product);
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
