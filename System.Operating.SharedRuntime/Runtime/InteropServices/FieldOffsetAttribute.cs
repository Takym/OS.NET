/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

namespace System.Runtime.InteropServices
{
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	public sealed class FieldOffsetAttribute : Attribute
	{
		public int Value { get; }

		public FieldOffsetAttribute(int offset)
		{
			this.Value = offset;
		}
	}
}
