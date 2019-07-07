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
	public partial class DontShowAgainForm : BaseForm
	{
		public bool DontShow { get; private set; }

		public DontShowAgainForm(string text)
		{
			InitializeComponent();

			this.textLabel.Text = text;
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			this.DontShow = this.checkBox1.Checked;

			this.Close();
		}
	}
}
