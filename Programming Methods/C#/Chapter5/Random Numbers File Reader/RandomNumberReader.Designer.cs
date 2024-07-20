namespace Random_Numbers_File_Reader
{
	partial class randFileReader
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
			this.openFileButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.randomNumberListBox = new System.Windows.Forms.ListBox();
			this.numberTotalLabel = new System.Windows.Forms.Label();
			this.numberAmountLabel = new System.Windows.Forms.Label();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.numberTotalOutput = new System.Windows.Forms.Label();
			this.numberCountOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// openFileButton
			// 
			this.openFileButton.Location = new System.Drawing.Point(106, 296);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(90, 40);
			this.openFileButton.TabIndex = 0;
			this.openFileButton.Text = "Open File";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(225, 296);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(90, 40);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// randomNumberListBox
			// 
			this.randomNumberListBox.FormattingEnabled = true;
			this.randomNumberListBox.ItemHeight = 16;
			this.randomNumberListBox.Location = new System.Drawing.Point(106, 110);
			this.randomNumberListBox.Name = "randomNumberListBox";
			this.randomNumberListBox.Size = new System.Drawing.Size(209, 180);
			this.randomNumberListBox.TabIndex = 2;
			// 
			// numberTotalLabel
			// 
			this.numberTotalLabel.AutoSize = true;
			this.numberTotalLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numberTotalLabel.Location = new System.Drawing.Point(102, 22);
			this.numberTotalLabel.Name = "numberTotalLabel";
			this.numberTotalLabel.Size = new System.Drawing.Size(121, 20);
			this.numberTotalLabel.TabIndex = 3;
			this.numberTotalLabel.Text = "Number Total:";
			// 
			// numberAmountLabel
			// 
			this.numberAmountLabel.AutoSize = true;
			this.numberAmountLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numberAmountLabel.Location = new System.Drawing.Point(102, 65);
			this.numberAmountLabel.Name = "numberAmountLabel";
			this.numberAmountLabel.Size = new System.Drawing.Size(127, 20);
			this.numberAmountLabel.TabIndex = 4;
			this.numberAmountLabel.Text = "Number Count:";
			// 
			// openFile
			// 
			this.openFile.FileName = "openFile";
			// 
			// numberTotalOutput
			// 
			this.numberTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.numberTotalOutput.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numberTotalOutput.Location = new System.Drawing.Point(250, 17);
			this.numberTotalOutput.Name = "numberTotalOutput";
			this.numberTotalOutput.Size = new System.Drawing.Size(65, 33);
			this.numberTotalOutput.TabIndex = 5;
			this.numberTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numberCountOutput
			// 
			this.numberCountOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.numberCountOutput.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numberCountOutput.Location = new System.Drawing.Point(250, 60);
			this.numberCountOutput.Name = "numberCountOutput";
			this.numberCountOutput.Size = new System.Drawing.Size(65, 33);
			this.numberCountOutput.TabIndex = 6;
			this.numberCountOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// randFileReader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 363);
			this.Controls.Add(this.numberCountOutput);
			this.Controls.Add(this.numberTotalOutput);
			this.Controls.Add(this.numberAmountLabel);
			this.Controls.Add(this.numberTotalLabel);
			this.Controls.Add(this.randomNumberListBox);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.openFileButton);
			this.Name = "randFileReader";
			this.Text = "Random Number Reader";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.ListBox randomNumberListBox;
		private System.Windows.Forms.Label numberTotalLabel;
		private System.Windows.Forms.Label numberAmountLabel;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.Label numberTotalOutput;
		private System.Windows.Forms.Label numberCountOutput;
	}
}

