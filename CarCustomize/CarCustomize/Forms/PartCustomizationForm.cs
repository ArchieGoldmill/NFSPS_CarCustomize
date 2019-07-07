using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarCustomize.CarData;

namespace CarCustomize.Forms
{
	public partial class PartCustomizationForm : BaseForm
	{
		private CarDataManager carDataManager;
		private string partName;

		public PartCustomizationForm(string partName, CarDataManager carDataManager)
		{
			InitializeComponent();

			this.carDataManager = carDataManager;
			this.partName = partName;

			var bytes = this.carDataManager.GetAutosculptData(partName);

			this.zone1.Value = bytes[0];
			this.zone2.Value = bytes[1];
			this.zone3.Value = bytes[2];
			this.zone4.Value = bytes[3];
			this.zone5.Value = bytes[4];
			this.zone6.Value = bytes[5];
			this.zone7.Value = bytes[6];
			this.zone8.Value = bytes[7];
			this.zone9.Value = bytes[8];
			this.zone10.Value = bytes[9];

			if (Constants.Carbon.ContainsKey(partName))
			{
				this.carbon.Checked = this.carDataManager.GetCarbonData(partName);
			}
			else
			{
				this.carbon.Visible = false;
			}
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			if (Constants.Carbon.ContainsKey(partName))
			{
				this.carDataManager.SetCarbonData(this.partName, this.carbon.Checked);
			}

			byte[] array = new byte[10];

			array[0] = (byte)this.zone1.Value;
			array[1] = (byte)this.zone2.Value;
			array[2] = (byte)this.zone3.Value;
			array[3] = (byte)this.zone4.Value;
			array[4] = (byte)this.zone5.Value;
			array[5] = (byte)this.zone6.Value;
			array[6] = (byte)this.zone7.Value;
			array[7] = (byte)this.zone8.Value;
			array[8] = (byte)this.zone9.Value;
			array[9] = (byte)this.zone10.Value;

			this.carDataManager.SetAutosculptData(this.partName, array);

			this.Close();
		}
	}
}
