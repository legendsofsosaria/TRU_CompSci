namespace Food_Facts
{
	partial class MainForm
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
			this.bananaRadioButton = new System.Windows.Forms.RadioButton();
			this.popcornRadioButton = new System.Windows.Forms.RadioButton();
			this.muffinRadioButton = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.displayButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bananaRadioButton
			// 
			this.bananaRadioButton.AutoSize = true;
			this.bananaRadioButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bananaRadioButton.Location = new System.Drawing.Point(31, 21);
			this.bananaRadioButton.Name = "bananaRadioButton";
			this.bananaRadioButton.Size = new System.Drawing.Size(90, 22);
			this.bananaRadioButton.TabIndex = 1;
			this.bananaRadioButton.TabStop = true;
			this.bananaRadioButton.Text = "1 banana";
			this.bananaRadioButton.UseVisualStyleBackColor = true;
			// 
			// popcornRadioButton
			// 
			this.popcornRadioButton.AutoSize = true;
			this.popcornRadioButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.popcornRadioButton.Location = new System.Drawing.Point(31, 77);
			this.popcornRadioButton.Name = "popcornRadioButton";
			this.popcornRadioButton.Size = new System.Drawing.Size(214, 22);
			this.popcornRadioButton.TabIndex = 2;
			this.popcornRadioButton.TabStop = true;
			this.popcornRadioButton.Text = "1 cup of air-popped popcorn";
			this.popcornRadioButton.UseVisualStyleBackColor = true;
			// 
			// muffinRadioButton
			// 
			this.muffinRadioButton.AutoSize = true;
			this.muffinRadioButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.muffinRadioButton.Location = new System.Drawing.Point(31, 49);
			this.muffinRadioButton.Name = "muffinRadioButton";
			this.muffinRadioButton.Size = new System.Drawing.Size(190, 22);
			this.muffinRadioButton.TabIndex = 3;
			this.muffinRadioButton.TabStop = true;
			this.muffinRadioButton.Text = "1 large blueberry muffin";
			this.muffinRadioButton.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.bananaRadioButton);
			this.groupBox1.Controls.Add(this.popcornRadioButton);
			this.groupBox1.Controls.Add(this.muffinRadioButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(282, 127);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select a Food";
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Garamond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(155, 154);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(90, 50);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// displayButton
			// 
			this.displayButton.BackColor = System.Drawing.SystemColors.ControlLight;
			this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.displayButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.displayButton.Location = new System.Drawing.Point(43, 154);
			this.displayButton.Name = "displayButton";
			this.displayButton.Size = new System.Drawing.Size(90, 50);
			this.displayButton.TabIndex = 10;
			this.displayButton.Text = "Display Food Facts";
			this.displayButton.UseVisualStyleBackColor = false;
			this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 223);
			this.Controls.Add(this.displayButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Food Facts";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RadioButton bananaRadioButton;
		private System.Windows.Forms.RadioButton popcornRadioButton;
		private System.Windows.Forms.RadioButton muffinRadioButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button displayButton;
	}
}

