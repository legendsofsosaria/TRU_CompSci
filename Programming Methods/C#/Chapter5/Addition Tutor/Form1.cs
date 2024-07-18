using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_Tutor
{
	public partial class AdditionTutor : Form
	{
		int randomOne, randomTwo, answer;
		Random rand = new Random();

		public AdditionTutor()
		{
			InitializeComponent();
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (int.TryParse(answerTextBox.Text, out answer))
				{
					if (randomOne + randomTwo == answer)
					{
						MessageBox.Show("That answer is correct!");
						integerOne.Text = string.Empty;
						integerTwo.Text = string.Empty;
						answerTextBox.Text = string.Empty;

						randomOne = rand.Next(100, 501);
						randomTwo = rand.Next(100, 501);

						integerOne.Text = randomOne.ToString();
						integerTwo.Text = randomTwo.ToString();

						answerTextBox.Focus();
					}
					else
					{
						MessageBox.Show("That answer is incorrect.");
					}
				}

			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void AdditionTutor_Load(object sender, EventArgs e)
		{
			try
			{
				randomOne = rand.Next(100, 501);
				randomTwo = rand.Next(100, 501);

				integerOne.Text = randomOne.ToString();
				integerTwo.Text = randomTwo.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
