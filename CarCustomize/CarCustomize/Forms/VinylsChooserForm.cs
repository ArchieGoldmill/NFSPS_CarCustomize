using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarCustomize.CarData;
using CarCustomize.Forms;
using CarCustomize.Properties;

namespace Customize
{
	public partial class VinylsChooserForm : BaseForm
	{
		private byte _currentImgNumber;

		public byte Code { get; private set; }

		public byte Page { get; private set; }

		public bool Picked { get; private set; }

		public VinylsChooserForm()
		{
			InitializeComponent();

			hexTableImage.Image = VinylHelper.Images[_currentImgNumber];
			this.numberLabel.Text = $"{_currentImgNumber + 1}/6";
		}

		private void rightBtn_Click(object sender, EventArgs e)
		{
			if (_currentImgNumber != 5)
			{
				_currentImgNumber++;

				hexTableImage.Image = VinylHelper.Images[_currentImgNumber];

				numberLabel.Text = $"{_currentImgNumber + 1}/6";
			}
		}

		private void leftBtn_Click(object sender, EventArgs e)
		{
			if (_currentImgNumber != 0)
			{
				_currentImgNumber--;

				hexTableImage.Image = VinylHelper.Images[_currentImgNumber];

				numberLabel.Text = $"{_currentImgNumber + 1}/6";
			}
		}

		private void hexTableImage_Click(object sender, EventArgs e)
		{
			var coordinates = hexTableImage.PointToClient(Cursor.Position);

			byte firstByte = 0;
			for (double i = hexTableImage.Size.Height / 16d; i <= coordinates.Y; i += hexTableImage.Size.Height / 16d)
			{
				firstByte++;
			}

			byte secondByte = 0;
			for (double i = hexTableImage.Size.Width / 16d; i <= coordinates.X; i += hexTableImage.Size.Width / 16d)
			{
				secondByte++;
			}

			this.Code = (byte)(firstByte * 16 + secondByte);
			this.Page = _currentImgNumber;

			this.Picked = true;

			this.Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.nfsunlimited.net/forum/viewtopic.php?f=2&t=15413&st=0&sk=t&sd=a&start=300#p326269");
		}
	}
}
