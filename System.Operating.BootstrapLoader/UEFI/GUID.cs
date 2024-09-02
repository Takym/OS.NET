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
		public uint      Data1;
		public ushort    Data2;
		public ushort    Data3;
		public Data4Type Data4;

		[StructLayout(LayoutKind.Explicit, Size = 8, Pack = 1)]
		public struct Data4Type // TODO: IEnumerable
		{
			[FieldOffset(0)]
			public ulong Value;

			public byte this[int index]
			{
				readonly get => index switch {
					0 => Field0,
					1 => Field1,
					2 => Field2,
					3 => Field3,
					4 => Field4,
					5 => Field5,
					6 => Field6,
					7 => Field7,
					_ => ProgramLifetimeManager.Fail<byte>()
				};

				set
				{
					switch (index) {
					case 0:
						Field0 = value;
						break;
					case 1:
						Field1 = value;
						break;
					case 2:
						Field2 = value;
						break;
					case 3:
						Field3 = value;
						break;
					case 4:
						Field4 = value;
						break;
					case 5:
						Field5 = value;
						break;
					case 6:
						Field6 = value;
						break;
					case 7:
						Field7 = value;
						break;
					default:
						ProgramLifetimeManager.Fail();
						break;
					}
				}
			}

			[FieldOffset(0)] public byte Field0;
			[FieldOffset(1)] public byte Field1;
			[FieldOffset(2)] public byte Field2;
			[FieldOffset(3)] public byte Field3;
			[FieldOffset(4)] public byte Field4;
			[FieldOffset(5)] public byte Field5;
			[FieldOffset(6)] public byte Field6;
			[FieldOffset(7)] public byte Field7;
		}
	}
}
