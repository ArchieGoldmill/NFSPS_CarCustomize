using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using Core;

namespace CarCustomize.CarData
{
	public class CarDataManager
	{
		private MemoryManager memoryManager;

		private byte[] copy;

		private uint saveLocation;

		private int carNum;

		public CarDataManager(MemoryManager memoryManager, CarDataManager old = null)
		{
			if (old != null)
			{
				this.copy = old.copy; // save copy even if we disconnect from the game
			}

			this.memoryManager = memoryManager;
		}

		public uint CarPointer { get; set; }
		public int CarConfig { get; set; }

		public void Init()
		{
			int configNum = this.memoryManager.ReadByte(new IntPtr(0x00B32D08));
			this.saveLocation = this.memoryManager.ReadUInt(new IntPtr(0x00AB0EAC)) + 0x28B4;
			this.carNum = this.memoryManager.ReadByteMultiLevel(new[] { 0x732D04, 0x14 });

			long ptr = configNum * Constants.ConfigSize + carNum * Constants.CarSize + saveLocation;

			this.CarPointer = (uint)ptr;
			this.CarConfig = configNum;
		}

		public int GetCarNum(int num = -1)
		{
			int del = 0;
			for (int i = 0; i < this.carNum; i++)
			{
				var id = this.GetCurrentCarId(this.saveLocation + Constants.CarSize * i);
				if (id == 0)
				{
					del++;
				}
			}

			return this.carNum - del + 1;
		}

		public uint GetCurrentCarId(long ptr = -1)
		{
			long idPtr;

			if (ptr == -1)
			{
				idPtr = this.CarPointer + (3 - this.CarConfig) * Constants.ConfigSize + 0xDC;
			}
			else
			{
				idPtr = ptr + 3 * Constants.ConfigSize + 0xDC;
			}

			return this.memoryManager.ReadUInt(new IntPtr(idPtr));
		}

		// Vinyls & Decals
		public bool GetMirrored(int num, bool isDecal)
		{
			var location = isDecal ? Constants.DecalsMirrorLocation : Constants.VinylsMirrorLocation;
			var val = this.memoryManager.ReadBytes(new IntPtr(this.CarPointer + location), 4);
			var bits = new BitArray(val);

			return bits[num];
		}

		public void SetMirrored(int num, bool isDecal, bool mirrored)
		{
			var location = isDecal ? Constants.DecalsMirrorLocation : Constants.VinylsMirrorLocation;
			var ptr = new IntPtr(this.CarPointer + location);
			var val = this.memoryManager.ReadBytes(ptr, 4);
			var bits = new BitArray(val);

			bits[num] = mirrored;

			this.memoryManager.WriteInt(ptr, getIntFromBitArray(bits));
		}

		public void MoveToVinyls(int num)
		{
			bool mirrored = this.GetMirrored(num, true);
			var bytes = this.memoryManager.ReadBytes(
				new IntPtr(this.CarPointer + Constants.DecalsLocation + num * Constants.DecalSize), Constants.DecalSize);

			this.DeleteVinyl(num, true);
			var count = this.VinylCount++;

			var vinyl = new byte[Constants.VinylSize];
			for (int i = 0; i < vinyl.Length; i++)
			{
				vinyl[i] = 0xff;
			}

			IntPtr ptr = new IntPtr(this.CarPointer + Constants.VinylsLocation + Constants.VinylSize * count);
			this.memoryManager.WriteBytes(ptr, vinyl);
			this.memoryManager.WriteBytes(ptr, bytes);
			this.SetMirrored(count, false, mirrored);
		}

		public void MoveToDecals(int num)
		{
			bool mirrored = this.GetMirrored(num, false);
			var bytes = this.memoryManager.ReadBytes(
				new IntPtr(this.CarPointer + Constants.VinylsLocation + num * Constants.VinylSize), Constants.VinylSize);

			this.DeleteVinyl(num, false);
			var count = this.DecalCount++;

			IntPtr ptr = new IntPtr(this.CarPointer + Constants.DecalsLocation + Constants.DecalSize * count);
			this.memoryManager.WriteBytes(ptr, bytes.Take(Constants.DecalSize).ToArray());
			this.SetMirrored(count, true, mirrored);
		}

		public void DuplicateVinyl(int num, bool isDecal)
		{
			int location = isDecal ? Constants.DecalsLocation : Constants.VinylsLocation;
			int size = isDecal ? Constants.DecalSize : Constants.VinylSize;
			var bytes = this.memoryManager.ReadBytes(new IntPtr(this.CarPointer + location + num * size), size);
			bool mirrored = this.GetMirrored(num, isDecal);

			var count = isDecal ? this.DecalCount++ : this.VinylCount++;

			this.memoryManager.WriteBytes(new IntPtr(this.CarPointer + location + count * size), bytes);
			this.SetMirrored(count, isDecal, mirrored);
		}

		public void DeleteVinyl(int num, bool isDecal)
		{
			int location = isDecal ? Constants.DecalsLocation : Constants.VinylsLocation;
			int size = isDecal ? Constants.DecalSize : Constants.VinylSize;
			var ptr = this.CarPointer + location + num * size;

			var count = isDecal ? this.DecalCount : this.VinylCount;
			if (num + 1 != count)
			{
				var bytes = this.memoryManager.ReadBytes(new IntPtr(ptr + size), (count - num) * size);
				this.memoryManager.WriteBytes(new IntPtr(ptr), bytes);

				var mirrorLocation = isDecal ? Constants.DecalsMirrorLocation : Constants.VinylsMirrorLocation;
				var mirrorPtr = new IntPtr(this.CarPointer + mirrorLocation);
				var val = this.memoryManager.ReadBytes(mirrorPtr, 4);
				var bits = new BitArray(val);

				for (int i = num; i < bits.Length - 1; i++)
				{
					bits[i] = bits[i + 1];
				}

				this.memoryManager.WriteInt(mirrorPtr, getIntFromBitArray(bits));
			}

			if (isDecal)
			{
				this.DecalCount = count - 1;
			}
			else
			{
				this.VinylCount = count - 1;
			}
		}

		public void AddVinyl(bool isDecal, byte code, byte page)
		{
			var count = isDecal ? this.DecalCount++ : this.VinylCount++;

			int location = isDecal ? Constants.DecalsLocation : Constants.VinylsLocation;
			int size = isDecal ? Constants.DecalSize : Constants.VinylSize;
			var ptr = this.CarPointer + location + count * size;

			var bytes = new byte[size];
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] = 0xff;
			}

			this.memoryManager.WriteBytes(new IntPtr(ptr), bytes);
			this.SetVinylData(count, isDecal, "Code", code);
			this.SetVinylData(count, isDecal, "Page", page);
			this.SetVinylData(count, isDecal, "OffsetX", 110);
			this.SetVinylData(count, isDecal, "OffsetY", -25);
			this.SetVinylData(count, isDecal, "ScaleX", 30);
			this.SetVinylData(count, isDecal, "ScaleY", 30);
			this.SetVinylData(count, isDecal, "Rotation", 190);
			this.SetVinylData(count, isDecal, "Skew", 0);
			this.SetMirrored(count, isDecal, true);
		}

		private int getIntFromBitArray(BitArray bitArray)
		{

			if (bitArray.Length > 32)
				throw new ArgumentException("Argument length shall be at most 32 bits.");

			int[] array = new int[1];
			bitArray.CopyTo(array, 0);
			return array[0];

		}

		public int GetVinylData(int num, bool isDecal, string data)
		{
			int location = isDecal ? Constants.DecalsLocation : Constants.VinylsLocation;
			int size = isDecal ? Constants.DecalSize : Constants.VinylSize;
			var ptr = new IntPtr(this.CarPointer + location + num * size + Constants.Vinyl[data]);

			if (data.Contains("Offset"))
			{
				return this.memoryManager.ReadShort(ptr);
			}
			else
			{
				return this.memoryManager.ReadByte(ptr);
			}
		}

		public void SetVinylData(int num, bool isDecal, string data, int value)
		{
			int location = isDecal ? Constants.DecalsLocation : Constants.VinylsLocation;
			int size = isDecal ? Constants.DecalSize : Constants.VinylSize;
			var ptr = new IntPtr(this.CarPointer + location + num * size + Constants.Vinyl[data]);

			if (data.Contains("Offset"))
			{
				this.memoryManager.WriteShort(ptr, (short)value);
			}
			else
			{
				this.memoryManager.WriteByte(ptr, (byte)value);
			}
		}

		public void SwapVinyls(int num1, int num2, bool isDecal)
		{
			int location = isDecal ? Constants.DecalsLocation : Constants.VinylsLocation;
			int size = isDecal ? Constants.DecalSize : Constants.VinylSize;
			var ptr1 = new IntPtr(this.CarPointer + location + num1 * size);
			var ptr2 = new IntPtr(this.CarPointer + location + num2 * size);

			var bytes1 = this.memoryManager.ReadBytes(ptr1, size);
			var bytes2 = this.memoryManager.ReadBytes(ptr2, size);

			this.memoryManager.WriteBytes(ptr1, bytes2);
			this.memoryManager.WriteBytes(ptr2, bytes1);
		}

		public int VinylCount
		{
			get => this.memoryManager.ReadInt(new IntPtr(this.CarPointer + Constants.VinylsCountLocation));
			set => this.memoryManager.WriteInt(new IntPtr(this.CarPointer + Constants.VinylsCountLocation), value);
		}

		public int DecalCount
		{
			get => this.memoryManager.ReadInt(new IntPtr(this.CarPointer + Constants.DecalsCountLocation));
			set => this.memoryManager.WriteInt(new IntPtr(this.CarPointer + Constants.DecalsCountLocation), value);
		}

		// Get set parts
		public void SetPart(string name, byte value)
		{
			if (this.CarPointer != 0 && Constants.CarParts.ContainsKey(name))
			{
				var offset = Constants.CarParts[name].Offset;
				var partCode = Constants.CarParts[name].Code;

				uint id = this.GetCurrentCarId();
				int addOffset = 0;
				if (id == 22084480) //240sx
				{
					addOffset = 3;
				}

				if (value == Constants.NonePart)
				{
					partCode = Constants.NoneCode; // magic code that removes parts
				}

				this.memoryManager.WriteByte(new IntPtr(this.CarPointer + offset), value);
				this.memoryManager.WriteByte(new IntPtr(this.CarPointer + offset + 1), (byte)(partCode + addOffset));
			}
		}

		public byte CarMode
		{
			get => this.memoryManager.ReadByte(new IntPtr(this.CarPointer + Constants.CarMode));
			set => this.memoryManager.WriteByte(new IntPtr(this.CarPointer + Constants.CarMode), value);
		}

		public byte GetPart(string name)
		{
			if (this.CarPointer == 0 || !Constants.CarParts.ContainsKey(name))
			{
				return 0xff;
			}

			return this.memoryManager.ReadByte(new IntPtr(this.CarPointer + Constants.CarParts[name].Offset));
		}

		// Copy & Paste car code
		public void CopyCurrentCar()
		{
			this.copy = this.memoryManager.ReadBytes(new IntPtr(this.CarPointer), Constants.ConfigSize);
		}

		public byte[] CurrentCar
		{
			get => this.memoryManager.ReadBytes(new IntPtr(this.CarPointer), Constants.ConfigSize);
			set
			{
				this.memoryManager.WriteBytes(new IntPtr(this.CarPointer), value);
				this.FixCarParts();
			}
		}

		public bool CanPaste => this.copy != null;

		public void PasteCopyToCurrentCar()
		{
			this.memoryManager.WriteBytes(new IntPtr(this.CarPointer), this.copy);

			this.FixCarParts();
		}

		public void PasteCopyVinylToCurrentCar()
		{
			this.memoryManager.WriteBytes(new IntPtr(this.CarPointer + Constants.VinylsLocation), 
				this.copy.Skip(Constants.VinylsLocation).Take(Constants.VinylsSectionSize).ToArray());

			this.FixCarParts();
		}

		private void FixCarParts()
		{
			foreach (var val in Constants.CarParts.Values)
			{
				uint id = this.GetCurrentCarId();
				int addOffset = 0;
				if (id == 22084480) //240sx
				{
					addOffset = 3;
				}

				var part = this.memoryManager.ReadByte(new IntPtr(this.CarPointer + val.Offset));
				var code = val.Code;
				if (part == Constants.NonePart)
				{
					code = Constants.NoneCode;
				}

				this.memoryManager.WriteByte(new IntPtr(this.CarPointer + val.Offset + 1), (byte)(code + addOffset));
			}
		}

		// Autosculpt & Carbon
		public byte[] GetAutosculptData(string name)
		{
			return this.memoryManager.ReadBytes(new IntPtr(this.CarPointer + Constants.Autosculpt[name]), 10);
		}

		public void SetAutosculptData(string name, byte[] array)
		{
			this.memoryManager.WriteBytes(new IntPtr(this.CarPointer + Constants.Autosculpt[name]), array);
		}

		public bool GetCarbonData(string name)
		{
			var b = this.memoryManager.ReadByte(new IntPtr(this.CarPointer + Constants.Carbon[name]));

			return b == 1;
		}

		public void SetCarbonData(string name, bool carbon)
		{
			this.memoryManager.WriteByte(new IntPtr(this.CarPointer + Constants.Carbon[name]), carbon ? (byte)1 : (byte)0);
		}

		// Color
		public Color GetColor(string part)
		{
			int offset = Constants.Colors[part];
			var hue = this.memoryManager.ReadByte(new IntPtr(this.CarPointer + offset + 2));
			var sat = this.memoryManager.ReadByte(new IntPtr(this.CarPointer + offset + 2));
			var val = this.memoryManager.ReadByte(new IntPtr(this.CarPointer + offset + 3));

			return Helper.ColorFromHSV(hue, sat, val);
		}

		// Misc
		public void SetCarLocked(int num, int config, bool locked)
		{
			int notdel = 0;
			for (int i = 0; i < 70; i++)
			{
				var id = this.GetCurrentCarId(this.saveLocation + Constants.CarSize * i);
				if (id != 0)
				{
					notdel++;
				}

				if (notdel == num)
				{
					long ptr = this.saveLocation + Constants.CarSize * i + Constants.ConfigSize * 2 + Constants.CarLock + config - 1;
					this.memoryManager.WriteByte(new IntPtr(ptr), locked ? (byte)1 : (byte)0);
					return;
				}
			}
		}

		public string StaticLivery
		{
			get
			{
				var data = this.memoryManager.ReadBytes(new IntPtr(this.CarPointer + Constants.StaticLivery), 4);
				return BitConverter.ToString(data).Replace("-", string.Empty);
			}

			set
			{
				this.memoryManager.WriteBytes(
					new IntPtr(this.CarPointer + Constants.StaticLivery),
					this.StringToByteArray(value));
			}
		}

		public byte[] StringToByteArray(string hex)
		{
			return Enumerable.Range(0, hex.Length)
				.Where(x => x % 2 == 0)
				.Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
				.ToArray();
		}
	}
}