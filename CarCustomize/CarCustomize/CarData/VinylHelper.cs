using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using CarCustomize.Properties;

namespace CarCustomize.CarData
{
	public class VinylHelper
	{
		private static readonly Bitmap[] images = new[]
		{
			Resources._0,
			Resources._1,
			Resources._2,
			Resources._3,
			Resources._4,
			Resources._5
		};

		private static Dictionary<int, Bitmap> imageCache = new Dictionary<int, Bitmap>();

		public static Bitmap GetImage(int code, int page)
		{
			int hash = BitConverter.ToUInt16(new byte[] { (byte)code, (byte)page }, 0);

			if (imageCache.ContainsKey(hash))
			{
				return imageCache[hash];
			}

			var img = images[page];

			int row = code / 16;
			int col = code % 16;

			var finalImage = img.Clone(new RectangleF
				{
					X = img.Width / 16f * col + 2,
					Y = img.Height / 16f * row + 2,
					Width = img.Width / 16f - 3,
					Height = img.Height / 16f - 3,
				},
				PixelFormat.Undefined);

			imageCache.Add(hash,finalImage);

			return finalImage;
		}
	}
}