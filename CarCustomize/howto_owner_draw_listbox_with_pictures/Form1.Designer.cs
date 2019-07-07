namespace howto_owner_draw_listbox_with_pictures
{
    partial class Form1
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
            this.lstPlanets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstPlanets
            // 
            this.lstPlanets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPlanets.FormattingEnabled = true;
            this.lstPlanets.Location = new System.Drawing.Point(12, 12);
            this.lstPlanets.Name = "lstPlanets";
            this.lstPlanets.Size = new System.Drawing.Size(392, 264);
            this.lstPlanets.TabIndex = 0;
            this.lstPlanets.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPlanets_DrawItem);
            this.lstPlanets.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstPlanets_MeasureItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 290);
            this.Controls.Add(this.lstPlanets);
            this.Name = "Form1";
            this.Text = "howto_owner_draw_listbox_with_pictures";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPlanets;
    }
}

