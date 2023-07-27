using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarCustomize.CarData;
using Customize;

namespace CarCustomize.Forms
{
	public partial class VinylEditorForm : BaseForm
	{
		private CarDataManager carDataManager;

		private int vinylNum;

		private bool isDecal;

		private byte code;

		private byte page;

		private List<NumericUpDown> controls;

		public VinylEditorForm(CarDataManager carDataManager, bool isDecal, int vinylNum)
		{
			InitializeComponent();

			this.carDataManager = carDataManager;

			this.vinylNum = vinylNum;

			this.isDecal = isDecal;

			this.controls = new List<NumericUpDown>();
			this.InitControl(this.OffsetX);
			this.InitControl(this.OffsetY);
			this.InitControl(this.ScaleX);
			this.InitControl(this.ScaleY);
			this.InitControl(this.Skew);
			this.InitControl(this.Rotation);

			this.mirrored.Checked = this.carDataManager.GetMirrored(this.vinylNum, isDecal);

			this.code = (byte)this.carDataManager.GetVinylData(this.vinylNum, isDecal, "Code");
			this.page = (byte)this.carDataManager.GetVinylData(this.vinylNum, isDecal, "Page");

			this.SetVinylImage();

			this.SetColor(this.colorBtn1, 1);

			if (isDecal)
			{
				this.colorBtn2.Visible = false;
				this.colorBtn3.Visible = false;
				this.colorBtn4.Visible = false;

				this.colorLabel2.Visible = false;
				this.colorLabel3.Visible = false;
				this.colorLabel4.Visible = false;
			}
			else
			{
				this.SetColor(this.colorBtn2, 2);
				this.SetColor(this.colorBtn3, 3);
				this.SetColor(this.colorBtn4, 4);
			}
		}

		private void SetColor(Button btn, int num)
		{
			var hue = this.carDataManager.GetVinylData(this.vinylNum, this.isDecal, $"Color{num}_Tone");
			if (hue > Constants.HueMax)
			{
				return;
			}

			var saturation = this.carDataManager.GetVinylData(this.vinylNum, this.isDecal, $"Color{num}_Saturation");
			var brightness = this.carDataManager.GetVinylData(this.vinylNum, this.isDecal, $"Color{num}_Brightness");

			btn.BackColor = Helper.ColorFromHSV(hue, saturation, brightness);
		}

		private void InitControl(NumericUpDown control)
		{
			this.controls.Add(control);
			control.Value = this.carDataManager.GetVinylData(this.vinylNum, this.isDecal, control.Name);
		}

		private void SetVinylImage()
		{
			this.vinylImage.Image = VinylHelper.GetImage(this.code, this.page);
		}

		private void colorBtn_Click(object sender, EventArgs e)
		{
			var btn = sender as Button;
			this.colorDialog.Color = btn.BackColor;
			if (this.colorDialog.ShowDialog() == DialogResult.OK)
			{
				btn.BackColor = this.colorDialog.Color;
			}
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			foreach (var control in this.controls)
			{
				this.carDataManager.SetVinylData(this.vinylNum, this.isDecal, control.Name, (int)control.Value);
			}

			this.WriteColorData(this.colorBtn1.BackColor, 1);
			if (!this.isDecal)
			{
				this.WriteColorData(this.colorBtn2.BackColor, 2);
				this.WriteColorData(this.colorBtn3.BackColor, 3);
				this.WriteColorData(this.colorBtn4.BackColor, 4);
			}

			this.carDataManager.SetVinylData(this.vinylNum, this.isDecal, "Code", this.code);
			this.carDataManager.SetVinylData(this.vinylNum, this.isDecal, "Page", this.page);

			this.carDataManager.SetMirrored(this.vinylNum, this.isDecal, this.mirrored.Checked);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void WriteColorData(Color color, int num)
		{
			var hsv = Helper.GetHSV(color);

			this.carDataManager.SetVinylData(this.vinylNum, this.isDecal, $"Color{num}_Tone", (byte)hsv.Hue);
			this.carDataManager.SetVinylData(this.vinylNum, this.isDecal, $"Color{num}_Saturation", (byte)hsv.Saturation);
			this.carDataManager.SetVinylData(this.vinylNum, this.isDecal, $"Color{num}_Brightness", (byte)(hsv.Value));
			this.carDataManager.SetVinylData(this.vinylNum, this.isDecal, $"Color{num}_StrangeByte", 06);
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void vinylImage_Click(object sender, EventArgs e)
		{
			var form = new VinylsChooserForm();
			form.ShowDialog();

			if (form.Picked)
			{
				this.code = form.Code;
				this.page = form.Page;
				this.SetVinylImage();
			}
		}
	}
}
