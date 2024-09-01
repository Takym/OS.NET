/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

using System.Runtime;

namespace System.Operating.BootstrapLoader
{
	internal static class Program
	{
		[RuntimeExport(nameof(UefiMain))]
		private static long UefiMain(IntPtr ImageHandle, IntPtr SystemTable) => 0;

		//private static int Main() => 0;
	}
}
