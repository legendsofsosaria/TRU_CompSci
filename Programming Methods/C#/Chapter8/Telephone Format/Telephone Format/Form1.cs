using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private bool IsValidNumber(string str)
		{
			const int VALID_LENGTH = 10;
			bool valid = true;

			if (str.Length == VALID_LENGTH)
			{
				foreach (char ch in str)
				{
					if (!char.IsDigit(ch))
					{
						valid = false;
					}
				}
			}
			else
			{
				valid = false;
			}

			return valid;
		}

		private void TelephoneFormat(ref string str)
		{
			str = str.Insert(0, "(");

			str = str.Insert(4, ")");

			str = str.Insert(8, "-");
		}

		private void formatButton_Click(object sender, EventArgs e)
		{
			string input = numberTextBox.Text.Trim();

			if (IsValidNumber(input))
			{
				TelephoneFormat(ref input);
				MessageBox.Show(input);
			}
			else
			{
				MessageBox.Show("Invalid input");
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
