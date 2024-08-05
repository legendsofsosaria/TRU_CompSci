namespace Car
{
	partial class CarForm
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
			this.driveButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.yearLabel = new System.Windows.Forms.Label();
			this.makeLabel = new System.Windows.Forms.Label();
			this.yearTextBox = new System.Windows.Forms.TextBox();
			this.makeTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// driveButton
			// 
			this.driveButton.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.driveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.driveButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.driveButton.Location = new System.Drawing.Point(47, 107);
			this.driveButton.Name = "driveButton";
			this.driveButton.Size = new System.Drawing.Size(105, 40);
			this.driveButton.TabIndex = 3;
			this.driveButton.Text = "Drive";
			this.driveButton.UseVisualStyleBackColor = false;
			this.driveButton.Click += new System.EventHandler(this.driveButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(192, 107);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(105, 40);
			this.exitButton.TabIndex = 4;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// yearLabel
			// 
			this.yearLabel.AutoSize = true;
			this.yearLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yearLabel.Location = new System.Drawing.Point(71, 22);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size(43, 20);
			this.yearLabel.TabIndex = 5;
			this.yearLabel.Text = "Year";
			// 
			// makeLabel
			// 
			this.makeLabel.AutoSize = true;
			this.makeLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.makeLabel.Location = new System.Drawing.Point(71, 66);
			this.makeLabel.Name = "makeLabel";
			this.makeLabel.Size = new System.Drawing.Size(51, 20);
			this.makeLabel.TabIndex = 6;
			this.makeLabel.Text = "Make";
			// 
			// yearTextBox
			// 
			this.yearTextBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.yearTextBox.Location = new System.Drawing.Point(166, 20);
			this.yearTextBox.Name = "yearTextBox";
			this.yearTextBox.Size = new System.Drawing.Size(116, 25);
			this.yearTextBox.TabIndex = 7;
			// 
			// makeTextBox
			// 
			this.makeTextBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.makeTextBox.Location = new System.Drawing.Point(166, 64);
			this.makeTextBox.Name = "makeTextBox";
			this.makeTextBox.Size = new System.Drawing.Size(116, 25);
			this.makeTextBox.TabIndex = 8;
			// 
			// CarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 182);
			this.Controls.Add(this.makeTextBox);
			this.Controls.Add(this.yearTextBox);
			this.Controls.Add(this.makeLabel);
			this.Controls.Add(this.yearLabel);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.driveButton);
			this.Name = "CarForm";
			this.Text = "Car";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button driveButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.Label makeLabel;
		private System.Windows.Forms.TextBox yearTextBox;
		private System.Windows.Forms.TextBox makeTextBox;
	}
}