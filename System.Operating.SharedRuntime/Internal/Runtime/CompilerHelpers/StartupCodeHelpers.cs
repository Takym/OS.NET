/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

#pragma warning disable IDE0060 // 未使用のパラメーターを削除します
#pragma warning disable IDE0130 // Namespace がフォルダー構造と一致しません

using System;
using System.Diagnostics.CodeAnalysis;
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

		[DoesNotReturn()]
		[RuntimeExport(nameof(RhpFallbackFailFast))]
		private static void RhpFallbackFailFast()
			=> ProgramLifetimeManager.Fail();
	}
}
