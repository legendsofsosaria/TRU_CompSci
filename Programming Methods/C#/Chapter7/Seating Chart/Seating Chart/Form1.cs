using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void displayPriceButton_Click(object sender, EventArgs e)
		{
			int row, col;
			const int MAX_ROW = 5, MAX_COL = 3;

			decimal[,] prices = 
			{ 
				{ 450m, 450m, 450m, 450m }, { 425m, 425m, 425m, 425m }, { 400m, 400m, 400m, 400m },
				{ 375m, 375m, 375m, 375m }, { 375m, 375m, 375m, 375m }, { 350m, 350m, 350m, 350m } 
			};

			if (int.TryParse(rowTextBox.Text, out row))
			{
				if (int.TryParse(colTextBox.Text, out col))
				{
					if (row >= 0 && row <= MAX_ROW)
					{
						if (col >= 0 && col <= MAX_COL)
						{
							priceLabel.Text = prices[row, col].ToString("c");
						}
						else
						{
							MessageBox.Show("Column must be 0 through " + MAX_COL);
						}
					}
					else
					{
						MessageBox.Show("Row must be 0 through " + MAX_ROW);
					}
				}
				else
				{
					MessageBox.Show("Enter an integer for the column.");
				}
			}
			else
			{
				MessageBox.Show("Enter an integer for the row.");
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
