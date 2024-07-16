namespace Distance_Calculator
{
	partial class DistanceCalculator
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
			this.vehicleSpeedLabel = new System.Windows.Forms.Label();
			this.hoursTraveledLabel = new System.Windows.Forms.Label();
			this.vehicleSpeedTextBox = new System.Windows.Forms.TextBox();
			this.hoursTraveledTextBox = new System.Windows.Forms.TextBox();
			this.distanceListBox = new System.Windows.Forms.ListBox();
			this.calculateButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// vehicleSpeedLabel
			// 
			this.vehicleSpeedLabel.AutoSize = true;
			this.vehicleSpeedLabel.Location = new System.Drawing.Point(41, 25);
			this.vehicleSpeedLabel.Name = "vehicleSpeedLabel";
			this.vehicleSpeedLabel.Size = new System.Drawing.Size(145, 16);
			this.vehicleSpeedLabel.TabIndex = 0;
			this.vehicleSpeedLabel.Text = "Vehicle Speed in MPH:";
			// 
			// hoursTraveledLabel
			// 
			this.hoursTraveledLabel.AutoSize = true;
			this.hoursTraveledLabel.Location = new System.Drawing.Point(41, 58);
			this.hoursTraveledLabel.Name = "hoursTraveledLabel";
			this.hoursTraveledLabel.Size = new System.Drawing.Size(104, 16);
			this.hoursTraveledLabel.TabIndex = 1;
			this.hoursTraveledLabel.Text = "Hours Traveled:";
			// 
			// vehicleSpeedTextBox
			// 
			this.vehicleSpeedTextBox.Location = new System.Drawing.Point(192, 22);
			this.vehicleSpeedTextBox.Name = "vehicleSpeedTextBox";
			this.vehicleSpeedTextBox.Size = new System.Drawing.Size(100, 22);
			this.vehicleSpeedTextBox.TabIndex = 2;
			// 
			// hoursTraveledTextBox
			// 
			this.hoursTraveledTextBox.Location = new System.Drawing.Point(192, 52);
			this.hoursTraveledTextBox.Name = "hoursTraveledTextBox";
			this.hoursTraveledTextBox.Size = new System.Drawing.Size(100, 22);
			this.hoursTraveledTextBox.TabIndex = 3;
			// 
			// distanceListBox
			// 
			this.distanceListBox.FormattingEnabled = true;
			this.distanceListBox.ItemHeight = 16;
			this.distanceListBox.Location = new System.Drawing.Point(44, 89);
			this.distanceListBox.Name = "distanceListBox";
			this.distanceListBox.Size = new System.Drawing.Size(254, 180);
			this.distanceListBox.TabIndex = 4;
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(70, 290);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(80, 30);
			this.calculateButton.TabIndex = 5;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(175, 290);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(80, 30);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// DistanceCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 341);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.distanceListBox);
			this.Controls.Add(this.hoursTraveledTextBox);
			this.Controls.Add(this.vehicleSpeedTextBox);
			this.Controls.Add(this.hoursTraveledLabel);
			this.Controls.Add(this.vehicleSpeedLabel);
			this.Name = "DistanceCalculator";
			this.Text = "Distance Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label vehicleSpeedLabel;
		private System.Windows.Forms.Label hoursTraveledLabel;
		private System.Windows.Forms.TextBox vehicleSpeedTextBox;
		private System.Windows.Forms.TextBox hoursTraveledTextBox;
		private System.Windows.Forms.ListBox distanceListBox;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Button exitButton;
	}
}

