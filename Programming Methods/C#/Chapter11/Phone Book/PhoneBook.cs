using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
	public partial class PhoneBook : Form
	{
		public PhoneBook()
		{
			InitializeComponent();
		}

		private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personDataSet);

        }

		private void PhoneBook_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'personDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.personDataSet.Person);

        }
    }
}
