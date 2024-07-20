namespace Fat_Percentage_Calculator
{
	partial class FatCarbCalculator
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
			this.fatCalculatorLabel = new System.Windows.Forms.Label();
			this.gramsFatLabel = new System.Windows.Forms.Label();
			this.gramsCarbsLabel = new System.Windows.Forms.Label();
			this.caloriesFatLabel = new System.Windows.Forms.Label();
			this.caloriesCarbsLabel = new System.Windows.Forms.Label();
			this.calculateButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.gramsFatTextBox = new System.Windows.Forms.TextBox();
			this.gramsCarbsTextBox = new System.Windows.Forms.TextBox();
			this.caloriesCarbsTextBox = new System.Windows.Forms.Label();
			this.caloriesFatTextBox = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// fatCalculatorLabel
			// 
			this.fatCalculatorLabel.AutoSize = true;
			this.fatCalculatorLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fatCalculatorLabel.Location = new System.Drawing.Point(118, 21);
			this.fatCalculatorLabel.Name = "fatCalculatorLabel";
			this.fatCalculatorLabel.Size = new System.Drawing.Size(243, 26);
			this.fatCalculatorLabel.TabIndex = 0;
			this.fatCalculatorLabel.Text = "Fat Percentage Calculator";
			// 
			// gramsFatLabel
			// 
			this.gramsFatLabel.AutoSize = true;
			this.gramsFatLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gramsFatLabel.Location = new System.Drawing.Point(39, 66);
			this.gramsFatLabel.Name = "gramsFatLabel";
			this.gramsFatLabel.Size = new System.Drawing.Size(180, 19);
			this.gramsFatLabel.TabIndex = 1;
			this.gramsFatLabel.Text = "Number of Grams of Fat:";
			// 
			// gramsCarbsLabel
			// 
			this.gramsCarbsLabel.AutoSize = true;
			this.gramsCarbsLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gramsCarbsLabel.Location = new System.Drawing.Point(40, 98);
			this.gramsCarbsLabel.Name = "gramsCarbsLabel";
			this.gramsCarbsLabel.Size = new System.Drawing.Size(197, 19);
			this.gramsCarbsLabel.TabIndex = 2;
			this.gramsCarbsLabel.Text = "Number of Grams of Carbs:";
			// 
			// caloriesFatLabel
			// 
			this.caloriesFatLabel.AutoSize = true;
			this.caloriesFatLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caloriesFatLabel.Location = new System.Drawing.Point(39, 134);
			this.caloriesFatLabel.Name = "caloriesFatLabel";
			this.caloriesFatLabel.Size = new System.Drawing.Size(135, 19);
			this.caloriesFatLabel.TabIndex = 3;
			this.caloriesFatLabel.Text = "Calories From Fat:";
			// 
			// caloriesCarbsLabel
			// 
			this.caloriesCarbsLabel.AutoSize = true;
			this.caloriesCarbsLabel.Cursor = System.Windows.Forms.Cursors.Cross;
			this.caloriesCarbsLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caloriesCarbsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.caloriesCarbsLabel.Location = new System.Drawing.Point(39, 169);
			this.caloriesCarbsLabel.Name = "caloriesCarbsLabel";
			this.caloriesCarbsLabel.Size = new System.Drawing.Size(152, 19);
			this.caloriesCarbsLabel.TabIndex = 4;
			this.caloriesCarbsLabel.Text = "Calories From Carbs:";
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(32, 216);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(88, 32);
			this.calculateButton.TabIndex = 5;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(202, 216);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(92, 32);
			this.clearButton.TabIndex = 6;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(373, 216);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(89, 32);
			this.exitButton.TabIndex = 7;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// gramsFatTextBox
			// 
			this.gramsFatTextBox.Location = new System.Drawing.Point(298, 63);
			this.gramsFatTextBox.Name = "gramsFatTextBox";
			this.gramsFatTextBox.Size = new System.Drawing.Size(100, 22);
			this.gramsFatTextBox.TabIndex = 8;
			// 
			// gramsCarbsTextBox
			// 
			this.gramsCarbsTextBox.Location = new System.Drawing.Point(298, 95);
			this.gramsCarbsTextBox.Name = "gramsCarbsTextBox";
			this.gramsCarbsTextBox.Size = new System.Drawing.Size(100, 22);
			this.gramsCarbsTextBox.TabIndex = 9;
			// 
			// caloriesCarbsTextBox
			// 
			this.caloriesCarbsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.caloriesCarbsTextBox.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caloriesCarbsTextBox.Location = new System.Drawing.Point(298, 167);
			this.caloriesCarbsTextBox.Name = "caloriesCarbsTextBox";
			this.caloriesCarbsTextBox.Size = new System.Drawing.Size(100, 23);
			this.caloriesCarbsTextBox.TabIndex = 11;
			this.caloriesCarbsTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// caloriesFatTextBox
			// 
			this.caloriesFatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.caloriesFatTextBox.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caloriesFatTextBox.Location = new System.Drawing.Point(298, 134);
			this.caloriesFatTextBox.Name = "caloriesFatTextBox";
			this.caloriesFatTextBox.Size = new System.Drawing.Size(100, 23);
			this.caloriesFatTextBox.TabIndex = 12;
			this.caloriesFatTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FatCarbCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 291);
			this.Controls.Add(this.caloriesFatTextBox);
			this.Controls.Add(this.caloriesCarbsTextBox);
			this.Controls.Add(this.gramsCarbsTextBox);
			this.Controls.Add(this.gramsFatTextBox);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.caloriesCarbsLabel);
			this.Controls.Add(this.caloriesFatLabel);
			this.Controls.Add(this.gramsCarbsLabel);
			this.Controls.Add(this.gramsFatLabel);
			this.Controls.Add(this.fatCalculatorLabel);
			this.Name = "FatCarbCalculator";
			this.Text = "Fat and Carb Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label fatCalculatorLabel;
		private System.Windows.Forms.Label gramsFatLabel;
		private System.Windows.Forms.Label caloriesFatLabel;
		private System.Windows.Forms.Label caloriesCarbsLabel;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.TextBox gramsFatTextBox;
		private System.Windows.Forms.TextBox gramsCarbsTextBox;
		private System.Windows.Forms.Label caloriesCarbsTextBox;
		private System.Windows.Forms.Label caloriesFatTextBox;
		private System.Windows.Forms.Label gramsCarbsLabel;
	}
}

