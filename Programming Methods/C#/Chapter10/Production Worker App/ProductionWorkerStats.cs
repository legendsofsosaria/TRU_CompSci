using System;
using System.Windows.Forms;

namespace Production_Worker_App
{
	public partial class ProductionWorkerStats : Form
	{
		public ProductionWorker Worker { get; set; }

		public ProductionWorkerStats()
		{
			InitializeComponent();
		}

		private void ProductionWorkerStats_Load(object sender, EventArgs e)
		{
			if (Worker != null)
			{
				employeeNameLabel.Text = Worker.Name;
				employeeNumLabel.Text = Worker.Number.ToString();
				shiftNumLabel.Text = Worker.ShiftNumber.ToString();
				payRateLabel.Text = Worker.HourlyPay.ToString();
			}
		}
	}
}
