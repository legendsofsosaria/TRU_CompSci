namespace Fat_Percentage_Calculator
{
	partial class FatPercentageCalculator
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
			this.caloriesLabel = new System.Windows.Forms.Label();
			this.fatGramsLabel = new System.Windows.Forms.Label();
			this.caloriesFatLabel = new System.Windows.Forms.Label();
			this.fatPercentLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.caloriesTextBox = new System.Windows.Forms.TextBox();
			this.fatGramsTextBox = new System.Windows.Forms.TextBox();
			this.fatPercentTextBox = new System.Windows.Forms.Label();
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
			// caloriesLabel
			// 
			this.caloriesLabel.AutoSize = true;
			this.caloriesLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caloriesLabel.Location = new System.Drawing.Point(39, 66);
			this.caloriesLabel.Name = "caloriesLabel";
			this.caloriesLabel.Size = new System.Drawing.Size(145, 19);
			this.caloriesLabel.TabIndex = 1;
			this.caloriesLabel.Text = "Number of Calories:";
			// 
			// fatGramsLabel
			// 
			this.fatGramsLabel.AutoSize = true;
			this.fatGramsLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fatGramsLabel.Location = new System.Drawing.Point(40, 98);
			this.fatGramsLabel.Name = "fatGramsLabel";
			this.fatGramsLabel.Size = new System.Drawing.Size(170, 19);
			this.fatGramsLabel.TabIndex = 2;
			this.fatGramsLabel.Text = "Number of grams of fat:";
			// 
			// caloriesFatLabel
			// 
			this.caloriesFatLabel.AutoSize = true;
			this.caloriesFatLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caloriesFatLabel.Location = new System.Drawing.Point(39, 134);
			this.caloriesFatLabel.Name = "caloriesFatLabel";
			this.caloriesFatLabel.Size = new System.Drawing.Size(213, 19);
			this.caloriesFatLabel.TabIndex = 3;
			this.caloriesFatLabel.Text = "Number of Calories From Fat:";
			// 
			// fatPercentLabel
			// 
			this.fatPercentLabel.AutoSize = true;
			this.fatPercentLabel.Cursor = System.Windows.Forms.Cursors.Cross;
			this.fatPercentLabel.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fatPercentLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fatPercentLabel.Location = new System.Drawing.Point(39, 169);
			this.fatPercentLabel.Name = "fatPercentLabel";
			this.fatPercentLabel.Size = new System.Drawing.Size(229, 19);
			this.fatPercentLabel.TabIndex = 4;
			this.fatPercentLabel.Text = "Percentage of Calories From Fat:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 216);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 32);
			this.button1.TabIndex = 5;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(202, 216);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 32);
			this.button2.TabIndex = 6;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(373, 216);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(89, 32);
			this.button3.TabIndex = 7;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// caloriesTextBox
			// 
			this.caloriesTextBox.Location = new System.Drawing.Point(298, 63);
			this.caloriesTextBox.Name = "caloriesTextBox";
			this.caloriesTextBox.Size = new System.Drawing.Size(100, 22);
			this.caloriesTextBox.TabIndex = 8;
			// 
			// fatGramsTextBox
			// 
			this.fatGramsTextBox.Location = new System.Drawing.Point(298, 95);
			this.fatGramsTextBox.Name = "fatGramsTextBox";
			this.fatGramsTextBox.Size = new System.Drawing.Size(100, 22);
			this.fatGramsTextBox.TabIndex = 9;
			// 
			// fatPercentTextBox
			// 
			this.fatPercentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fatPercentTextBox.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fatPercentTextBox.Location = new System.Drawing.Point(298, 167);
			this.fatPercentTextBox.Name = "fatPercentTextBox";
			this.fatPercentTextBox.Size = new System.Drawing.Size(100, 23);
			this.fatPercentTextBox.TabIndex = 11;
			this.fatPercentTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// FatPercentageCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 291);
			this.Controls.Add(this.caloriesFatTextBox);
			this.Controls.Add(this.fatPercentTextBox);
			this.Controls.Add(this.fatGramsTextBox);
			this.Controls.Add(this.caloriesTextBox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.fatPercentLabel);
			this.Controls.Add(this.caloriesFatLabel);
			this.Controls.Add(this.fatGramsLabel);
			this.Controls.Add(this.caloriesLabel);
			this.Controls.Add(this.fatCalculatorLabel);
			this.Name = "FatPercentageCalculator";
			this.Text = "Fat Percentage Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label fatCalculatorLabel;
		private System.Windows.Forms.Label caloriesLabel;
		private System.Windows.Forms.Label fatGramsLabel;
		private System.Windows.Forms.Label caloriesFatLabel;
		private System.Windows.Forms.Label fatPercentLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox caloriesTextBox;
		private System.Windows.Forms.TextBox fatGramsTextBox;
		private System.Windows.Forms.Label fatPercentTextBox;
		private System.Windows.Forms.Label caloriesFatTextBox;
	}
}

