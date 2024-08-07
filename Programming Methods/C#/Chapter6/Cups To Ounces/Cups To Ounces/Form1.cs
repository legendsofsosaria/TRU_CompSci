﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private double CupsToOunces(double cups)
		{
			return cups * 8.0;
		}

		private void convertButton_Click(object sender, EventArgs e)
		{
			double cups, ounces;

			if (double.TryParse(cupsTextBox.Text, out cups))
			{
				ounces = CupsToOunces(cups);
				ouncesLabel.Text = ounces.ToString("n1");
			}
			else
			{
				MessageBox.Show("Enter a valid number.");
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
