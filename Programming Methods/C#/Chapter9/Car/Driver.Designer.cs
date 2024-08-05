namespace Car
{
	partial class Driver
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
			this.speed = new System.Windows.Forms.Label();
			this.accelerateButton = new System.Windows.Forms.Button();
			this.brakeButton = new System.Windows.Forms.Button();
			this.speedLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// speed
			// 
			this.speed.AutoSize = true;
			this.speed.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.speed.Location = new System.Drawing.Point(75, 34);
			this.speed.Name = "speed";
			this.speed.Size = new System.Drawing.Size(55, 20);
			this.speed.TabIndex = 0;
			this.speed.Text = "Speed";
			// 
			// accelerateButton
			// 
			this.accelerateButton.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.accelerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.accelerateButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.accelerateButton.Location = new System.Drawing.Point(50, 86);
			this.accelerateButton.Name = "accelerateButton";
			this.accelerateButton.Size = new System.Drawing.Size(105, 40);
			this.accelerateButton.TabIndex = 1;
			this.accelerateButton.Text = "Accelerate";
			this.accelerateButton.UseVisualStyleBackColor = false;
			this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
			// 
			// brakeButton
			// 
			this.brakeButton.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.brakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.brakeButton.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.brakeButton.Location = new System.Drawing.Point(178, 86);
			this.brakeButton.Name = "brakeButton";
			this.brakeButton.Size = new System.Drawing.Size(105, 40);
			this.brakeButton.TabIndex = 2;
			this.brakeButton.Text = "Brake";
			this.brakeButton.UseVisualStyleBackColor = false;
			this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
			// 
			// speedLabel
			// 
			this.speedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.speedLabel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.speedLabel.Location = new System.Drawing.Point(136, 33);
			this.speedLabel.Name = "speedLabel";
			this.speedLabel.Size = new System.Drawing.Size(121, 28);
			this.speedLabel.TabIndex = 3;
			// 
			// Driver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 162);
			this.Controls.Add(this.speedLabel);
			this.Controls.Add(this.brakeButton);
			this.Controls.Add(this.accelerateButton);
			this.Controls.Add(this.speed);
			this.Name = "Driver";
			this.Text = "Drive";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label speed;
		private System.Windows.Forms.Button accelerateButton;
		private System.Windows.Forms.Button brakeButton;
		public System.Windows.Forms.Label speedLabel;
	}
}

