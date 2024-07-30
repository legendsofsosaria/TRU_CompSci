namespace DriversLicenseExam
{
	partial class ExamResults
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.totalCorrectLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.incorrectAnswerList = new System.Windows.Forms.ListBox();
			this.resultsButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.answersWrongTextBox = new System.Windows.Forms.Label();
			this.answersRightTextBox = new System.Windows.Forms.Label();
			this.passFailLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// totalCorrectLabel
			// 
			this.totalCorrectLabel.AutoSize = true;
			this.totalCorrectLabel.Font = new System.Drawing.Font("Javanese Text", 10F);
			this.totalCorrectLabel.Location = new System.Drawing.Point(38, 24);
			this.totalCorrectLabel.Name = "totalCorrectLabel";
			this.totalCorrectLabel.Size = new System.Drawing.Size(184, 38);
			this.totalCorrectLabel.TabIndex = 0;
			this.totalCorrectLabel.Text = "Total Correct Answers:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Javanese Text", 10F);
			this.label1.Location = new System.Drawing.Point(38, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(196, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "Total Incorrect Answers:";
			// 
			// incorrectAnswerList
			// 
			this.incorrectAnswerList.FormattingEnabled = true;
			this.incorrectAnswerList.ItemHeight = 16;
			this.incorrectAnswerList.Location = new System.Drawing.Point(45, 128);
			this.incorrectAnswerList.Name = "incorrectAnswerList";
			this.incorrectAnswerList.Size = new System.Drawing.Size(248, 164);
			this.incorrectAnswerList.TabIndex = 4;
			// 
			// resultsButton
			// 
			this.resultsButton.Location = new System.Drawing.Point(76, 366);
			this.resultsButton.Name = "resultsButton";
			this.resultsButton.Size = new System.Drawing.Size(100, 35);
			this.resultsButton.TabIndex = 5;
			this.resultsButton.Text = "Results";
			this.resultsButton.UseVisualStyleBackColor = true;
			this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(182, 366);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(100, 35);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// openFile
			// 
			this.openFile.FileName = "openFile";
			// 
			// answersWrongTextBox
			// 
			this.answersWrongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.answersWrongTextBox.Font = new System.Drawing.Font("Javanese Text", 10F);
			this.answersWrongTextBox.Location = new System.Drawing.Point(248, 81);
			this.answersWrongTextBox.Name = "answersWrongTextBox";
			this.answersWrongTextBox.Size = new System.Drawing.Size(45, 35);
			this.answersWrongTextBox.TabIndex = 8;
			this.answersWrongTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// answersRightTextBox
			// 
			this.answersRightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.answersRightTextBox.Font = new System.Drawing.Font("Javanese Text", 10F);
			this.answersRightTextBox.Location = new System.Drawing.Point(248, 26);
			this.answersRightTextBox.Name = "answersRightTextBox";
			this.answersRightTextBox.Size = new System.Drawing.Size(45, 35);
			this.answersRightTextBox.TabIndex = 9;
			this.answersRightTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// passFailLabel
			// 
			this.passFailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.passFailLabel.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passFailLabel.Location = new System.Drawing.Point(56, 311);
			this.passFailLabel.Name = "passFailLabel";
			this.passFailLabel.Size = new System.Drawing.Size(237, 33);
			this.passFailLabel.TabIndex = 10;
			this.passFailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ExamResults
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 423);
			this.Controls.Add(this.passFailLabel);
			this.Controls.Add(this.answersRightTextBox);
			this.Controls.Add(this.answersWrongTextBox);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.resultsButton);
			this.Controls.Add(this.incorrectAnswerList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.totalCorrectLabel);
			this.Name = "ExamResults";
			this.Text = "Exam Results";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label totalCorrectLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox incorrectAnswerList;
		private System.Windows.Forms.Button resultsButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.Label answersWrongTextBox;
		private System.Windows.Forms.Label answersRightTextBox;
		private System.Windows.Forms.Label passFailLabel;
	}
}

