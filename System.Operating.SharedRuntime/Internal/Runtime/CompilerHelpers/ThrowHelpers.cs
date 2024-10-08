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
using Internal.TypeSystem;

namespace Internal.Runtime.CompilerHelpers
{
	internal static class ThrowHelpers
	{
		[DoesNotReturn()]
		internal static void ThrowTypeLoadException(ExceptionStringID id, string className, string typeName)
			=> ProgramLifetimeManager.Fail();

		[DoesNotReturn()]
		internal static void ThrowInvalidProgramException(ExceptionStringID id)
			=> ProgramLifetimeManager.Fail();

		[DoesNotReturn()]
		internal static void ThrowInvalidProgramExceptionWithArgument(ExceptionStringID id, string methodName)
			=> ProgramLifetimeManager.Fail();
	}
}
