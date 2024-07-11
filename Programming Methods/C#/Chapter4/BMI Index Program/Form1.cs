using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Index_Program
{
	public partial class bmiCalculator : Form
	{
		public bmiCalculator()
		{
			InitializeComponent();
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			const int MULTIPLIER = 703;

			double weight, height, BMI;

			if (double.TryParse(weightTextBox.Text, out weight))
			{
				if (double.TryParse(heightTextBox.Text, out height))
				{
					BMI = weight * MULTIPLIER / (Math.Pow(height, 2));
					bmiTextBox.Text = BMI.ToString("n1");
				}
				else
				{
					MessageBox.Show("Invalid input for height.");
				}
			}
			else
			{
				MessageBox.Show("Invalid input for weight.");
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			weightTextBox.Text = string.Empty;
			heightTextBox.Text = string.Empty;
			bmiTextBox.Text = string.Empty;

			weightTextBox.Focus();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
