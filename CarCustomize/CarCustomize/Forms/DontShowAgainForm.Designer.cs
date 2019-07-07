namespace CarCustomize.Forms
{
	partial class DontShowAgainForm
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
			this.okBtn = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// okBtn
			// 
			this.okBtn.Location = new System.Drawing.Point(282, 84);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 30);
			this.okBtn.TabIndex = 0;
			this.okBtn.Text = "OK";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(11, 90);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(135, 21);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Dont show again";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// textLabel
			// 
			this.textLabel.AutoSize = true;
			this.textLabel.Location = new System.Drawing.Point(12, 19);
			this.textLabel.Name = "textLabel";
			this.textLabel.Size = new System.Drawing.Size(46, 17);
			this.textLabel.TabIndex = 2;
			this.textLabel.Text = "label1";
			// 
			// DontShowAgainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 126);
			this.Controls.Add(this.textLabel);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.okBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DontShowAgainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Information";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label textLabel;
	}
}