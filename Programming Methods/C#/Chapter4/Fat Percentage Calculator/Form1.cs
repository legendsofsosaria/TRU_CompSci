using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fat_Percentage_Calculator
{
	public partial class FatPercentageCalculator : Form
	{
		public FatPercentageCalculator()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			const int CALC_FAT_CALORIES = 9;
			double calories, fatGrams, caloriesFromFat, calorieFatPercentage;

			if (double.TryParse(caloriesTextBox.Text, out calories))
			{
				if (double.TryParse(fatGramsTextBox.Text, out fatGrams))
				{
					if (calories >= 0 && fatGrams >= 0)
					{
						caloriesFromFat = fatGrams * CALC_FAT_CALORIES;
						caloriesFatTextBox.Text = caloriesFromFat.ToString("n");

						calorieFatPercentage = caloriesFromFat / calories;
						fatPercentTextBox.Text = calorieFatPercentage.ToString("p");
					}
					else
					{
						MessageBox.Show("Calories and grams of fat cannot be negative numbers.");
					}
				}
				else
				{
					MessageBox.Show("Invalid input for grams of fat.");
				}
			}
			else
			{
				MessageBox.Show("Invalid input for calories.");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			caloriesTextBox.Text = string.Empty;
			fatGramsTextBox.Text = string.Empty;
			caloriesFatTextBox.Text = string.Empty;
			fatPercentTextBox.Text = string.Empty;

			caloriesTextBox.Focus();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
