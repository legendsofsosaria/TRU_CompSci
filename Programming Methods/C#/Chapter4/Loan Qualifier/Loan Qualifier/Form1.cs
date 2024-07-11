﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void checkButton_Click(object sender, EventArgs e)
		{
			try
			{
				const decimal MINIMUM_SALARY = 40000m;
				const int MINIMUM_YEARS_ON_JOB = 2;

				decimal salary;
				int yearsOnJob;

				salary = decimal.Parse(salaryTextBox.Text);
				yearsOnJob = int.Parse(yearsTextBox.Text);

				if (salary >= MINIMUM_SALARY)
				{
					if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
					{
						decisionLabel.Text = "You qualify for the loan.";
					}
					else
					{
						decisionLabel.Text = "Minimum years at current job not met.";
					}
				}
				else
				{
					decisionLabel.Text = "Minimum salary requirement not met.";
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			salaryTextBox.Text = string.Empty;
			yearsTextBox.Text = string.Empty;
			decisionLabel.Text = string.Empty;

			salaryTextBox.Focus();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
