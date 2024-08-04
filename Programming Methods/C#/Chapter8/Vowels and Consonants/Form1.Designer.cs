namespace Vowels_and_Consonants
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.vowelTextBox = new System.Windows.Forms.Label();
			this.consonantTextBox = new System.Windows.Forms.Label();
			this.stringTextBox = new System.Windows.Forms.TextBox();
			this.countButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(41, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number of Vowels:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(41, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Number of Consonants:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(41, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Enter a String:";
			// 
			// vowelTextBox
			// 
			this.vowelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.vowelTextBox.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vowelTextBox.Location = new System.Drawing.Point(241, 75);
			this.vowelTextBox.Name = "vowelTextBox";
			this.vowelTextBox.Size = new System.Drawing.Size(50, 30);
			this.vowelTextBox.TabIndex = 4;
			this.vowelTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// consonantTextBox
			// 
			this.consonantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.consonantTextBox.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.consonantTextBox.Location = new System.Drawing.Point(241, 117);
			this.consonantTextBox.Name = "consonantTextBox";
			this.consonantTextBox.Size = new System.Drawing.Size(50, 30);
			this.consonantTextBox.TabIndex = 5;
			this.consonantTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// stringTextBox
			// 
			this.stringTextBox.Location = new System.Drawing.Point(241, 40);
			this.stringTextBox.Name = "stringTextBox";
			this.stringTextBox.Size = new System.Drawing.Size(209, 22);
			this.stringTextBox.TabIndex = 6;
			// 
			// countButton
			// 
			this.countButton.BackColor = System.Drawing.SystemColors.Control;
			this.countButton.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countButton.Location = new System.Drawing.Point(120, 177);
			this.countButton.Name = "countButton";
			this.countButton.Size = new System.Drawing.Size(98, 39);
			this.countButton.TabIndex = 7;
			this.countButton.Text = "Count";
			this.countButton.UseVisualStyleBackColor = false;
			this.countButton.Click += new System.EventHandler(this.countButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.SystemColors.Control;
			this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.exitButton.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(241, 177);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(98, 39);
			this.exitButton.TabIndex = 8;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 252);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.countButton);
			this.Controls.Add(this.stringTextBox);
			this.Controls.Add(this.consonantTextBox);
			this.Controls.Add(this.vowelTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Vowels and Consonants";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label vowelTextBox;
		private System.Windows.Forms.Label consonantTextBox;
		private System.Windows.Forms.TextBox stringTextBox;
		private System.Windows.Forms.Button countButton;
		private System.Windows.Forms.Button exitButton;
	}
}

