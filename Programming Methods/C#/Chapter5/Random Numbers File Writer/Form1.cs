using System;
using System.Windows.Forms;
using System.IO;

namespace Assignment4
{
	public partial class RandomNumberGenerator : Form
	{
		private static readonly Random random = new Random(); 

		public RandomNumberGenerator()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			try
			{
				StreamWriter outputFile;				
				int numberInput;

				if (saveFile.ShowDialog() == DialogResult.OK)
				{
					outputFile = File.CreateText(saveFile.FileName);

					if (int.TryParse(numberGenTextBox.Text, out numberInput))
					{
						for (int i = 1; i <= numberInput; i++)
						{
							int number = random.Next(1, 101);

							outputFile.WriteLine(number);
						}
					}

					outputFile.Close();
					MessageBox.Show("The numbers were saved to a file.");
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
	}
}
