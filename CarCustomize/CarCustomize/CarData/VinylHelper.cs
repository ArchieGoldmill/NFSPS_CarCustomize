using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using CarCustomize.Properties;

namespace CarCustomize.CarData
{
	public class VinylHelper
	{
		public static readonly List<Bitmap> Images = new List<Bitmap>();

		private static Dictionary<int, Bitmap> imageCache = new Dictionary<int, Bitmap>();

		public static void Init()
		{
			for(int i =0; i< 6;i++)
			{
				Images.Add(new Bitmap($"data\\VinylPage{i}"));
			}
		}

		public static Bitmap GetImage(int code, int page)
		{
			if(page > 5 || code > 0xFF)
			{
				return Resources.unknown;
			}

			int hash = BitConverter.ToUInt16(new byte[] { (byte)code, (byte)page }, 0);

			if (imageCache.ContainsKey(hash))
			{
				return imageCache[hash];
			}

			var img = Images[page];

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