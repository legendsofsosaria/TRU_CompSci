namespace My_First_Project
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
			this.readInputButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.enteredLabel = new System.Windows.Forms.Label();
			this.outputLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// readInputButton
			// 
			this.readInputButton.BackColor = System.Drawing.Color.LightSteelBlue;
			this.readInputButton.Location = new System.Drawing.Point(55, 240);
			this.readInputButton.Name = "readInputButton";
			this.readInputButton.Size = new System.Drawing.Size(95, 35);
			this.readInputButton.TabIndex = 0;
			this.readInputButton.Text = "Read Input";
			this.readInputButton.UseVisualStyleBackColor = false;
			this.readInputButton.Click += new System.EventHandler(this.readInputButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.Color.LightSteelBlue;
			this.exitButton.Location = new System.Drawing.Point(253, 240);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(95, 35);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.ForeColor = System.Drawing.SystemColors.Desktop;
			this.nameLabel.Location = new System.Drawing.Point(70, 76);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(107, 16);
			this.nameLabel.TabIndex = 2;
			this.nameLabel.Text = "Enter your name:";
			this.nameLabel.Click += new System.EventHandler(this.outputLabel_Click);
			// 
			// enteredLabel
			// 
			this.enteredLabel.AutoSize = true;
			this.enteredLabel.ForeColor = System.Drawing.SystemColors.Desktop;
			this.enteredLabel.Location = new System.Drawing.Point(70, 121);
			this.enteredLabel.Name = "enteredLabel";
			this.enteredLabel.Size = new System.Drawing.Size(83, 16);
			this.enteredLabel.TabIndex = 3;
			this.enteredLabel.Text = "You entered:";
			// 
			// outputLabel
			// 
			this.outputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.outputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.outputLabel.Location = new System.Drawing.Point(192, 115);
			this.outputLabel.Name = "outputLabel";
			this.outputLabel.Size = new System.Drawing.Size(140, 22);
			this.outputLabel.TabIndex = 4;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(192, 70);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(140, 22);
			this.nameTextBox.TabIndex = 5;
			this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(420, 338);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.outputLabel);
			this.Controls.Add(this.enteredLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.readInputButton);
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Name = "Form1";
			this.Text = "My First Program";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button readInputButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label enteredLabel;
		private System.Windows.Forms.Label outputLabel;
		private System.Windows.Forms.TextBox nameTextBox;
	}
}

