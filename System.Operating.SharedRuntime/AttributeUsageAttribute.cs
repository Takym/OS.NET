/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

namespace System
{
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public sealed class AttributeUsageAttribute : Attribute
	{
		public AttributeTargets ValidOn       { get; }
		public bool             AllowMultiple { get; set; }
		public bool             Inherited     { get; set; }

		public AttributeUsageAttribute(AttributeTargets validOn)
		{
			this.ValidOn       = validOn;
			this.AllowMultiple = false;
			this.Inherited     = true;
		}
	}
}
