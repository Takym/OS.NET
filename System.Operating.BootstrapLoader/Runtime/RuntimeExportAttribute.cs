/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

namespace System.Runtime
{
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class RuntimeExportAttribute : Attribute
	{
		public string Entry { get; }

		public RuntimeExportAttribute(string entry)
		{
			this.Entry = entry;
		}
	}
}
