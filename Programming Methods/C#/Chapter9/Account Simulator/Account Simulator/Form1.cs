using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
		private BankAccount account = new BankAccount(1000);
        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			balanceLabel.Text = account.Balance.ToString("c");
		}

		private void depositButton_Click(object sender, EventArgs e)
		{
			decimal amount;

			if (decimal.TryParse(depositTextBox.Text, out amount))
			{
				account.Deposit(amount);
				balanceLabel.Text = account.Balance.ToString("c");
				depositTextBox.Clear();
			}
			else
			{
				MessageBox.Show("Invalid amount");
			}
		}

		private void withdrawButton_Click(object sender, EventArgs e)
		{
			decimal amount;

			if (decimal.TryParse(withdrawTextBox.Text, out amount))
			{
				account.Withdraw(amount);
				balanceLabel.Text = account.Balance.ToString("c");
				withdrawTextBox.Clear();
			}
			else
			{
				MessageBox.Show("Invalid amount");
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
