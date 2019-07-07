namespace CarCustomize.Forms
{
	partial class VinylEditorForm
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
			this.editBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.OffsetX = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.OffsetY = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.Skew = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.Rotation = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.ScaleY = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.ScaleX = new System.Windows.Forms.NumericUpDown();
			this.mirrored = new System.Windows.Forms.CheckBox();
			this.vinylImage = new System.Windows.Forms.PictureBox();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.colorBtn1 = new System.Windows.Forms.Button();
			this.colorBtn2 = new System.Windows.Forms.Button();
			this.colorBtn3 = new System.Windows.Forms.Button();
			this.colorBtn4 = new System.Windows.Forms.Button();
			this.colorLabel1 = new System.Windows.Forms.Label();
			this.colorLabel2 = new System.Windows.Forms.Label();
			this.colorLabel3 = new System.Windows.Forms.Label();
			this.colorLabel4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.OffsetX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OffsetY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Skew)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Rotation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ScaleY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ScaleX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vinylImage)).BeginInit();
			this.SuspendLayout();
			// 
			// editBtn
			// 
			this.editBtn.Location = new System.Drawing.Point(198, 339);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(85, 33);
			this.editBtn.TabIndex = 0;
			this.editBtn.Text = "Edit";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(307, 339);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(85, 33);
			this.cancelBtn.TabIndex = 1;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// OffsetX
			// 
			this.OffsetX.Location = new System.Drawing.Point(88, 207);
			this.OffsetX.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.OffsetX.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
			this.OffsetX.Name = "OffsetX";
			this.OffsetX.Size = new System.Drawing.Size(94, 22);
			this.OffsetX.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 209);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 9;
			this.label1.Text = "Position X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(203, 209);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 17);
			this.label2.TabIndex = 11;
			this.label2.Text = "Position Y";
			// 
			// OffsetY
			// 
			this.OffsetY.Location = new System.Drawing.Point(280, 207);
			this.OffsetY.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.OffsetY.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
			this.OffsetY.Name = "OffsetY";
			this.OffsetY.Size = new System.Drawing.Size(94, 22);
			this.OffsetY.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(233, 268);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "Skew";
			// 
			// Skew
			// 
			this.Skew.Location = new System.Drawing.Point(280, 266);
			this.Skew.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.Skew.Name = "Skew";
			this.Skew.Size = new System.Drawing.Size(94, 22);
			this.Skew.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "Rotation";
			// 
			// Rotation
			// 
			this.Rotation.Location = new System.Drawing.Point(88, 268);
			this.Rotation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.Rotation.Name = "Rotation";
			this.Rotation.Size = new System.Drawing.Size(94, 22);
			this.Rotation.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(218, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 17);
			this.label5.TabIndex = 19;
			this.label5.Text = "Scale Y";
			// 
			// ScaleY
			// 
			this.ScaleY.Location = new System.Drawing.Point(280, 237);
			this.ScaleY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ScaleY.Name = "ScaleY";
			this.ScaleY.Size = new System.Drawing.Size(94, 22);
			this.ScaleY.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(26, 241);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 17);
			this.label6.TabIndex = 17;
			this.label6.Text = "Scale X";
			// 
			// ScaleX
			// 
			this.ScaleX.Location = new System.Drawing.Point(88, 239);
			this.ScaleX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ScaleX.Name = "ScaleX";
			this.ScaleX.Size = new System.Drawing.Size(94, 22);
			this.ScaleX.TabIndex = 16;
			// 
			// mirrored
			// 
			this.mirrored.AutoSize = true;
			this.mirrored.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.mirrored.Location = new System.Drawing.Point(24, 296);
			this.mirrored.Name = "mirrored";
			this.mirrored.Size = new System.Drawing.Size(83, 21);
			this.mirrored.TabIndex = 21;
			this.mirrored.Text = "Mirrored";
			this.mirrored.UseVisualStyleBackColor = true;
			// 
			// vinylImage
			// 
			this.vinylImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.vinylImage.Location = new System.Drawing.Point(14, 12);
			this.vinylImage.Name = "vinylImage";
			this.vinylImage.Size = new System.Drawing.Size(197, 189);
			this.vinylImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.vinylImage.TabIndex = 23;
			this.vinylImage.TabStop = false;
			this.vinylImage.Click += new System.EventHandler(this.vinylImage_Click);
			// 
			// colorBtn1
			// 
			this.colorBtn1.Location = new System.Drawing.Point(317, 12);
			this.colorBtn1.Name = "colorBtn1";
			this.colorBtn1.Size = new System.Drawing.Size(75, 29);
			this.colorBtn1.TabIndex = 24;
			this.colorBtn1.UseVisualStyleBackColor = true;
			this.colorBtn1.Click += new System.EventHandler(this.colorBtn_Click);
			// 
			// colorBtn2
			// 
			this.colorBtn2.Location = new System.Drawing.Point(317, 59);
			this.colorBtn2.Name = "colorBtn2";
			this.colorBtn2.Size = new System.Drawing.Size(75, 29);
			this.colorBtn2.TabIndex = 25;
			this.colorBtn2.UseVisualStyleBackColor = true;
			this.colorBtn2.Click += new System.EventHandler(this.colorBtn_Click);
			// 
			// colorBtn3
			// 
			this.colorBtn3.Location = new System.Drawing.Point(317, 104);
			this.colorBtn3.Name = "colorBtn3";
			this.colorBtn3.Size = new System.Drawing.Size(75, 29);
			this.colorBtn3.TabIndex = 26;
			this.colorBtn3.UseVisualStyleBackColor = true;
			this.colorBtn3.Click += new System.EventHandler(this.colorBtn_Click);
			// 
			// colorBtn4
			// 
			this.colorBtn4.Location = new System.Drawing.Point(317, 148);
			this.colorBtn4.Name = "colorBtn4";
			this.colorBtn4.Size = new System.Drawing.Size(75, 29);
			this.colorBtn4.TabIndex = 27;
			this.colorBtn4.UseVisualStyleBackColor = true;
			this.colorBtn4.Click += new System.EventHandler(this.colorBtn_Click);
			// 
			// colorLabel1
			// 
			this.colorLabel1.AutoSize = true;
			this.colorLabel1.Location = new System.Drawing.Point(258, 18);
			this.colorLabel1.Name = "colorLabel1";
			this.colorLabel1.Size = new System.Drawing.Size(53, 17);
			this.colorLabel1.TabIndex = 28;
			this.colorLabel1.Text = "Color 1";
			// 
			// colorLabel2
			// 
			this.colorLabel2.AutoSize = true;
			this.colorLabel2.Location = new System.Drawing.Point(258, 65);
			this.colorLabel2.Name = "colorLabel2";
			this.colorLabel2.Size = new System.Drawing.Size(53, 17);
			this.colorLabel2.TabIndex = 29;
			this.colorLabel2.Text = "Color 2";
			// 
			// colorLabel3
			// 
			this.colorLabel3.AutoSize = true;
			this.colorLabel3.Location = new System.Drawing.Point(258, 110);
			this.colorLabel3.Name = "colorLabel3";
			this.colorLabel3.Size = new System.Drawing.Size(53, 17);
			this.colorLabel3.TabIndex = 30;
			this.colorLabel3.Text = "Color 3";
			// 
			// colorLabel4
			// 
			this.colorLabel4.AutoSize = true;
			this.colorLabel4.Location = new System.Drawing.Point(258, 154);
			this.colorLabel4.Name = "colorLabel4";
			this.colorLabel4.Size = new System.Drawing.Size(53, 17);
			this.colorLabel4.TabIndex = 31;
			this.colorLabel4.Text = "Color 4";
			// 
			// VinylEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 384);
			this.Controls.Add(this.colorLabel4);
			this.Controls.Add(this.colorLabel3);
			this.Controls.Add(this.colorLabel2);
			this.Controls.Add(this.colorLabel1);
			this.Controls.Add(this.colorBtn4);
			this.Controls.Add(this.colorBtn3);
			this.Controls.Add(this.colorBtn2);
			this.Controls.Add(this.colorBtn1);
			this.Controls.Add(this.vinylImage);
			this.Controls.Add(this.mirrored);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ScaleY);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ScaleX);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Skew);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Rotation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.OffsetY);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OffsetX);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.editBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "VinylEditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit vinyl";
			((System.ComponentModel.ISupportInitialize)(this.OffsetX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OffsetY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Skew)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Rotation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ScaleY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ScaleX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vinylImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.NumericUpDown OffsetX;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown OffsetY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown Skew;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown Rotation;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown ScaleY;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown ScaleX;
		private System.Windows.Forms.CheckBox mirrored;
		private System.Windows.Forms.PictureBox vinylImage;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.Button colorBtn1;
		private System.Windows.Forms.Button colorBtn2;
		private System.Windows.Forms.Button colorBtn3;
		private System.Windows.Forms.Button colorBtn4;
		private System.Windows.Forms.Label colorLabel1;
		private System.Windows.Forms.Label colorLabel2;
		private System.Windows.Forms.Label colorLabel3;
		private System.Windows.Forms.Label colorLabel4;
	}
}