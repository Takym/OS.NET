/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

using System.Operating.BootstrapLoader.UEFI;
using System.Runtime;

namespace System.Operating.BootstrapLoader
{
	internal static class Program
	{
		[RuntimeExport(nameof(UefiMain))]
		private static EFIStatus UefiMain(EFIHandle ImageHandle, IntPtr SystemTable)
		{
			return EFIStatus.EFI_SUCCESS;
		}

		//private static int Main() => 0;
	}
}
