using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorTheme
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (yellowRadioButton.Checked)
			{
				BackColor = Color.Yellow;
			}
		}

		private void redRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (redRadioButton.Checked) 
			{
				BackColor = Color.Red;
			}
		}

		private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (whiteRadioButton.Checked)
			{
				BackColor = Color.White;
			}
		}

		private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (normalRadioButton.Checked)
			{
				BackColor = SystemColors.Control;
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
