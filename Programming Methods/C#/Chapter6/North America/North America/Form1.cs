using System;
using System.Windows.Forms;
using System.IO;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void GetFileName(out string selectedFile)
		{
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				selectedFile = openFile.FileName;
			}
			else
			{
				selectedFile = null;
			}
		}

		private void GetCountries(string filename)
		{
			try
			{
				string countryName;
				StreamReader inputFile;
				inputFile = File.OpenText(filename);
				countriesListBox.Items.Clear();

				while (!inputFile.EndOfStream)
				{
					countryName = inputFile.ReadLine();
					countriesListBox.Items.Add(countryName);
				}

				inputFile.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
	
		}

		private void getCountriesButton_Click(object sender, EventArgs e)
		{
			string filename;

			GetFileName(out filename);
			GetCountries(filename);
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
