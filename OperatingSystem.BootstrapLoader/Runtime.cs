namespace System
{
	public class Object
	{
		public Object() { }

		~Object() { }

		public virtual bool Equals(object? obj)
		{
			return this == obj;
		}

		public static bool Equals(object? objA, object? objB)
		{
			if (objA == objB) {
				return true;
			}
			if (objA is null || objB is null) {
				return false;
			}
			return objA.Equals(objB);
		}

		public virtual int GetHashCode()
		{
			return 0;
		}

		public static bool ReferenceEquals(object? objA, object? objB)
		{
			return objA == objB;
		}

		public virtual string? ToString()
		{
			return string.Empty;
		}
	}

	public abstract class ValueType { }

	public readonly struct Enum { }

	public readonly struct Void { }

	public readonly struct Boolean { }

	public readonly struct Byte { }

	public readonly struct Int32 { }

	public sealed class String
	{
		public static readonly string Empty = "";
	}

	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public abstract class Attribute { }

	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	public sealed class FlagsAttribute : Attribute { }

	[Flags()]
	public enum AttributeTargets
	{
		All = 32767,
		Class = 4,
		Enum = 16
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public sealed class AttributeUsageAttribute : Attribute
	{
		public AttributeTargets ValidOn       { get; }
		public bool             AllowMultiple { get; set; }
		public bool             Inherited     { get; set; }

		public AttributeUsageAttribute(AttributeTargets validOn)
		{
			this.ValidOn = validOn;
		}
	}
}
