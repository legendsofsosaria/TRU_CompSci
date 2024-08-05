using System;
using System.Windows.Forms;

namespace Car
{
	public partial class Driver : Form
	{
		private Car _car;

		public Driver(Car car)
		{
			InitializeComponent();
			_car = car;
			UpdateSpeedLabel();
		}

		private void UpdateSpeedLabel()
		{
			speedLabel.Text = _car.Speed.ToString();
		}

		private void accelerateButton_Click(object sender, EventArgs e)
		{
			_car.Accelerate();
			UpdateSpeedLabel();
		}

		private void brakeButton_Click(object sender, EventArgs e)
		{
			_car.Brake();
			UpdateSpeedLabel();
		}
	}
}