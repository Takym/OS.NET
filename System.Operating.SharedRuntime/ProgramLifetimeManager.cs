/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

using System.Diagnostics.CodeAnalysis;

namespace System
{
	public static partial class ProgramLifetimeManager
	{
#pragma warning disable IDE0022 // メソッドに式本体を使用する
		[DoesNotReturn()]
		public static void Fail()
		{
#if HALT_LOOP_ENABLED
			HaltLoop();
#elif UEFI
			while (true) ;
#else
			throw null!;
#endif
		}
#pragma warning restore IDE0022 // メソッドに式本体を使用する

		[DoesNotReturn()]
		public static TReturnType Fail<TReturnType>()
		{
			Fail();
			return default;
		}
	}
}
