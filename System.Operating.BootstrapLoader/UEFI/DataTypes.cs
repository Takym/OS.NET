/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

using System.Runtime.InteropServices;

namespace System.Operating.BootstrapLoader.UEFI
{
	[StructLayout(LayoutKind.Explicit, Size = 2, Pack = 1)]
	public struct Data02Bytes
	{
		public byte this[int index]
		{
			readonly get => index switch {
				0 => Field0,
				1 => Field1,
				_ => ProgramLifetimeManager.Fail<byte>()
			};

			set
			{
				switch (index) {
				case 0: Field0 = value; break;
				case 1: Field1 = value; break;
				default:
					ProgramLifetimeManager.Fail();
					break;
				}
			}
		}

		[FieldOffset(0)] public ushort Value;
		[FieldOffset(0)] public byte   Field0;
		[FieldOffset(1)] public byte   Field1;
	}

	[StructLayout(LayoutKind.Explicit, Size = 4, Pack = 1)]
	public struct Data04Bytes
	{
		public byte this[int index]
		{
			readonly get => index switch {
				0 => Field0,
				1 => Field1,
				2 => Field2,
				3 => Field3,
				_ => ProgramLifetimeManager.Fail<byte>()
			};

			set
			{
				switch (index) {
				case 0: Field0 = value; break;
				case 1: Field1 = value; break;
				case 2: Field2 = value; break;
				case 3: Field3 = value; break;
				default:
					ProgramLifetimeManager.Fail();
					break;
				}
			}
		}

		[FieldOffset(0)] public uint        Value;
		[FieldOffset(0)] public Data02Bytes Low;
		[FieldOffset(2)] public Data02Bytes High;
		[FieldOffset(0)] public byte        Field0;
		[FieldOffset(1)] public byte        Field1;
		[FieldOffset(2)] public byte        Field2;
		[FieldOffset(3)] public byte        Field3;
	}

	[StructLayout(LayoutKind.Explicit, Size = 8, Pack = 1)]
	public struct Data08Bytes
	{
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
				case 0: Field0 = value; break;
				case 1: Field1 = value; break;
				case 2: Field2 = value; break;
				case 3: Field3 = value; break;
				case 4: Field4 = value; break;
				case 5: Field5 = value; break;
				case 6: Field6 = value; break;
				case 7: Field7 = value; break;
				default:
					ProgramLifetimeManager.Fail();
					break;
				}
			}
		}

		[FieldOffset(0)] public ulong       Value;
		[FieldOffset(0)] public Data04Bytes Low;
		[FieldOffset(4)] public Data04Bytes High;
		[FieldOffset(0)] public byte        Field0;
		[FieldOffset(1)] public byte        Field1;
		[FieldOffset(2)] public byte        Field2;
		[FieldOffset(3)] public byte        Field3;
		[FieldOffset(4)] public byte        Field4;
		[FieldOffset(5)] public byte        Field5;
		[FieldOffset(6)] public byte        Field6;
		[FieldOffset(7)] public byte        Field7;
	}

	[StructLayout(LayoutKind.Explicit, Size = 16, Pack = 1)]
	public struct Data16Bytes
	{
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
				 8 => Field8,
				 9 => Field9,
				10 => FieldA,
				11 => FieldB,
				12 => FieldC,
				13 => FieldD,
				14 => FieldE,
				15 => FieldF,
				_  => ProgramLifetimeManager.Fail<byte>()
			};

			set
			{
				switch (index) {
				case  0: Field0 = value; break;
				case  1: Field1 = value; break;
				case  2: Field2 = value; break;
				case  3: Field3 = value; break;
				case  4: Field4 = value; break;
				case  5: Field5 = value; break;
				case  6: Field6 = value; break;
				case  7: Field7 = value; break;
				case  8: Field8 = value; break;
				case  9: Field9 = value; break;
				case 10: FieldA = value; break;
				case 11: FieldB = value; break;
				case 12: FieldC = value; break;
				case 13: FieldD = value; break;
				case 14: FieldE = value; break;
				case 15: FieldF = value; break;
				default:
					ProgramLifetimeManager.Fail();
					break;
				}
			}
		}

		[FieldOffset( 0)] public Data08Bytes Low;
		[FieldOffset( 8)] public Data08Bytes High;
		[FieldOffset( 0)] public byte        Field0;
		[FieldOffset( 1)] public byte        Field1;
		[FieldOffset( 2)] public byte        Field2;
		[FieldOffset( 3)] public byte        Field3;
		[FieldOffset( 4)] public byte        Field4;
		[FieldOffset( 5)] public byte        Field5;
		[FieldOffset( 6)] public byte        Field6;
		[FieldOffset( 7)] public byte        Field7;
		[FieldOffset( 8)] public byte        Field8;
		[FieldOffset( 9)] public byte        Field9;
		[FieldOffset(10)] public byte        FieldA;
		[FieldOffset(11)] public byte        FieldB;
		[FieldOffset(12)] public byte        FieldC;
		[FieldOffset(13)] public byte        FieldD;
		[FieldOffset(14)] public byte        FieldE;
		[FieldOffset(15)] public byte        FieldF;
	}
}
