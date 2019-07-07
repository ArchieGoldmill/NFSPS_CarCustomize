namespace CarCustomize.Forms
{
	partial class SettingsForm
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
			this.processName = new System.Windows.Forms.TextBox();
			this.okBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.imageSize = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imageSize)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Process name";
			// 
			// processName
			// 
			this.processName.Location = new System.Drawing.Point(116, 26);
			this.processName.MaxLength = 20;
			this.processName.Name = "processName";
			this.processName.Size = new System.Drawing.Size(120, 22);
			this.processName.TabIndex = 1;
			// 
			// okBtn
			// 
			this.okBtn.Location = new System.Drawing.Point(198, 190);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(84, 28);
			this.okBtn.TabIndex = 2;
			this.okBtn.Text = "OK";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(35, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Image size";
			// 
			// imageSize
			// 
			this.imageSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.imageSize.Location = new System.Drawing.Point(116, 69);
			this.imageSize.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
			this.imageSize.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.imageSize.Name = "imageSize";
			this.imageSize.Size = new System.Drawing.Size(120, 22);
			this.imageSize.TabIndex = 4;
			this.imageSize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(242, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = ".exe";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 230);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.imageSize);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.processName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			((System.ComponentModel.ISupportInitialize)(this.imageSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox processName;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown imageSize;
		private System.Windows.Forms.Label label3;
	}
}