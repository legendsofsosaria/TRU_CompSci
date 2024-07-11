namespace BMI_Index_Program
{
	partial class bmiCalculator
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
			this.calculatorLabel = new System.Windows.Forms.Label();
			this.weightTextLabel = new System.Windows.Forms.Label();
			this.heightTextLabel = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.bmiLabel = new System.Windows.Forms.Label();
			this.bmiTextBox = new System.Windows.Forms.Label();
			this.heightTextBox = new System.Windows.Forms.TextBox();
			this.weightTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// calculatorLabel
			// 
			this.calculatorLabel.AutoSize = true;
			this.calculatorLabel.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calculatorLabel.Location = new System.Drawing.Point(69, 28);
			this.calculatorLabel.Name = "calculatorLabel";
			this.calculatorLabel.Size = new System.Drawing.Size(195, 34);
			this.calculatorLabel.TabIndex = 0;
			this.calculatorLabel.Text = "BMI Calculator";
			// 
			// weightTextLabel
			// 
			this.weightTextLabel.AutoSize = true;
			this.weightTextLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weightTextLabel.Location = new System.Drawing.Point(21, 87);
			this.weightTextLabel.Name = "weightTextLabel";
			this.weightTextLabel.Size = new System.Drawing.Size(164, 19);
			this.weightTextLabel.TabIndex = 1;
			this.weightTextLabel.Text = "Enter your weight (lbs):";
			// 
			// heightTextLabel
			// 
			this.heightTextLabel.AutoSize = true;
			this.heightTextLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.heightTextLabel.Location = new System.Drawing.Point(21, 126);
			this.heightTextLabel.Name = "heightTextLabel";
			this.heightTextLabel.Size = new System.Drawing.Size(154, 19);
			this.heightTextLabel.TabIndex = 2;
			this.heightTextLabel.Text = "Enter your height (in):";
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(25, 213);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(85, 34);
			this.calculateButton.TabIndex = 0;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(211, 213);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(89, 34);
			this.exitButton.TabIndex = 5;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(116, 213);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(87, 34);
			this.clearButton.TabIndex = 6;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// bmiLabel
			// 
			this.bmiLabel.AutoSize = true;
			this.bmiLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bmiLabel.Location = new System.Drawing.Point(21, 162);
			this.bmiLabel.Name = "bmiLabel";
			this.bmiLabel.Size = new System.Drawing.Size(84, 19);
			this.bmiLabel.TabIndex = 7;
			this.bmiLabel.Text = "Your BMI: ";
			// 
			// bmiTextBox
			// 
			this.bmiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.bmiTextBox.Location = new System.Drawing.Point(211, 158);
			this.bmiTextBox.Name = "bmiTextBox";
			this.bmiTextBox.Size = new System.Drawing.Size(55, 28);
			this.bmiTextBox.TabIndex = 8;
			this.bmiTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// heightTextBox
			// 
			this.heightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.heightTextBox.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.heightTextBox.Location = new System.Drawing.Point(211, 125);
			this.heightTextBox.Name = "heightTextBox";
			this.heightTextBox.Size = new System.Drawing.Size(55, 20);
			this.heightTextBox.TabIndex = 9;
			this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// weightTextBox
			// 
			this.weightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.weightTextBox.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weightTextBox.Location = new System.Drawing.Point(211, 86);
			this.weightTextBox.Name = "weightTextBox";
			this.weightTextBox.Size = new System.Drawing.Size(55, 20);
			this.weightTextBox.TabIndex = 10;
			this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bmiCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 259);
			this.Controls.Add(this.weightTextBox);
			this.Controls.Add(this.heightTextBox);
			this.Controls.Add(this.bmiTextBox);
			this.Controls.Add(this.bmiLabel);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.heightTextLabel);
			this.Controls.Add(this.weightTextLabel);
			this.Controls.Add(this.calculatorLabel);
			this.Name = "bmiCalculator";
			this.Text = "BMI Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label calculatorLabel;
		private System.Windows.Forms.Label weightTextLabel;
		private System.Windows.Forms.Label heightTextLabel;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Label bmiLabel;
		private System.Windows.Forms.Label bmiTextBox;
		private System.Windows.Forms.TextBox heightTextBox;
		private System.Windows.Forms.TextBox weightTextBox;
	}
}

