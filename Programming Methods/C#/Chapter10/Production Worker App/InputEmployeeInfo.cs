using System;
using System.Windows.Forms;

namespace Production_Worker_App
{
	public partial class productionWorkerForm : Form
	{
		public productionWorkerForm()
		{
			InitializeComponent();
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			string name;
			int employeeNumber, shiftNumber;
			double hourlyPay;

			ProductionWorker worker = new ProductionWorker();

			name = employeeNameTextBox.Text;
			worker.Name = name;

			if (int.TryParse(employeeNumTextBox.Text, out employeeNumber))
			{
				worker.Number = employeeNumber;

				if (int.TryParse(shiftNumTextBox.Text, out shiftNumber))
				{
					if (shiftNumber < 4 && shiftNumber > 0)
					{
						worker.ShiftNumber = shiftNumber;

						if (double.TryParse(payRateTextBox.Text, out hourlyPay))
						{
							worker.HourlyPay = hourlyPay;

							ProductionWorkerStats statsForm = new ProductionWorkerStats
							{
								Worker = worker
							};

							statsForm.Show();
						}
						else
						{
							MessageBox.Show("Invalid pay rate");
						}
					}
					else
					{
						MessageBox.Show("Shift number must be 1, 2, or 3");
					}
				}
				else
				{
					MessageBox.Show("Invalid shift number");
				}
			}
			else
			{
				MessageBox.Show("Invalid employee number");
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
