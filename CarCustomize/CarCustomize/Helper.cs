using System;
using System.Drawing;

namespace CarCustomize
{
	public struct HSVColor
	{
		public double Hue;
		public double Saturation;
		public double Value;
	}

	public static class Helper
	{
		public static HSVColor GetHSV(Color color)
		{
			HSVColor toReturn = new HSVColor();

			int max = Math.Max(color.R, Math.Max(color.G, color.B));
			int min = Math.Min(color.R, Math.Min(color.G, color.B));

			toReturn.Hue = Math.Round(color.GetHue(), 2);
			toReturn.Saturation = ((max == 0) ? 0 : 1d - (1d * min / max)) * 100;
			toReturn.Saturation = Math.Round(toReturn.Saturation, 2);
			toReturn.Value = Math.Round(((max / 255d) * 100), 2);

			toReturn.Hue = ((360d - toReturn.Hue) / 360d) * Constants.HueMax;
			toReturn.Saturation = toReturn.Saturation / 100d * 255;
			toReturn.Value = toReturn.Value / 100d * 255;

			return toReturn;
		}

		public static Color ColorFromHSV(double hue, double saturation, double brightness)
		{
			hue = 360d - (double)hue / Constants.HueMax * 360d;
			saturation = saturation / 0xff;
			brightness = brightness / 0xff;

			int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
			double f = hue / 60 - Math.Floor(hue / 60);

			brightness = brightness * 255;
			int v = Convert.ToInt32(brightness);
			int p = Convert.ToInt32(brightness * (1 - saturation));
			int q = Convert.ToInt32(brightness * (1 - f * saturation));
			int t = Convert.ToInt32(brightness * (1 - (1 - f) * saturation));

			if (hi == 0)
				return Color.FromArgb(255, v, t, p);
			else if (hi == 1)
				return Color.FromArgb(255, q, v, p);
			else if (hi == 2)
				return Color.FromArgb(255, p, v, t);
			else if (hi == 3)
				return Color.FromArgb(255, p, q, v);
			else if (hi == 4)
				return Color.FromArgb(255, t, p, v);
			else
				return Color.FromArgb(255, v, p, q);
		}
	}
}
