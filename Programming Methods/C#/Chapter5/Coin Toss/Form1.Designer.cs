namespace Coin_Toss
{
	partial class CoinToss
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinToss));
			this.headsPictureBox = new System.Windows.Forms.PictureBox();
			this.tailsPictureBox = new System.Windows.Forms.PictureBox();
			this.tossButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// headsPictureBox
			// 
			this.headsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("headsPictureBox.Image")));
			this.headsPictureBox.InitialImage = null;
			this.headsPictureBox.Location = new System.Drawing.Point(33, 28);
			this.headsPictureBox.Name = "headsPictureBox";
			this.headsPictureBox.Size = new System.Drawing.Size(170, 170);
			this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.headsPictureBox.TabIndex = 0;
			this.headsPictureBox.TabStop = false;
			// 
			// tailsPictureBox
			// 
			this.tailsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tailsPictureBox.Image")));
			this.tailsPictureBox.Location = new System.Drawing.Point(33, 28);
			this.tailsPictureBox.Name = "tailsPictureBox";
			this.tailsPictureBox.Size = new System.Drawing.Size(170, 170);
			this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.tailsPictureBox.TabIndex = 1;
			this.tailsPictureBox.TabStop = false;
			this.tailsPictureBox.Visible = false;
			// 
			// tossButton
			// 
			this.tossButton.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.tossButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.tossButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tossButton.Location = new System.Drawing.Point(12, 217);
			this.tossButton.Name = "tossButton";
			this.tossButton.Size = new System.Drawing.Size(105, 30);
			this.tossButton.TabIndex = 2;
			this.tossButton.Text = "Toss";
			this.tossButton.UseVisualStyleBackColor = false;
			this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.exitButton.Location = new System.Drawing.Point(123, 217);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(105, 30);
			this.exitButton.TabIndex = 3;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// CoinToss
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(242, 282);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.tossButton);
			this.Controls.Add(this.tailsPictureBox);
			this.Controls.Add(this.headsPictureBox);
			this.Name = "CoinToss";
			this.Text = "Coin Toss";
			((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox headsPictureBox;
		private System.Windows.Forms.PictureBox tailsPictureBox;
		private System.Windows.Forms.Button tossButton;
		private System.Windows.Forms.Button exitButton;
	}
}

