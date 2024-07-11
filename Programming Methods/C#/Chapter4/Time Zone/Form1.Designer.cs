namespace Time_Zone
{
	partial class Form1
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
			this.promptLabel = new System.Windows.Forms.Label();
			this.cityListBox = new System.Windows.Forms.ListBox();
			this.outputDescriptionLabel = new System.Windows.Forms.Label();
			this.timeZoneLabel = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// promptLabel
			// 
			this.promptLabel.AutoSize = true;
			this.promptLabel.Location = new System.Drawing.Point(34, 25);
			this.promptLabel.Name = "promptLabel";
			this.promptLabel.Size = new System.Drawing.Size(270, 16);
			this.promptLabel.TabIndex = 0;
			this.promptLabel.Text = "Select a city and I will give you the time zone.";
			// 
			// cityListBox
			// 
			this.cityListBox.FormattingEnabled = true;
			this.cityListBox.ItemHeight = 16;
			this.cityListBox.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
			this.cityListBox.Location = new System.Drawing.Point(85, 56);
			this.cityListBox.Name = "cityListBox";
			this.cityListBox.Size = new System.Drawing.Size(150, 84);
			this.cityListBox.TabIndex = 1;
			// 
			// outputDescriptionLabel
			// 
			this.outputDescriptionLabel.AutoSize = true;
			this.outputDescriptionLabel.Location = new System.Drawing.Point(51, 163);
			this.outputDescriptionLabel.Name = "outputDescriptionLabel";
			this.outputDescriptionLabel.Size = new System.Drawing.Size(75, 16);
			this.outputDescriptionLabel.TabIndex = 2;
			this.outputDescriptionLabel.Text = "Time Zone:";
			// 
			// timeZoneLabel
			// 
			this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.timeZoneLabel.Location = new System.Drawing.Point(132, 154);
			this.timeZoneLabel.Name = "timeZoneLabel";
			this.timeZoneLabel.Size = new System.Drawing.Size(141, 25);
			this.timeZoneLabel.TabIndex = 3;
			this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(45, 195);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(103, 35);
			this.okButton.TabIndex = 4;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(174, 195);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(107, 35);
			this.exitButton.TabIndex = 5;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 250);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.timeZoneLabel);
			this.Controls.Add(this.outputDescriptionLabel);
			this.Controls.Add(this.cityListBox);
			this.Controls.Add(this.promptLabel);
			this.Name = "Form1";
			this.Text = "Time Zone";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label promptLabel;
		private System.Windows.Forms.ListBox cityListBox;
		private System.Windows.Forms.Label outputDescriptionLabel;
		private System.Windows.Forms.Label timeZoneLabel;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button exitButton;
	}
}

