using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private bool IsValidFormat(string str)
		{
			const int VALID_LENGTH = 13;
			bool valid;

			if (str.Length == VALID_LENGTH && str[0] == '(' && str[4] == ')' && str[8] == '-')
			{
				valid = true;
			}
			else
			{
				valid = false;
			}

			return valid;
		}

		private void Unformat(ref string str)
		{
			/* Remove left parenthesis */
			str = str.Remove(0, 1);

			/* Remove the right parenthesis */
			str = str.Remove(3, 1);

			/* Delete the hyphen */
			str = str.Remove(6, 1);
		}

		private void unformatButton_Click(object sender, EventArgs e)
		{
			string input = numberTextBox.Text.Trim();

			if (IsValidFormat(input))
			{
				Unformat(ref input);
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
