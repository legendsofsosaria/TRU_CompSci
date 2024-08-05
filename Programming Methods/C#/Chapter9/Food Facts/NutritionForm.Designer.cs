namespace Food_Facts
{
	partial class NutritionForm
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
			this.food = new System.Windows.Forms.Label();
			this.calories = new System.Windows.Forms.Label();
			this.fatGrams = new System.Windows.Forms.Label();
			this.carbGrams = new System.Windows.Forms.Label();
			this.foodLabel = new System.Windows.Forms.Label();
			this.caloriesLabel = new System.Windows.Forms.Label();
			this.fatLabel = new System.Windows.Forms.Label();
			this.carbLabel = new System.Windows.Forms.Label();
			this.closeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// food
			// 
			this.food.AutoSize = true;
			this.food.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.food.Location = new System.Drawing.Point(37, 43);
			this.food.Name = "food";
			this.food.Size = new System.Drawing.Size(46, 19);
			this.food.TabIndex = 0;
			this.food.Text = "Food";
			// 
			// calories
			// 
			this.calories.AutoSize = true;
			this.calories.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calories.Location = new System.Drawing.Point(37, 95);
			this.calories.Name = "calories";
			this.calories.Size = new System.Drawing.Size(63, 19);
			this.calories.TabIndex = 1;
			this.calories.Text = "Calories";
			// 
			// fatGrams
			// 
			this.fatGrams.AutoSize = true;
			this.fatGrams.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fatGrams.Location = new System.Drawing.Point(37, 147);
			this.fatGrams.Name = "fatGrams";
			this.fatGrams.Size = new System.Drawing.Size(80, 19);
			this.fatGrams.TabIndex = 2;
			this.fatGrams.Text = "Fat Grams";
			// 
			// carbGrams
			// 
			this.carbGrams.AutoSize = true;
			this.carbGrams.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carbGrams.Location = new System.Drawing.Point(37, 197);
			this.carbGrams.Name = "carbGrams";
			this.carbGrams.Size = new System.Drawing.Size(91, 19);
			this.carbGrams.TabIndex = 3;
			this.carbGrams.Text = "Carb Grams";
			// 
			// foodLabel
			// 
			this.foodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.foodLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.foodLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.foodLabel.Location = new System.Drawing.Point(147, 32);
			this.foodLabel.Name = "foodLabel";
			this.foodLabel.Size = new System.Drawing.Size(212, 30);
			this.foodLabel.TabIndex = 4;
			// 
			// caloriesLabel
			// 
			this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.caloriesLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.caloriesLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caloriesLabel.Location = new System.Drawing.Point(147, 84);
			this.caloriesLabel.Name = "caloriesLabel";
			this.caloriesLabel.Size = new System.Drawing.Size(212, 30);
			this.caloriesLabel.TabIndex = 5;
			// 
			// fatLabel
			// 
			this.fatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fatLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.fatLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fatLabel.Location = new System.Drawing.Point(147, 136);
			this.fatLabel.Name = "fatLabel";
			this.fatLabel.Size = new System.Drawing.Size(212, 30);
			this.fatLabel.TabIndex = 6;
			// 
			// carbLabel
			// 
			this.carbLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.carbLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.carbLabel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.carbLabel.Location = new System.Drawing.Point(147, 186);
			this.carbLabel.Name = "carbLabel";
			this.carbLabel.Size = new System.Drawing.Size(212, 30);
			this.carbLabel.TabIndex = 7;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.Location = new System.Drawing.Point(110, 249);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(90, 32);
			this.closeButton.TabIndex = 8;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// NutritionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 316);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.carbLabel);
			this.Controls.Add(this.fatLabel);
			this.Controls.Add(this.caloriesLabel);
			this.Controls.Add(this.foodLabel);
			this.Controls.Add(this.carbGrams);
			this.Controls.Add(this.fatGrams);
			this.Controls.Add(this.calories);
			this.Controls.Add(this.food);
			this.Name = "NutritionForm";
			this.Text = "Nutrition Info";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label food;
		private System.Windows.Forms.Label calories;
		private System.Windows.Forms.Label fatGrams;
		private System.Windows.Forms.Label carbGrams;
		private System.Windows.Forms.Button closeButton;
		public System.Windows.Forms.Label foodLabel;
		public System.Windows.Forms.Label caloriesLabel;
		public System.Windows.Forms.Label fatLabel;
		public System.Windows.Forms.Label carbLabel;
	}
}