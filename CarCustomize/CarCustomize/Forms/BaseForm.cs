using System.Drawing;
using System.Windows.Forms;

namespace CarCustomize.Forms
{
	public class BaseForm: Form
	{
		public BaseForm()
		{
			this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}
	}
}