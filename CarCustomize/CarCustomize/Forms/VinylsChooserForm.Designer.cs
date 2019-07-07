namespace Customize
{
    partial class VinylsChooserForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.hexTableImage = new System.Windows.Forms.PictureBox();
			this.numberLabel = new System.Windows.Forms.Label();
			this.rightBtn = new System.Windows.Forms.Button();
			this.leftBtn = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.hexTableImage)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.hexTableImage);
			this.panel1.Location = new System.Drawing.Point(16, 15);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(865, 505);
			this.panel1.TabIndex = 1;
			// 
			// hexTableImage
			// 
			this.hexTableImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hexTableImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hexTableImage.Image = global::CarCustomize.Properties.Resources._0;
			this.hexTableImage.InitialImage = null;
			this.hexTableImage.Location = new System.Drawing.Point(0, 0);
			this.hexTableImage.Margin = new System.Windows.Forms.Padding(4);
			this.hexTableImage.Name = "hexTableImage";
			this.hexTableImage.Size = new System.Drawing.Size(865, 505);
			this.hexTableImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.hexTableImage.TabIndex = 0;
			this.hexTableImage.TabStop = false;
			this.hexTableImage.Click += new System.EventHandler(this.hexTableImage_Click);
			// 
			// numberLabel
			// 
			this.numberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.numberLabel.AutoSize = true;
			this.numberLabel.Location = new System.Drawing.Point(414, 28);
			this.numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.numberLabel.Name = "numberLabel";
			this.numberLabel.Size = new System.Drawing.Size(28, 17);
			this.numberLabel.TabIndex = 4;
			this.numberLabel.Text = "1/6";
			// 
			// rightBtn
			// 
			this.rightBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rightBtn.Location = new System.Drawing.Point(491, 21);
			this.rightBtn.Margin = new System.Windows.Forms.Padding(4);
			this.rightBtn.Name = "rightBtn";
			this.rightBtn.Size = new System.Drawing.Size(60, 31);
			this.rightBtn.TabIndex = 3;
			this.rightBtn.Text = "Next";
			this.rightBtn.UseVisualStyleBackColor = true;
			this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
			// 
			// leftBtn
			// 
			this.leftBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.leftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.leftBtn.Location = new System.Drawing.Point(311, 21);
			this.leftBtn.Margin = new System.Windows.Forms.Padding(4);
			this.leftBtn.Name = "leftBtn";
			this.leftBtn.Size = new System.Drawing.Size(61, 31);
			this.leftBtn.TabIndex = 2;
			this.leftBtn.Text = "Prev";
			this.leftBtn.UseVisualStyleBackColor = true;
			this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.linkLabel1);
			this.panel2.Controls.Add(this.rightBtn);
			this.panel2.Controls.Add(this.leftBtn);
			this.panel2.Controls.Add(this.numberLabel);
			this.panel2.Location = new System.Drawing.Point(16, 527);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(865, 65);
			this.panel2.TabIndex = 5;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(715, 28);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(138, 17);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "www.nfsunlimited.net";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// VinylsChooserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 591);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "VinylsChooserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pick vinyl";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.hexTableImage)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hexTableImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}