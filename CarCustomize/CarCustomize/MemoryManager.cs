using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Core
{
	public class ExternalDllMethods
	{
		[Flags]
		protected enum ProcessAccessFlags : uint
		{
			All = 0x001F0FFF,
			Terminate = 0x00000001,
			CreateThread = 0x00000002,
			VirtualMemoryOperation = 0x00000008,
			VirtualMemoryRead = 0x00000010,
			DuplicateHandle = 0x00000040,
			CreateProcess = 0x000000080,
			SetQuota = 0x00000100,
			SetInformation = 0x00000200,
			QueryInformation = 0x00000400,
			QueryLimitedInformation = 0x00001000,
			Synchronize = 0x00100000
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		protected static extern IntPtr OpenProcess(
			ProcessAccessFlags processAccess,
			bool bInheritHandle,
			int processId
		);

		[DllImport("kernel32.dll", SetLastError = true)]
		protected static extern bool WriteProcessMemory(
			IntPtr hProcess,
			IntPtr lpBaseAddress,
			byte[] lpBuffer,
			int nSize,
			out IntPtr lpNumberOfBytesWritten);

		[DllImport("kernel32.dll")]
		protected static extern bool VirtualProtectEx(
			IntPtr hProcess,
			IntPtr lpAddress,
			int nSize,
			uint flNewProtect,
			out uint lpflOldProtect);

		[DllImport("kernel32.dll", SetLastError = true)]
		protected static extern bool ReadProcessMemory(
			IntPtr hProcess,
			IntPtr lpBaseAddress,
			[Out] byte[] lpBuffer,
			int dwSize,
			out IntPtr lpNumberOfBytesRead);

		[DllImport("kernel32.dll")]
		protected static extern bool ReadProcessMemory(
			IntPtr hProcess,
			IntPtr lpBaseAdress,
			out IntPtr lpBuffer,
			uint iSize,
			out uint lpNumberOfBytesRead);
	}

	public class MemoryManager : ExternalDllMethods
	{
		#region private fields

		private IntPtr pHandle;

		private IntPtr baseAdr;

		#endregion


		#region constructors

		public MemoryManager(string processName)
		{
			pHandle = this.GetProcessHandle(processName);

			baseAdr = this.GetProcessAddress(processName);
		}

		#endregion


		#region public methods

		public void MakeWritable(IntPtr pointer, int count)
		{
			uint lpflOldProtect;
			ExternalDllMethods.VirtualProtectEx(pHandle, pointer, count, 0x08, out lpflOldProtect);
		}

		public void WriteInt(IntPtr pointer, int data)
		{
			IntPtr outP;
			ExternalDllMethods.WriteProcessMemory(pHandle, pointer, BitConverter.GetBytes(data), 4, out outP);
		}

		public int ReadInt(IntPtr pointer)
		{
			byte[] data = this.ReadBytes(pointer, 4);

			return BitConverter.ToInt32(data, 0);
		}

		public uint ReadUInt(IntPtr pointer)
		{
			byte[] data = this.ReadBytes(pointer, 4);

			return BitConverter.ToUInt32(data, 0);
		}

		public void WriteUShort(IntPtr pointer, ushort data)
		{
			IntPtr outP;
			ExternalDllMethods.WriteProcessMemory(pHandle, pointer, BitConverter.GetBytes(data), 2, out outP);
		}

		public void WriteShort(IntPtr pointer, short data)
		{
			IntPtr outP;
			ExternalDllMethods.WriteProcessMemory(pHandle, pointer, BitConverter.GetBytes(data), 2, out outP);
		}

		public short ReadShort(IntPtr pointer)
		{
			byte[] data = this.ReadBytes(pointer, 2);

			return BitConverter.ToInt16(data, 0);
		}

		public ushort ReadUShort(IntPtr pointer)
		{
			byte[] data = this.ReadBytes(pointer, 2);

			return BitConverter.ToUInt16(data, 0);
		}

		public void WriteFloat(int pointer, float data)
		{
			this.WriteFloat(new IntPtr(pointer), data);
		}

		public void WriteFloat(IntPtr pointer, float data)
		{
			IntPtr outP;
			ExternalDllMethods.WriteProcessMemory(pHandle, pointer, BitConverter.GetBytes(data), 4, out outP);
		}

		public float ReadFloat(IntPtr pointer)
		{
			byte[] data = this.ReadBytes(pointer, 4);

			return BitConverter.ToSingle(data, 0);
		}

		public float ReadFloat(int pointer)
		{
			return this.ReadFloat(new IntPtr(pointer));
		}


		public void WriteFloatMultiLevel(int[] offsets, float data)
		{
			this.WriteFloat(this.GetAbsoluteAddress(offsets), data);
		}

		public float ReadFloatMultiLevel(int[] offsets)
		{
			return this.ReadFloat(this.GetAbsoluteAddress(offsets));
		}


		public void WriteByte(IntPtr pointer, byte data)
		{
			this.WriteBytes(pointer, new byte[] { data });
		}

		public byte ReadByte(IntPtr pointer)
		{
			return this.ReadBytes(pointer, 1)[0];
		}


		public void WriteBytes(IntPtr pointer, byte[] data)
		{
			IntPtr outP;
			ExternalDllMethods.WriteProcessMemory(pHandle, pointer, data, data.Length, out outP);
		}

		public byte[] ReadBytes(IntPtr pointer, int count)
		{
			IntPtr outP;
			byte[] data = new byte[count];
			ExternalDllMethods.ReadProcessMemory(pHandle, pointer, data, count, out outP);

			return data;
		}

		public void WriteIntMultiLevel(int[] offsets, int data)
		{
			this.WriteInt(this.GetAbsoluteAddress(offsets), data);
		}

		public int ReadIntMultiLevel(int[] offsets)
		{
			return this.ReadInt(this.GetAbsoluteAddress(offsets));
		}

		public int ReadByteMultiLevel(int[] offsets)
		{
			return this.ReadByte(this.GetAbsoluteAddress(offsets));
		}

		public void WriteUShortMultiLevel(int[] offsets, ushort data)
		{
			this.WriteUShort(this.GetAbsoluteAddress(offsets), data);
		}

		public ushort ReadUShortMultiLevel(int[] offsets)
		{
			return this.ReadUShort(this.GetAbsoluteAddress(offsets));
		}

		#endregion


		#region private methods

		private IntPtr ReadPointer(IntPtr adress)
		{
			IntPtr tempPTR;
			uint NumberOfBytesRead;

			ReadProcessMemory(pHandle, adress, out tempPTR, 4, out NumberOfBytesRead);
			return tempPTR;
		}

		private IntPtr GetProcessHandle(string name)
		{
			Process[] pList = Process.GetProcesses();

			if (pList.Length == 0)
			{
				throw new Exception("No processes found");
			}

			foreach (var process in pList)
			{
				if (process.ProcessName == name)
				{
					return OpenProcess(ProcessAccessFlags.All, false, process.Id);
				}
			}

			throw new Exception("Process \"" + name + "\" not found!");
		}

		private IntPtr GetProcessAddress(string name)
		{
			Process[] pList = Process.GetProcesses();

			if (pList.Length == 0)
			{
				throw new Exception("No processes found");
			}

			foreach (var process in pList)
			{
				if (process.ProcessName == name)
				{
					return process.MainModule.BaseAddress;
				}
			}

			throw new Exception("Process \"" + name + "\" not found!");
		}

		public IntPtr GetAbsoluteAddress(int[] offsets)
		{
			IntPtr cur = baseAdr;

			for (int i = 0; i < offsets.Length - 1; i++)
			{
				cur = ReadPointer(IntPtr.Add(cur, offsets[i]));
			}

			cur = IntPtr.Add(cur, offsets[offsets.Length - 1]);

			return cur;
		}

		#endregion

	}
}
