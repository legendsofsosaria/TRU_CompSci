using System;
using System.Windows.Forms;

namespace Vowels_and_Consonants
{
	public partial class Form1 : Form
	{
		private int vowelCount, consonantCount;

		public Form1()
		{
			InitializeComponent();
		}

		private bool IsVowel(char ch)
		{
			char lowerCh = char.ToLower(ch);

			return lowerCh == 'a' || lowerCh == 'e' || lowerCh == 'i' || lowerCh == 'o' || lowerCh == 'u';
		}

		private int CountVowels(string str)
		{
			vowelCount = 0;

			foreach (char ch in str)
			{
				if (IsVowel(ch))
				{
					vowelCount++;
				}
			}

			return vowelCount;
		}

		private int CountConsonants(string str)
		{
			consonantCount = 0;

			/* Count the number of consonants. I matched to upper and lower. 
			 * Could optionally use ToLower to do this as well instead of case matching */
			foreach (char ch in str)
			{
				if (char.IsLetter(ch) && !IsVowel(ch))
				{
					consonantCount++;
				}
			}

			return consonantCount;
		}

		private void countButton_Click(object sender, EventArgs e)
		{
			string input = stringTextBox.Text;

			CountConsonants(input);
			CountVowels(input);

			vowelTextBox.Text = vowelCount.ToString();
			consonantTextBox.Text = consonantCount.ToString();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
