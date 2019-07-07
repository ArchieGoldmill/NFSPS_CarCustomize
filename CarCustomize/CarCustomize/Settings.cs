using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CarCustomize
{
	public class Settings
	{
		private static string fileName = "settings.xml";

		public string ProcessName { get; set; } = "nfs";

		public int ImageSize { get; set; } = 40;

		public bool ShowDoubleClickMessage { get; set; } = true;

		public bool ShowCarModesMessage { get; set; } = true;

		public void Save()
		{
			TextWriter writer = null;
			try
			{
				var serializer = new XmlSerializer(typeof(Settings));
				writer = new StreamWriter(fileName);
				serializer.Serialize(writer, this);
			}
			catch (Exception ex)
			{
				throw new Exception("Error while saving settings occured\n" + ex.Message);
			}
			finally
			{
				if (writer != null)
				{
					writer.Close();
				}
			}
		}

		public static Settings Read()
		{
			TextReader reader = null;
			try
			{
				var serializer = new XmlSerializer(typeof(Settings));
				reader = new StreamReader(Settings.fileName);
				return (Settings)serializer.Deserialize(reader);
			}
			finally
			{
				if (reader != null)
				{
					reader.Close();
				}
			}
		}
	}
}