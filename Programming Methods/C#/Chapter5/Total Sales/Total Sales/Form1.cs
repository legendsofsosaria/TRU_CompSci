using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void calculateButton_Click(object sender, EventArgs e)
		{
			try
			{
				decimal sales;
				decimal total = 0m;

				StreamReader inputFile;

				inputFile = File.OpenText("Sales.txt");

				while (!inputFile.EndOfStream)
				{
					sales = decimal.Parse(inputFile.ReadLine());

					total += sales;
				}

				inputFile.Close();

				totalLabel.Text = total.ToString("C");
			}
			catch (Exception ex)
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
