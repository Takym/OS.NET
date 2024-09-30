/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

namespace System.Runtime.CompilerServices
{
	public static class RuntimeFeature
	{
		public const string ByRefFields = nameof(ByRefFields);

		public static bool IsSupported(string feature)
			=> feature == ByRefFields;
	}
}
