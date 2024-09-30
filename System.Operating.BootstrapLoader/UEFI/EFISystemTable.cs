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
	public readonly ref struct EFISystemTable
	{
		public readonly              EFITableHeader Hdr;
		public readonly ref readonly char           FirmwareVendor;
		public readonly              uint           FirmwareRevision;
		public readonly              EFIHandle      ConsoleInHandle;
		//EFI_SIMPLE_TEXT_INPUT_PROTOCOL   *ConIn;
		public readonly              EFIHandle      ConsoleOutHandle;
		//EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL  *ConOut;
		public readonly              EFIHandle      StandardErrorHandle;
		//EFI_SIMPLE_TEXT_OUTPUT_PROTOCOL  *StdErr;
		//EFI_RUNTIME_SERVICES             *RuntimeServices;
		//EFI_BOOT_SERVICES                *BootServices;
		public readonly nuint NumberOfTableEntries;
		//EFI_CONFIGURATION_TABLE          *ConfigurationTable;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public readonly struct EFITableHeader
	{
		public readonly ulong Signature;
		public readonly uint  Revision;
		public readonly uint  HeaderSize;
		public readonly uint  CRC32;
		public readonly uint  Reserved;
	}
}
