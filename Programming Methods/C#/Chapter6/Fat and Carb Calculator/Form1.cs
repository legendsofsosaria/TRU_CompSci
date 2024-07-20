using System;
using System.Windows.Forms;

namespace Fat_Percentage_Calculator
{
	public partial class FatCarbCalculator : Form
	{
		public FatCarbCalculator()
		{
			InitializeComponent();
		}

		private int FatCalories(int gramsFat)
		{
			return gramsFat * 9;
		}

		private int CarbCalories(int gramsCarbs)
		{

			return gramsCarbs * 4;
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			int gramsCarbs, gramsFat, caloriesFromFat, caloriesFromCarbs;

			if (int.TryParse(gramsFatTextBox.Text, out gramsFat))
			{
				if (int.TryParse(gramsCarbsTextBox.Text, out gramsCarbs))
				{
					if (gramsFat >= 0 && gramsCarbs >= 0)
					{
						caloriesFromFat = FatCalories(gramsFat);
						caloriesFromCarbs = CarbCalories(gramsCarbs);

						caloriesFatTextBox.Text = caloriesFromFat.ToString("n0");
						caloriesCarbsTextBox.Text = caloriesFromCarbs.ToString("n0");
					}
					else
					{
						MessageBox.Show("Grams of carbs and fat cannot be negative numbers.");
					}
				}
				else
				{
					MessageBox.Show("Invalid input for grams of carbs.");
				}
			}
			else
			{
				MessageBox.Show("Invalid input for grams of fat.");
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			gramsFatTextBox.Text = string.Empty;
			gramsCarbsTextBox.Text = string.Empty;
			caloriesFatTextBox.Text = string.Empty;
			caloriesCarbsTextBox.Text = string.Empty;

			gramsFatTextBox.Focus();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
