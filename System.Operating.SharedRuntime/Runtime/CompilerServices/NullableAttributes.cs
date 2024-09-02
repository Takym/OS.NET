/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

using System.Diagnostics.CodeAnalysis;

namespace System.Runtime.CompilerServices
{
	[AttributeUsage(Nullable, Inherited = false)]
	public sealed class NullableAttribute : NullableAttributeBase
	{
		public readonly byte[] NullableFlags;

		public NullableAttribute(byte value)
		{
			NullableFlags = [ value ];
		}

		public NullableAttribute(byte[] value)
		{
			NullableFlags = value;
		}
	}

	[AttributeUsage(NullableContext, Inherited = false)]
	public sealed class NullableContextAttribute : NullableAttributeBase
	{
		public readonly byte Flag;

		public NullableContextAttribute(byte value)
		{
			Flag = value;
		}
	}
}
