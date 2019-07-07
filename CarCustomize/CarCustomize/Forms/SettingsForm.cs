using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCustomize.Forms
{
	public partial class SettingsForm : BaseForm
	{
		private Settings settings;

		public SettingsForm(Settings settings)
		{
			InitializeComponent();

			this.settings = settings;

			this.processName.Text = this.settings.ProcessName;

			this.imageSize.Value = this.settings.ImageSize;
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.processName.Text))
			{
				MessageBox.Show("Please specify game process name",
					"Error saving settings",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);

				return;
			}

			this.settings.ProcessName = this.processName.Text;
			this.settings.ImageSize = (int)this.imageSize.Value;

			this.settings.Save();
			this.Close();
		}
	}
}
