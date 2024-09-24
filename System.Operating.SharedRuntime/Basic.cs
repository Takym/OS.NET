/****
 * OS.NET
 * Copyright (C) 2024 Takym.
 *
 * distributed under the MIT License.
****/

namespace System
{
	public class Object;

	public sealed class String;

	public class Exception;

	public abstract class ValueType;
	public abstract class Enum : ValueType;
	public abstract class Array;
	public abstract class Delegate;
	public abstract class MulticastDelegate : Delegate;

	public readonly struct Char;
	public readonly struct Boolean;
	public readonly struct Byte;
	public readonly struct UInt16;
	public readonly struct UInt32;
	public readonly struct UInt64;
	public readonly struct UIntPtr;
	public readonly struct SByte;
	public readonly struct Int16;
	public readonly struct Int32;
	public readonly struct Int64;
	public readonly struct IntPtr;
	public readonly struct Single;
	public readonly struct Double;
	public readonly struct Void;

	public readonly struct Nullable<T> where T: struct;

	public abstract class Attribute;

	[AttributeUsage(AttributeTargets.Enum, Inherited = false)]
	public class FlagsAttribute : Attribute;

	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = true)]
	public sealed class ParamArrayAttribute : Attribute;

	public struct RuntimeTypeHandle;
	public struct RuntimeMethodHandle;
	public struct RuntimeFieldHandle;
}
