using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
	public partial class DistanceCalculator : Form
	{
		public DistanceCalculator()
		{
			InitializeComponent();
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			try
			{
				int speed, time, distance, currentDistance;

				if (int.TryParse(vehicleSpeedTextBox.Text, out speed))
				{
					if (int.TryParse(hoursTraveledTextBox.Text, out time))
					{
						distance = speed * time;

						for (int hour = 1; hour <= time; hour++)
						{
							currentDistance = speed * hour;
							distanceListBox.Items.Add("After hour " + hour + " the distance is " + currentDistance);
						}
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
