namespace Production_Worker_App
{
	partial class ProductionWorkerStats
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
			this.employeeName = new System.Windows.Forms.Label();
			this.employeeNum = new System.Windows.Forms.Label();
			this.shiftNum = new System.Windows.Forms.Label();
			this.payRate = new System.Windows.Forms.Label();
			this.employeeNameLabel = new System.Windows.Forms.Label();
			this.employeeNumLabel = new System.Windows.Forms.Label();
			this.shiftNumLabel = new System.Windows.Forms.Label();
			this.payRateLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// employeeName
			// 
			this.employeeName.AutoSize = true;
			this.employeeName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeName.Location = new System.Drawing.Point(47, 45);
			this.employeeName.Name = "employeeName";
			this.employeeName.Size = new System.Drawing.Size(117, 22);
			this.employeeName.TabIndex = 1;
			this.employeeName.Text = "Employee Name";
			// 
			// employeeNum
			// 
			this.employeeNum.AutoSize = true;
			this.employeeNum.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeNum.Location = new System.Drawing.Point(47, 81);
			this.employeeNum.Name = "employeeNum";
			this.employeeNum.Size = new System.Drawing.Size(130, 22);
			this.employeeNum.TabIndex = 4;
			this.employeeNum.Text = "Employee Number";
			// 
			// shiftNum
			// 
			this.shiftNum.AutoSize = true;
			this.shiftNum.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shiftNum.Location = new System.Drawing.Point(47, 117);
			this.shiftNum.Name = "shiftNum";
			this.shiftNum.Size = new System.Drawing.Size(92, 22);
			this.shiftNum.TabIndex = 8;
			this.shiftNum.Text = "Shift Number";
			// 
			// payRate
			// 
			this.payRate.AutoSize = true;
			this.payRate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.payRate.Location = new System.Drawing.Point(47, 152);
			this.payRate.Name = "payRate";
			this.payRate.Size = new System.Drawing.Size(67, 22);
			this.payRate.TabIndex = 9;
			this.payRate.Text = "Pay Rate";
			// 
			// employeeNameLabel
			// 
			this.employeeNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.employeeNameLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeNameLabel.Location = new System.Drawing.Point(236, 44);
			this.employeeNameLabel.Name = "employeeNameLabel";
			this.employeeNameLabel.Size = new System.Drawing.Size(147, 23);
			this.employeeNameLabel.TabIndex = 10;
			// 
			// employeeNumLabel
			// 
			this.employeeNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.employeeNumLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeNumLabel.Location = new System.Drawing.Point(236, 80);
			this.employeeNumLabel.Name = "employeeNumLabel";
			this.employeeNumLabel.Size = new System.Drawing.Size(147, 23);
			this.employeeNumLabel.TabIndex = 11;
			// 
			// shiftNumLabel
			// 
			this.shiftNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.shiftNumLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shiftNumLabel.Location = new System.Drawing.Point(236, 117);
			this.shiftNumLabel.Name = "shiftNumLabel";
			this.shiftNumLabel.Size = new System.Drawing.Size(147, 23);
			this.shiftNumLabel.TabIndex = 12;
			// 
			// payRateLabel
			// 
			this.payRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.payRateLabel.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.payRateLabel.Location = new System.Drawing.Point(236, 152);
			this.payRateLabel.Name = "payRateLabel";
			this.payRateLabel.Size = new System.Drawing.Size(147, 23);
			this.payRateLabel.TabIndex = 13;
			// 
			// ProductionWorkerStats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 234);
			this.Controls.Add(this.payRateLabel);
			this.Controls.Add(this.shiftNumLabel);
			this.Controls.Add(this.employeeNumLabel);
			this.Controls.Add(this.employeeNameLabel);
			this.Controls.Add(this.payRate);
			this.Controls.Add(this.shiftNum);
			this.Controls.Add(this.employeeNum);
			this.Controls.Add(this.employeeName);
			this.Name = "ProductionWorkerStats";
			this.Text = "ProductionWorkerStats";
			this.Load += new System.EventHandler(this.ProductionWorkerStats_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label employeeName;
		private System.Windows.Forms.Label employeeNum;
		private System.Windows.Forms.Label shiftNum;
		private System.Windows.Forms.Label payRate;
		public System.Windows.Forms.Label employeeNameLabel;
		public System.Windows.Forms.Label employeeNumLabel;
		public System.Windows.Forms.Label shiftNumLabel;
		public System.Windows.Forms.Label payRateLabel;
	}
}