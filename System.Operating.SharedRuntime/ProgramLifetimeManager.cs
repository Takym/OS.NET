/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

using System.Diagnostics.CodeAnalysis;

namespace System
{
	public static class ProgramLifetimeManager
	{
		[DoesNotReturn()]
		public static void Fail()
		{
#if UEFI
			while (true) ;
#else
#pragma warning disable IDE0022 // メソッドに式本体を使用する
			throw null!;
#pragma warning restore IDE0022 // メソッドに式本体を使用する
#endif
		}

		[DoesNotReturn()]
		public static TReturnType Fail<TReturnType>()
		{
			Fail();
			return default;
		}
	}
}
