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
	public partial class LockUnlockCarForm : BaseForm
	{
		private CarDataManager carDataManager;

		public LockUnlockCarForm(CarDataManager carDataManager)
		{
			InitializeComponent();

			this.carDataManager = carDataManager;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.carDataManager.SetCarLocked(
				(int)this.numericUpDown1.Value, 
				(int)this.numericUpDown2.Value, 
				this.radioButton1.Checked);

			this.Close();
		}
	}
}
