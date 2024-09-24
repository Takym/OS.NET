/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

namespace System.Diagnostics.CodeAnalysis
{
	public abstract class NullableAttributeBase : Attribute
	{
		protected const AttributeTargets Variable        = AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property;
		protected const AttributeTargets Expression      = Variable | AttributeTargets.ReturnValue;
		protected const AttributeTargets Output          = Expression & ~AttributeTargets.Field;
		protected const AttributeTargets Member          = AttributeTargets.Method | AttributeTargets.Property;
		protected const AttributeTargets Nullable        = Expression | AttributeTargets.Class | AttributeTargets.Event | AttributeTargets.GenericParameter;
		protected const AttributeTargets NullableContext = AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate;
	}

	[AttributeUsage(Variable, Inherited = false)]
	public sealed class AllowNullAttribute : NullableAttributeBase;

	[AttributeUsage(Variable, Inherited = false)]
	public sealed class DisallowNullAttribute : NullableAttributeBase;

	[AttributeUsage(Expression, Inherited = false)]
	public sealed class NotNullAttribute : NullableAttributeBase;

	[AttributeUsage(Output, Inherited = false)]
	public sealed class NotNullIfNotNullAttribute : NullableAttributeBase
	{
		public string ParameterName { get; }

		public NotNullIfNotNullAttribute(string parameterName)
		{
			this.ParameterName = parameterName;
		}
	}

	[AttributeUsage(Expression, Inherited = false)]
	public sealed class MaybeNullAttribute : NullableAttributeBase;

	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class MaybeNullWhenAttribute : NullableAttributeBase
	{
		public bool ReturnValue { get; }

		public MaybeNullWhenAttribute(bool returnValue)
		{
			this.ReturnValue = returnValue;
		}
	}

	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class DoesNotReturnAttribute : NullableAttributeBase;

	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class DoesNotReturnIfAttribute : NullableAttributeBase
	{
		public bool ParameterValue { get; }

		public DoesNotReturnIfAttribute(bool parameterValue)
		{
			this.ParameterValue = parameterValue;
		}
	}

	[AttributeUsage(Member, AllowMultiple = true, Inherited = false)]
	public sealed class MemberNotNullAttribute : NullableAttributeBase
	{
		public string[] Members { get; }

		public MemberNotNullAttribute(string member)
		{
			this.Members = [ member ];
		}

		public MemberNotNullAttribute(params string[] members)
		{
			this.Members = members;
		}
	}

	[AttributeUsage(Member, AllowMultiple = true, Inherited = false)]
	public sealed class MemberNotNullWhenAttribute : NullableAttributeBase
	{
		public bool     ReturnValue { get; }
		public string[] Members     { get; }

		public MemberNotNullWhenAttribute(bool returnValue, string member)
		{
			this.ReturnValue = returnValue;
			this.Members     = [member];
		}

		public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
		{
			this.ReturnValue = returnValue;
			this.Members     = members;
		}
	}
}
