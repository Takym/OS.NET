/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

using System.Runtime.InteropServices;

namespace System.Operating.BootstrapLoader.UEFI
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GUID
	{
		public uint        Data1;
		public ushort      Data2;
		public ushort      Data3;
		public Data08Bytes Data4;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IPv4_ADDRESS
	{
		public Data04Bytes Addr;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IPv6_ADDRESS
	{
		public Data16Bytes Addr;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public readonly struct PHYSICAL_ADDRESS
	{
		public readonly ulong Value;

		public PHYSICAL_ADDRESS(ulong value)
		{
			Value = value;
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public readonly struct EFIHandle
	{
		public readonly nuint Value;

		public EFIHandle(nuint value)
		{
			Value = value;
		}
	}
}
