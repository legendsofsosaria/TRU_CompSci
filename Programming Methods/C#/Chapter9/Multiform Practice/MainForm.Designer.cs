namespace Multiform_Practice
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
			this.exitButton = new System.Windows.Forms.Button();
			this.displayFormButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.exitButton.Location = new System.Drawing.Point(186, 34);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(115, 40);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// displayFormButton
			// 
			this.displayFormButton.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.displayFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.displayFormButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.displayFormButton.Location = new System.Drawing.Point(42, 34);
			this.displayFormButton.Name = "displayFormButton";
			this.displayFormButton.Size = new System.Drawing.Size(115, 40);
			this.displayFormButton.TabIndex = 3;
			this.displayFormButton.Text = "Display Form";
			this.displayFormButton.UseVisualStyleBackColor = false;
			this.displayFormButton.Click += new System.EventHandler(this.displayFormButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(353, 129);
			this.Controls.Add(this.displayFormButton);
			this.Controls.Add(this.exitButton);
			this.Name = "MainForm";
			this.Text = "Multiform Practice";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button displayFormButton;
	}
}

