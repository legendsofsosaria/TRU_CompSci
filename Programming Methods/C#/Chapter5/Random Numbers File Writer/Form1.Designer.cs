namespace Assignment4
{
	partial class RandomNumberGenerator
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
			this.saveButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.numberGenTextBox = new System.Windows.Forms.TextBox();
			this.randomNumberLabel = new System.Windows.Forms.Label();
			this.saveFile = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(151, 119);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(97, 36);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "Save File";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(272, 119);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(100, 36);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// numberGenTextBox
			// 
			this.numberGenTextBox.Location = new System.Drawing.Point(224, 77);
			this.numberGenTextBox.Name = "numberGenTextBox";
			this.numberGenTextBox.Size = new System.Drawing.Size(61, 22);
			this.numberGenTextBox.TabIndex = 2;
			this.numberGenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// randomNumberLabel
			// 
			this.randomNumberLabel.AutoSize = true;
			this.randomNumberLabel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.randomNumberLabel.Location = new System.Drawing.Point(42, 35);
			this.randomNumberLabel.Name = "randomNumberLabel";
			this.randomNumberLabel.Size = new System.Drawing.Size(413, 21);
			this.randomNumberLabel.TabIndex = 3;
			this.randomNumberLabel.Text = "Enter the amount of random numbers to generate:";
			// 
			// RandomNumberGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 207);
			this.Controls.Add(this.randomNumberLabel);
			this.Controls.Add(this.numberGenTextBox);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.saveButton);
			this.Name = "RandomNumberGenerator";
			this.Text = "Random Number Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.TextBox numberGenTextBox;
		private System.Windows.Forms.Label randomNumberLabel;
		private System.Windows.Forms.SaveFileDialog saveFile;
	}
}

