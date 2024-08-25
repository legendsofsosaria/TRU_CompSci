namespace Production_Worker_App
{
	partial class productionWorkerForm
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
			this.employeeNameTextBox = new System.Windows.Forms.TextBox();
			this.employeeNum = new System.Windows.Forms.Label();
			this.employeeNumTextBox = new System.Windows.Forms.TextBox();
			this.shiftNumTextBox = new System.Windows.Forms.TextBox();
			this.payRateTextBox = new System.Windows.Forms.TextBox();
			this.shiftNum = new System.Windows.Forms.Label();
			this.payRate = new System.Windows.Forms.Label();
			this.submitButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// employeeName
			// 
			this.employeeName.AutoSize = true;
			this.employeeName.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeName.Location = new System.Drawing.Point(43, 43);
			this.employeeName.Name = "employeeName";
			this.employeeName.Size = new System.Drawing.Size(117, 22);
			this.employeeName.TabIndex = 0;
			this.employeeName.Text = "Employee Name";
			// 
			// employeeNameTextBox
			// 
			this.employeeNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeNameTextBox.Location = new System.Drawing.Point(190, 38);
			this.employeeNameTextBox.Name = "employeeNameTextBox";
			this.employeeNameTextBox.Size = new System.Drawing.Size(148, 27);
			this.employeeNameTextBox.TabIndex = 2;
			// 
			// employeeNum
			// 
			this.employeeNum.AutoSize = true;
			this.employeeNum.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeNum.Location = new System.Drawing.Point(43, 79);
			this.employeeNum.Name = "employeeNum";
			this.employeeNum.Size = new System.Drawing.Size(130, 22);
			this.employeeNum.TabIndex = 3;
			this.employeeNum.Text = "Employee Number";
			// 
			// employeeNumTextBox
			// 
			this.employeeNumTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.employeeNumTextBox.Location = new System.Drawing.Point(190, 74);
			this.employeeNumTextBox.Name = "employeeNumTextBox";
			this.employeeNumTextBox.Size = new System.Drawing.Size(148, 27);
			this.employeeNumTextBox.TabIndex = 4;
			// 
			// shiftNumTextBox
			// 
			this.shiftNumTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shiftNumTextBox.Location = new System.Drawing.Point(190, 112);
			this.shiftNumTextBox.Name = "shiftNumTextBox";
			this.shiftNumTextBox.Size = new System.Drawing.Size(148, 27);
			this.shiftNumTextBox.TabIndex = 5;
			// 
			// payRateTextBox
			// 
			this.payRateTextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.payRateTextBox.Location = new System.Drawing.Point(190, 154);
			this.payRateTextBox.Name = "payRateTextBox";
			this.payRateTextBox.Size = new System.Drawing.Size(148, 27);
			this.payRateTextBox.TabIndex = 6;
			// 
			// shiftNum
			// 
			this.shiftNum.AutoSize = true;
			this.shiftNum.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shiftNum.Location = new System.Drawing.Point(43, 117);
			this.shiftNum.Name = "shiftNum";
			this.shiftNum.Size = new System.Drawing.Size(92, 22);
			this.shiftNum.TabIndex = 7;
			this.shiftNum.Text = "Shift Number";
			// 
			// payRate
			// 
			this.payRate.AutoSize = true;
			this.payRate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.payRate.Location = new System.Drawing.Point(43, 154);
			this.payRate.Name = "payRate";
			this.payRate.Size = new System.Drawing.Size(67, 22);
			this.payRate.TabIndex = 8;
			this.payRate.Text = "Pay Rate";
			// 
			// submitButton
			// 
			this.submitButton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitButton.Location = new System.Drawing.Point(85, 209);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(88, 36);
			this.submitButton.TabIndex = 9;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.Location = new System.Drawing.Point(209, 209);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(88, 36);
			this.exitButton.TabIndex = 10;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// productionWorkerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 286);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.payRate);
			this.Controls.Add(this.shiftNum);
			this.Controls.Add(this.payRateTextBox);
			this.Controls.Add(this.shiftNumTextBox);
			this.Controls.Add(this.employeeNumTextBox);
			this.Controls.Add(this.employeeNum);
			this.Controls.Add(this.employeeNameTextBox);
			this.Controls.Add(this.employeeName);
			this.Name = "productionWorkerForm";
			this.Text = "Production Worker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label employeeName;
		private System.Windows.Forms.TextBox employeeNameTextBox;
		private System.Windows.Forms.Label employeeNum;
		private System.Windows.Forms.TextBox employeeNumTextBox;
		private System.Windows.Forms.TextBox shiftNumTextBox;
		private System.Windows.Forms.TextBox payRateTextBox;
		private System.Windows.Forms.Label shiftNum;
		private System.Windows.Forms.Label payRate;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Button exitButton;
	}
}

