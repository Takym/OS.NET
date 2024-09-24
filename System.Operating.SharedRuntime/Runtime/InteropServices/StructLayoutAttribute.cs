/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

namespace System.Runtime.InteropServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public sealed class StructLayoutAttribute : Attribute
	{
		public int     Pack;
		public int     Size;
		public CharSet CharSet;

		public LayoutKind Value { get; }

		public StructLayoutAttribute(LayoutKind layoutKind)
		{
			this.Value = layoutKind;
		}
	}

	public enum LayoutKind
	{
		Sequential,
		Reserved1,
		Explicit,
		Auto
	}

	public enum CharSet
	{
		Reserved0,
		None,
		Ansi,
		Unicode,
		Auto
	}
}
