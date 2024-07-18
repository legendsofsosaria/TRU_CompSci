namespace Addition_Tutor
{
	partial class AdditionTutor
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
			this.integerOne = new System.Windows.Forms.Label();
			this.additionLabel = new System.Windows.Forms.Label();
			this.integerTwo = new System.Windows.Forms.Label();
			this.answerTextBox = new System.Windows.Forms.TextBox();
			this.equalsLabel = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// integerOne
			// 
			this.integerOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.integerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.integerOne.Location = new System.Drawing.Point(12, 23);
			this.integerOne.Name = "integerOne";
			this.integerOne.Size = new System.Drawing.Size(55, 30);
			this.integerOne.TabIndex = 0;
			// 
			// additionLabel
			// 
			this.additionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.additionLabel.Location = new System.Drawing.Point(73, 27);
			this.additionLabel.Name = "additionLabel";
			this.additionLabel.Size = new System.Drawing.Size(19, 24);
			this.additionLabel.TabIndex = 1;
			this.additionLabel.Text = "+";
			// 
			// integerTwo
			// 
			this.integerTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.integerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.integerTwo.Location = new System.Drawing.Point(98, 23);
			this.integerTwo.Name = "integerTwo";
			this.integerTwo.Size = new System.Drawing.Size(55, 30);
			this.integerTwo.TabIndex = 2;
			// 
			// answerTextBox
			// 
			this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.answerTextBox.Location = new System.Drawing.Point(181, 24);
			this.answerTextBox.Name = "answerTextBox";
			this.answerTextBox.Size = new System.Drawing.Size(47, 27);
			this.answerTextBox.TabIndex = 3;
			// 
			// equalsLabel
			// 
			this.equalsLabel.AutoSize = true;
			this.equalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equalsLabel.Location = new System.Drawing.Point(156, 24);
			this.equalsLabel.Name = "equalsLabel";
			this.equalsLabel.Size = new System.Drawing.Size(19, 20);
			this.equalsLabel.TabIndex = 4;
			this.equalsLabel.Text = "=";
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(50, 75);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 30);
			this.submitButton.TabIndex = 5;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(131, 75);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 30);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// AdditionTutor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 125);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.equalsLabel);
			this.Controls.Add(this.answerTextBox);
			this.Controls.Add(this.integerTwo);
			this.Controls.Add(this.additionLabel);
			this.Controls.Add(this.integerOne);
			this.Name = "AdditionTutor";
			this.Text = "Addition Tutor";
			this.Load += new System.EventHandler(this.AdditionTutor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label integerOne;
		private System.Windows.Forms.Label additionLabel;
		private System.Windows.Forms.Label integerTwo;
		private System.Windows.Forms.TextBox answerTextBox;
		private System.Windows.Forms.Label equalsLabel;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Button exitButton;
	}
}

