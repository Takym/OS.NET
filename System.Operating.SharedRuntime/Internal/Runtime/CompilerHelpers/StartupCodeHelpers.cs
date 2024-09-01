/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

using System;
using System.Runtime;

namespace Internal.Runtime.CompilerHelpers
{
	internal static class StartupCodeHelpers
	{
		[RuntimeExport(nameof(RhpReversePInvoke))]
		private static void RhpReversePInvoke(IntPtr frame) { }

		[RuntimeExport(nameof(RhpReversePInvokeReturn))]
		private static void RhpReversePInvokeReturn(IntPtr frame) { }

		[RuntimeExport(nameof(RhpPInvoke))]
		private static void RhpPInvoke(IntPtr frame) { }

		[RuntimeExport(nameof(RhpPInvokeReturn))]
		private static void RhpPInvokeReturn(IntPtr frame) { }

		[RuntimeExport(nameof(RhpFallbackFailFast))]
		private static void RhpFallbackFailFast() { while (true) ; }
	}
}
