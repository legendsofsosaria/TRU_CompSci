using System;
using System.Windows.Forms;

namespace Car
{
	public partial class CarForm : Form
	{
		private Car _car;

		public CarForm()
		{
			InitializeComponent();
		}

		private void GetCarData()
		{
			int year;

			if (int.TryParse(yearTextBox.Text, out year))
			{
				string make = makeTextBox.Text;
				_car = new Car(year, make);
			}
			else
			{
				MessageBox.Show("Invalid year");
			}
		}

		private void driveButton_Click(object sender, EventArgs e)
		{
			GetCarData();

			if (_car != null)
			{
				Driver myDriver = new Driver(_car);
				myDriver.ShowDialog();
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
