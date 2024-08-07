﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private const decimal CONTRIB_RATE = 0.05m;

		private bool InputIsValid(ref decimal pay, ref decimal bonus)
		{
			bool inputGood = false;

			if (decimal.TryParse(grossPayTextBox.Text, out pay))
			{
				if (decimal.TryParse(bonusTextBox.Text, out bonus))
				{
					inputGood = true;
				}
				else
				{
					MessageBox.Show("Bonus amount is invalid.");
				}
			}
			else
			{
				MessageBox.Show("Gross pay is invalid");
			}

			return inputGood;
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			decimal grossPay = 0m, bonus = 0m, contributions = 0m;

			if (InputIsValid(ref grossPay, ref bonus))
			{
				contributions = (grossPay + bonus) * CONTRIB_RATE;
				contributionLabel.Text = contributions.ToString("c");
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
