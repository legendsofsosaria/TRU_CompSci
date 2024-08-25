using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
	public partial class Products : Form
	{
		public Products()
		{
			InitializeComponent();
		}

		private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

		private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

		private void Products_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }
    }
}
