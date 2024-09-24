/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

namespace System.Runtime
{
	public abstract class RuntimeLinkAttributeBase : Attribute
	{
		public string EntryPoint { get; }

		public RuntimeLinkAttributeBase(string entry)
		{
			this.EntryPoint = entry;
		}
	}

	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class RuntimeExportAttribute : RuntimeLinkAttributeBase
	{
		public RuntimeExportAttribute(string entry)
			: base(entry) { }
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, Inherited = false)]
	public sealed class RuntimeImportAttribute : RuntimeLinkAttributeBase
	{
		public string? DllName { get; }

		public RuntimeImportAttribute(string entry)
			: base(entry) { }

		public RuntimeImportAttribute(string dllName, string entry)
			: base(entry)
		{
			this.DllName = dllName;
		}
	}
}
