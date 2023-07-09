using System.Windows.Forms;

namespace CarCustomize.Forms
{
	public partial class AboutForm : BaseForm
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://discord.gg/DxC6Fyf");
		}
	}
}
