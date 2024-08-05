using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void displayButton_Click(object sender, EventArgs e)
		{
			NutritionForm nutriForm = new NutritionForm();

			if (bananaRadioButton.Checked)
			{
				nutriForm.foodLabel.Text = "1 banana";
				nutriForm.caloriesLabel.Text = "100";
				nutriForm.fatLabel.Text = "0.4";
				nutriForm.carbLabel.Text = "27";
			}
			else if (popcornRadioButton.Checked)
			{
				nutriForm.foodLabel.Text = "1 cup air-popped popcorn";
				nutriForm.caloriesLabel.Text = "31";
				nutriForm.fatLabel.Text = "0.4";
				nutriForm.carbLabel.Text = "6";
			}
			else if (muffinRadioButton.Checked)
			{
				nutriForm.foodLabel.Text = "1 large blueberry muffin";
				nutriForm.caloriesLabel.Text = "385";
				nutriForm.fatLabel.Text = "9";
				nutriForm.carbLabel.Text = "67";
			}

			nutriForm.ShowDialog();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
