/* 
Elizabeth House
T00738901
COMP 2211 Programming Methods
C# Assignment 4
 */

using System;
using System.Windows.Forms;
using System.IO;

namespace Random_Numbers_File_Reader
{
	public partial class randFileReader : Form
	{
		public randFileReader()
		{
			InitializeComponent();
		}

		private void submitButton_Click(object sender, EventArgs e)
		{	
			try
			{
				int randomNumber, count = 0, numberTotal = 0;
				StreamReader inputFile;

				/* Open dialog to select the file */
				if (openFile.ShowDialog() == DialogResult.OK)
				{
					/* Open selected file for reading */
					inputFile = File.OpenText(openFile.FileName);

					/* Clear list box before filling it */
					randomNumberListBox.Items.Clear();

					/* Reach each line of the file until the end of file */
					while (!inputFile.EndOfStream) 
					{
						/* Read lines from the input file and try to parse to int */
						if (int.TryParse(inputFile.ReadLine(), out randomNumber)) 
						{
							/* Add numbers to the list box */
							randomNumberListBox.Items.Add("Number: " + randomNumber);

							/* Add numbers to accumulator */
							numberTotal += randomNumber;

							/* Increase the count */
							count++;
						}
					}
					/* Convert the total and count to strings and display in UI */
					numberTotalOutput.Text = numberTotal.ToString(); 
					numberCountOutput.Text = count.ToString();

					/* Close the input file */
					inputFile.Close(); 
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
