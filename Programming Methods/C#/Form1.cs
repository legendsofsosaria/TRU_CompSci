using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void outputLabel_Click(object sender, EventArgs e)
		{

		}

		private void nameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void readInputButton_Click(object sender, EventArgs e)
		{
			outputLabel.Text = nameTextBox.Text;
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
