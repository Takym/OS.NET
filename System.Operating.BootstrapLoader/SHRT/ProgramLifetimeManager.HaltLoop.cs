/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

using System.Diagnostics.CodeAnalysis;
using System.Runtime;

namespace System
{
	partial class ProgramLifetimeManager
	{
		[DoesNotReturn()]
		[RuntimeImport(nameof(HaltLoop))]
		private static extern void HaltLoop();
	}
}
