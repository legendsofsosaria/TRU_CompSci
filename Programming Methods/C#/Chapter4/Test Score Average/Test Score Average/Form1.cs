using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Score_Average
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
				const double HIGH_SCORE = 95.0;
				double test1, test2, test3, average;

				test1 = double.Parse(test1TextBox.Text);
				test2 = double.Parse(test2TextBox.Text);
				test3 = double.Parse(test3TextBox.Text);

				average = (test1 + test2 + test3) / 3.0;

				averageLabel.Text = average.ToString("n1");

				if (average > HIGH_SCORE)
				{
					MessageBox.Show("Congratulations! Great job!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			test1TextBox.Text = string.Empty;
			test2TextBox.Text = string.Empty;
			test3TextBox.Text = string.Empty;
			averageLabel.Text = string.Empty;

			test1TextBox.Focus();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
