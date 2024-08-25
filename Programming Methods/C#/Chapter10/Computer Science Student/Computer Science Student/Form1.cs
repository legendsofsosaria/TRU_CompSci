using System;
using System.Windows.Forms;

namespace Computer_Science_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		

		private void exitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void getHoursButton_Click(object sender, EventArgs e)
		{
			string name, id, track;

			name = nameTextBox.Text;
			id = idTextBox.Text;

			if (infoSystemsRadioButton.Checked)
			{
				track = "Information Systems";
			}
			else
			{
				track = "Software Engineering";
			}

			CompSciStudent csStudent = new CompSciStudent(name, id, track);
			requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
		}
	}
}
