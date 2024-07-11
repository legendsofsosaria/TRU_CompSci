namespace ColorTheme
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
			this.colorGroupBox = new System.Windows.Forms.Label();
			this.yellowRadioButton = new System.Windows.Forms.RadioButton();
			this.redRadioButton = new System.Windows.Forms.RadioButton();
			this.whiteRadioButton = new System.Windows.Forms.RadioButton();
			this.normalRadioButton = new System.Windows.Forms.RadioButton();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// colorGroupBox
			// 
			this.colorGroupBox.AutoSize = true;
			this.colorGroupBox.Location = new System.Drawing.Point(41, 30);
			this.colorGroupBox.Name = "colorGroupBox";
			this.colorGroupBox.Size = new System.Drawing.Size(167, 16);
			this.colorGroupBox.TabIndex = 0;
			this.colorGroupBox.Text = "Select a Background Color";
			// 
			// yellowRadioButton
			// 
			this.yellowRadioButton.AutoSize = true;
			this.yellowRadioButton.Location = new System.Drawing.Point(88, 68);
			this.yellowRadioButton.Name = "yellowRadioButton";
			this.yellowRadioButton.Size = new System.Drawing.Size(68, 20);
			this.yellowRadioButton.TabIndex = 1;
			this.yellowRadioButton.TabStop = true;
			this.yellowRadioButton.Text = "Yellow";
			this.yellowRadioButton.UseVisualStyleBackColor = true;
			this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
			// 
			// redRadioButton
			// 
			this.redRadioButton.AutoSize = true;
			this.redRadioButton.Location = new System.Drawing.Point(88, 94);
			this.redRadioButton.Name = "redRadioButton";
			this.redRadioButton.Size = new System.Drawing.Size(54, 20);
			this.redRadioButton.TabIndex = 2;
			this.redRadioButton.TabStop = true;
			this.redRadioButton.Text = "Red";
			this.redRadioButton.UseVisualStyleBackColor = true;
			this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
			// 
			// whiteRadioButton
			// 
			this.whiteRadioButton.AutoSize = true;
			this.whiteRadioButton.Location = new System.Drawing.Point(88, 120);
			this.whiteRadioButton.Name = "whiteRadioButton";
			this.whiteRadioButton.Size = new System.Drawing.Size(62, 20);
			this.whiteRadioButton.TabIndex = 3;
			this.whiteRadioButton.TabStop = true;
			this.whiteRadioButton.Text = "White";
			this.whiteRadioButton.UseVisualStyleBackColor = true;
			this.whiteRadioButton.CheckedChanged += new System.EventHandler(this.whiteRadioButton_CheckedChanged);
			// 
			// normalRadioButton
			// 
			this.normalRadioButton.AutoSize = true;
			this.normalRadioButton.Location = new System.Drawing.Point(88, 146);
			this.normalRadioButton.Name = "normalRadioButton";
			this.normalRadioButton.Size = new System.Drawing.Size(120, 20);
			this.normalRadioButton.TabIndex = 4;
			this.normalRadioButton.TabStop = true;
			this.normalRadioButton.Text = "Back to Normal";
			this.normalRadioButton.UseVisualStyleBackColor = true;
			this.normalRadioButton.CheckedChanged += new System.EventHandler(this.normalRadioButton_CheckedChanged);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(109, 200);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 5;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 253);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.normalRadioButton);
			this.Controls.Add(this.whiteRadioButton);
			this.Controls.Add(this.redRadioButton);
			this.Controls.Add(this.yellowRadioButton);
			this.Controls.Add(this.colorGroupBox);
			this.Name = "Form1";
			this.Text = "Color Theme";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label colorGroupBox;
		private System.Windows.Forms.RadioButton yellowRadioButton;
		private System.Windows.Forms.RadioButton redRadioButton;
		private System.Windows.Forms.RadioButton whiteRadioButton;
		private System.Windows.Forms.RadioButton normalRadioButton;
		private System.Windows.Forms.Button exitButton;
	}
}

