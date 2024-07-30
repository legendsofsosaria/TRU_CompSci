using System;
using System.IO;
using System.Windows.Forms;

namespace DriversLicenseExam
{
	public partial class ExamResults : Form
	{
		private const int SIZE = 20;
		private int numWrong = 0, correctAnswers = 0;

		public ExamResults()
		{
			InitializeComponent();
		}

		private void CompareAnswers(string[] testersAnswers, string[] answerKey)
		{
			string[] wrongAnswers = new string[SIZE];

			for (int index = 0; index < answerKey.Length; index++)
			{
				if (testersAnswers[index] != answerKey[index])
				{
					wrongAnswers[index] = $"Question {index + 1}: {testersAnswers[index]}";
					numWrong++;
				}
				else
				{
					correctAnswers++;
				}
			}

			try
			{
				incorrectAnswerList.Items.Clear();

				foreach (string answer in wrongAnswers)
				{
					if (!string.IsNullOrEmpty(answer))
					{
						incorrectAnswerList.Items.Add(answer);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void resultsButton_Click(object sender, EventArgs e)
		{
			try
			{
				StreamReader inputFile;
				int index = 0;

				numWrong = 0;
				correctAnswers = 0;

				string[] answerKey = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", 
				"B", "C", "D", "A", "D", "C", "C", "B", "D", "A"};
				string[] testersAnswers = new string[SIZE];

				if (openFile.ShowDialog() == DialogResult.OK)
				{
					/* Open selected file for reading */
					inputFile = File.OpenText(openFile.FileName);

					while (!inputFile.EndOfStream && index < answerKey.Length)
					{
						testersAnswers[index] = inputFile.ReadLine();
						index++;
					}

					inputFile.Close();
				}

				CompareAnswers(testersAnswers, answerKey);
				answersWrongTextBox.Text = numWrong.ToString();
				answersRightTextBox.Text = correctAnswers.ToString();

				if (correctAnswers >= 15)
				{
					passFailLabel.Text = "You passed the exam!";
				}
				else
				{
					passFailLabel.Text = "You failed the exam!";
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
