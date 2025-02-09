using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnionTypes;

/// <summary>
/// Indicates which constituent value is used by a union type instance
/// </summary>
[GeneratedCode("Aldaviva/UnionTypes", null)]
public enum Union15Index {

    /// <summary>Union type's value is of the union's 1st type</summary>
    Value1 = 1,

    /// <summary>Union type's value is of the union's 2nd type</summary>
    Value2 = 2,

    /// <summary>Union type's value is of the union's 3rd type</summary>
    Value3 = 3,

    /// <summary>Union type's value is of the union's 4th type</summary>
    Value4 = 4,

    /// <summary>Union type's value is of the union's 5th type</summary>
    Value5 = 5,

    /// <summary>Union type's value is of the union's 6th type</summary>
    Value6 = 6,

    /// <summary>Union type's value is of the union's 7th type</summary>
    Value7 = 7,

    /// <summary>Union type's value is of the union's 8th type</summary>
    Value8 = 8,

    /// <summary>Union type's value is of the union's 9th type</summary>
    Value9 = 9,

    /// <summary>Union type's value is of the union's 10th type</summary>
    Value10 = 10,

    /// <summary>Union type's value is of the union's 11th type</summary>
    Value11 = 11,

    /// <summary>Union type's value is of the union's 12th type</summary>
    Value12 = 12,

    /// <summary>Union type's value is of the union's 13th type</summary>
    Value13 = 13,

    /// <summary>Union type's value is of the union's 14th type</summary>
    Value14 = 14,

    /// <summary>Union type's value is of the union's 15th type</summary>
    Value15 = 15

}

/// <summary>
/// A union type whose value can be 1 of 15 possible types.
/// </summary>
/// <typeparam name="T1">Possible type of value 1</typeparam>
/// <typeparam name="T2">Possible type of value 2</typeparam>
/// <typeparam name="T3">Possible type of value 3</typeparam>
/// <typeparam name="T4">Possible type of value 4</typeparam>
/// <typeparam name="T5">Possible type of value 5</typeparam>
/// <typeparam name="T6">Possible type of value 6</typeparam>
/// <typeparam name="T7">Possible type of value 7</typeparam>
/// <typeparam name="T8">Possible type of value 8</typeparam>
/// <typeparam name="T9">Possible type of value 9</typeparam>
/// <typeparam name="T10">Possible type of value 10</typeparam>
/// <typeparam name="T11">Possible type of value 11</typeparam>
/// <typeparam name="T12">Possible type of value 12</typeparam>
/// <typeparam name="T13">Possible type of value 13</typeparam>
/// <typeparam name="T14">Possible type of value 14</typeparam>
/// <typeparam name="T15">Possible type of value 15</typeparam>
[GeneratedCode("Aldaviva/UnionTypes", null)]
[DebuggerDisplay("{Value}")]
public readonly struct Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>: IUnion, IEquatable<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> {
  
    /// <summary>
    /// Which constituent type the value current has
    /// </summary>
    public Union15Index ValueIndex { get; }
    
    /// <summary>The value of the union type if <see cref="HasValue1"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value1"/>; otherwise <c>default</c>.</summary>
    public T1? Value1 { get; }

    /// <summary>The value of the union type if <see cref="HasValue2"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value2"/>; otherwise <c>default</c>.</summary>
    public T2? Value2 { get; }

    /// <summary>The value of the union type if <see cref="HasValue3"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value3"/>; otherwise <c>default</c>.</summary>
    public T3? Value3 { get; }

    /// <summary>The value of the union type if <see cref="HasValue4"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value4"/>; otherwise <c>default</c>.</summary>
    public T4? Value4 { get; }

    /// <summary>The value of the union type if <see cref="HasValue5"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value5"/>; otherwise <c>default</c>.</summary>
    public T5? Value5 { get; }

    /// <summary>The value of the union type if <see cref="HasValue6"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value6"/>; otherwise <c>default</c>.</summary>
    public T6? Value6 { get; }

    /// <summary>The value of the union type if <see cref="HasValue7"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value7"/>; otherwise <c>default</c>.</summary>
    public T7? Value7 { get; }

    /// <summary>The value of the union type if <see cref="HasValue8"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value8"/>; otherwise <c>default</c>.</summary>
    public T8? Value8 { get; }

    /// <summary>The value of the union type if <see cref="HasValue9"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value9"/>; otherwise <c>default</c>.</summary>
    public T9? Value9 { get; }

    /// <summary>The value of the union type if <see cref="HasValue10"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value10"/>; otherwise <c>default</c>.</summary>
    public T10? Value10 { get; }

    /// <summary>The value of the union type if <see cref="HasValue11"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value11"/>; otherwise <c>default</c>.</summary>
    public T11? Value11 { get; }

    /// <summary>The value of the union type if <see cref="HasValue12"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value12"/>; otherwise <c>default</c>.</summary>
    public T12? Value12 { get; }

    /// <summary>The value of the union type if <see cref="HasValue13"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value13"/>; otherwise <c>default</c>.</summary>
    public T13? Value13 { get; }

    /// <summary>The value of the union type if <see cref="HasValue14"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value14"/>; otherwise <c>default</c>.</summary>
    public T14? Value14 { get; }

    /// <summary>The value of the union type if <see cref="HasValue15"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union15Index.Value15"/>; otherwise <c>default</c>.</summary>
    public T15? Value15 { get; }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value1">The value of the union type</param>
    public Union(T1 value1) {
        Value1 = value1;
        ValueIndex = Union15Index.Value1;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value2">The value of the union type</param>
    public Union(T2 value2) {
        Value2 = value2;
        ValueIndex = Union15Index.Value2;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value3">The value of the union type</param>
    public Union(T3 value3) {
        Value3 = value3;
        ValueIndex = Union15Index.Value3;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value4">The value of the union type</param>
    public Union(T4 value4) {
        Value4 = value4;
        ValueIndex = Union15Index.Value4;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value5">The value of the union type</param>
    public Union(T5 value5) {
        Value5 = value5;
        ValueIndex = Union15Index.Value5;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value6">The value of the union type</param>
    public Union(T6 value6) {
        Value6 = value6;
        ValueIndex = Union15Index.Value6;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value7">The value of the union type</param>
    public Union(T7 value7) {
        Value7 = value7;
        ValueIndex = Union15Index.Value7;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value8">The value of the union type</param>
    public Union(T8 value8) {
        Value8 = value8;
        ValueIndex = Union15Index.Value8;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value9">The value of the union type</param>
    public Union(T9 value9) {
        Value9 = value9;
        ValueIndex = Union15Index.Value9;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value10">The value of the union type</param>
    public Union(T10 value10) {
        Value10 = value10;
        ValueIndex = Union15Index.Value10;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value11">The value of the union type</param>
    public Union(T11 value11) {
        Value11 = value11;
        ValueIndex = Union15Index.Value11;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value12">The value of the union type</param>
    public Union(T12 value12) {
        Value12 = value12;
        ValueIndex = Union15Index.Value12;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value13">The value of the union type</param>
    public Union(T13 value13) {
        Value13 = value13;
        ValueIndex = Union15Index.Value13;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value14">The value of the union type</param>
    public Union(T14 value14) {
        Value14 = value14;
        ValueIndex = Union15Index.Value14;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value15">The value of the union type</param>
    public Union(T15 value15) {
        Value15 = value15;
        ValueIndex = Union15Index.Value15;
    }
  
    /// <inheritdoc />
    public object? Value => ValueIndex switch {
        Union15Index.Value1 => Value1,
        Union15Index.Value2 => Value2,
        Union15Index.Value3 => Value3,
        Union15Index.Value4 => Value4,
        Union15Index.Value5 => Value5,
        Union15Index.Value6 => Value6,
        Union15Index.Value7 => Value7,
        Union15Index.Value8 => Value8,
        Union15Index.Value9 => Value9,
        Union15Index.Value10 => Value10,
        Union15Index.Value11 => Value11,
        Union15Index.Value12 => Value12,
        Union15Index.Value13 => Value13,
        Union15Index.Value14 => Value14,
        Union15Index.Value15 => Value15
    };
    
    /// <inheritdoc />
    public Type ValueType => ValueIndex switch {
        Union15Index.Value1 => typeof(T1),
        Union15Index.Value2 => typeof(T2),
        Union15Index.Value3 => typeof(T3),
        Union15Index.Value4 => typeof(T4),
        Union15Index.Value5 => typeof(T5),
        Union15Index.Value6 => typeof(T6),
        Union15Index.Value7 => typeof(T7),
        Union15Index.Value8 => typeof(T8),
        Union15Index.Value9 => typeof(T9),
        Union15Index.Value10 => typeof(T10),
        Union15Index.Value11 => typeof(T11),
        Union15Index.Value12 => typeof(T12),
        Union15Index.Value13 => typeof(T13),
        Union15Index.Value14 => typeof(T14),
        Union15Index.Value15 => typeof(T15)
    };
    
    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue1 => ValueIndex == Union15Index.Value1;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue2 => ValueIndex == Union15Index.Value2;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue3 => ValueIndex == Union15Index.Value3;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue4 => ValueIndex == Union15Index.Value4;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue5 => ValueIndex == Union15Index.Value5;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue6 => ValueIndex == Union15Index.Value6;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue7 => ValueIndex == Union15Index.Value7;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue8 => ValueIndex == Union15Index.Value8;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue9 => ValueIndex == Union15Index.Value9;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue10 => ValueIndex == Union15Index.Value10;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue11 => ValueIndex == Union15Index.Value11;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue12 => ValueIndex == Union15Index.Value12;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue13 => ValueIndex == Union15Index.Value13;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue14 => ValueIndex == Union15Index.Value14;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue15 => ValueIndex == Union15Index.Value15;

    /// <summary>
    /// Execute an action depending on which type the value is
    /// </summary>
    public void Switch(Action<T1> case1, Action<T2> case2, Action<T3> case3, Action<T4> case4, Action<T5> case5, Action<T6> case6, Action<T7> case7, Action<T8> case8, Action<T9> case9, Action<T10> case10, Action<T11> case11, Action<T12> case12, Action<T13> case13, Action<T14> case14, Action<T15> case15) {
        switch (ValueIndex) {
            case Union15Index.Value1:
                case1(Value1!);
                break;
            case Union15Index.Value2:
                case2(Value2!);
                break;
            case Union15Index.Value3:
                case3(Value3!);
                break;
            case Union15Index.Value4:
                case4(Value4!);
                break;
            case Union15Index.Value5:
                case5(Value5!);
                break;
            case Union15Index.Value6:
                case6(Value6!);
                break;
            case Union15Index.Value7:
                case7(Value7!);
                break;
            case Union15Index.Value8:
                case8(Value8!);
                break;
            case Union15Index.Value9:
                case9(Value9!);
                break;
            case Union15Index.Value10:
                case10(Value10!);
                break;
            case Union15Index.Value11:
                case11(Value11!);
                break;
            case Union15Index.Value12:
                case12(Value12!);
                break;
            case Union15Index.Value13:
                case13(Value13!);
                break;
            case Union15Index.Value14:
                case14(Value14!);
                break;
            case Union15Index.Value15:
                case15(Value15!);
                break;
        }
    }
    
    /// <summary>
    /// Evaluate an expression depending on which type the value is
    /// </summary>
    public TResult Switch<TResult>(Func<T1, TResult> case1, Func<T2, TResult> case2, Func<T3, TResult> case3, Func<T4, TResult> case4, Func<T5, TResult> case5, Func<T6, TResult> case6, Func<T7, TResult> case7, Func<T8, TResult> case8, Func<T9, TResult> case9, Func<T10, TResult> case10, Func<T11, TResult> case11, Func<T12, TResult> case12, Func<T13, TResult> case13, Func<T14, TResult> case14, Func<T15, TResult> case15) => ValueIndex switch {
        Union15Index.Value1 => case1(Value1!),
        Union15Index.Value2 => case2(Value2!),
        Union15Index.Value3 => case3(Value3!),
        Union15Index.Value4 => case4(Value4!),
        Union15Index.Value5 => case5(Value5!),
        Union15Index.Value6 => case6(Value6!),
        Union15Index.Value7 => case7(Value7!),
        Union15Index.Value8 => case8(Value8!),
        Union15Index.Value9 => case9(Value9!),
        Union15Index.Value10 => case10(Value10!),
        Union15Index.Value11 => case11(Value11!),
        Union15Index.Value12 => case12(Value12!),
        Union15Index.Value13 => case13(Value13!),
        Union15Index.Value14 => case14(Value14!),
        Union15Index.Value15 => case15(Value15!)
    };
    
    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 value) => new(value);
    
    /// <inheritdoc cref="Object.ToString"/>
    public override string ToString() => ValueIndex switch {
        Union15Index.Value1 => Value1!.ToString(),
        Union15Index.Value2 => Value2!.ToString(),
        Union15Index.Value3 => Value3!.ToString(),
        Union15Index.Value4 => Value4!.ToString(),
        Union15Index.Value5 => Value5!.ToString(),
        Union15Index.Value6 => Value6!.ToString(),
        Union15Index.Value7 => Value7!.ToString(),
        Union15Index.Value8 => Value8!.ToString(),
        Union15Index.Value9 => Value9!.ToString(),
        Union15Index.Value10 => Value10!.ToString(),
        Union15Index.Value11 => Value11!.ToString(),
        Union15Index.Value12 => Value12!.ToString(),
        Union15Index.Value13 => Value13!.ToString(),
        Union15Index.Value14 => Value14!.ToString(),
        Union15Index.Value15 => Value15!.ToString()
    };
    
    /// <inheritdoc />
    public bool Equals(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other) => ValueIndex switch {
        Union15Index.Value1 when other.ValueIndex is Union15Index.Value1 => EqualityComparer<T1>.Default.Equals(Value1!, other.Value1!),
        Union15Index.Value2 when other.ValueIndex is Union15Index.Value2 => EqualityComparer<T2>.Default.Equals(Value2!, other.Value2!),
        Union15Index.Value3 when other.ValueIndex is Union15Index.Value3 => EqualityComparer<T3>.Default.Equals(Value3!, other.Value3!),
        Union15Index.Value4 when other.ValueIndex is Union15Index.Value4 => EqualityComparer<T4>.Default.Equals(Value4!, other.Value4!),
        Union15Index.Value5 when other.ValueIndex is Union15Index.Value5 => EqualityComparer<T5>.Default.Equals(Value5!, other.Value5!),
        Union15Index.Value6 when other.ValueIndex is Union15Index.Value6 => EqualityComparer<T6>.Default.Equals(Value6!, other.Value6!),
        Union15Index.Value7 when other.ValueIndex is Union15Index.Value7 => EqualityComparer<T7>.Default.Equals(Value7!, other.Value7!),
        Union15Index.Value8 when other.ValueIndex is Union15Index.Value8 => EqualityComparer<T8>.Default.Equals(Value8!, other.Value8!),
        Union15Index.Value9 when other.ValueIndex is Union15Index.Value9 => EqualityComparer<T9>.Default.Equals(Value9!, other.Value9!),
        Union15Index.Value10 when other.ValueIndex is Union15Index.Value10 => EqualityComparer<T10>.Default.Equals(Value10!, other.Value10!),
        Union15Index.Value11 when other.ValueIndex is Union15Index.Value11 => EqualityComparer<T11>.Default.Equals(Value11!, other.Value11!),
        Union15Index.Value12 when other.ValueIndex is Union15Index.Value12 => EqualityComparer<T12>.Default.Equals(Value12!, other.Value12!),
        Union15Index.Value13 when other.ValueIndex is Union15Index.Value13 => EqualityComparer<T13>.Default.Equals(Value13!, other.Value13!),
        Union15Index.Value14 when other.ValueIndex is Union15Index.Value14 => EqualityComparer<T14>.Default.Equals(Value14!, other.Value14!),
        Union15Index.Value15 when other.ValueIndex is Union15Index.Value15 => EqualityComparer<T15>.Default.Equals(Value15!, other.Value15!),
        _ => Value?.Equals(other.Value) ?? other.Value is null
    };
    
    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T1? other) => ValueIndex switch {
        Union15Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T2? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T3? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T4? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other),
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T5? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => EqualityComparer<T5?>.Default.Equals(Value5, other),
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T6? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => EqualityComparer<T6?>.Default.Equals(Value6, other),
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T7? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => EqualityComparer<T7?>.Default.Equals(Value7, other),
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T8? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => EqualityComparer<T8?>.Default.Equals(Value8, other),
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T9? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => EqualityComparer<T9?>.Default.Equals(Value9, other),
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T10? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => EqualityComparer<T10?>.Default.Equals(Value10, other),
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T11? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => EqualityComparer<T11?>.Default.Equals(Value11, other),
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T12? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => EqualityComparer<T12?>.Default.Equals(Value12, other),
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T13? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => EqualityComparer<T13?>.Default.Equals(Value13, other),
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T14? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => EqualityComparer<T14?>.Default.Equals(Value14, other),
        Union15Index.Value15 => Value15 is not null ? Value15.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T15? other) => ValueIndex switch {
        Union15Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union15Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union15Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union15Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union15Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union15Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union15Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union15Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union15Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union15Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union15Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union15Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union15Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null,
        Union15Index.Value14 => Value14 is not null ? Value14.Equals(other) : other is null,
        Union15Index.Value15 => EqualityComparer<T15?>.Default.Equals(Value15, other)
    };
          
    /// <inheritdoc />
    public override bool Equals(object? obj) => obj switch {
        Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other => Equals(other),
        IUnion other => Value?.Equals(other.Value) ?? other.Value is null,
        T1 other when ValueIndex is Union15Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        T2 other when ValueIndex is Union15Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        T3 other when ValueIndex is Union15Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        T4 other when ValueIndex is Union15Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other),
        T5 other when ValueIndex is Union15Index.Value5 => EqualityComparer<T5?>.Default.Equals(Value5, other),
        T6 other when ValueIndex is Union15Index.Value6 => EqualityComparer<T6?>.Default.Equals(Value6, other),
        T7 other when ValueIndex is Union15Index.Value7 => EqualityComparer<T7?>.Default.Equals(Value7, other),
        T8 other when ValueIndex is Union15Index.Value8 => EqualityComparer<T8?>.Default.Equals(Value8, other),
        T9 other when ValueIndex is Union15Index.Value9 => EqualityComparer<T9?>.Default.Equals(Value9, other),
        T10 other when ValueIndex is Union15Index.Value10 => EqualityComparer<T10?>.Default.Equals(Value10, other),
        T11 other when ValueIndex is Union15Index.Value11 => EqualityComparer<T11?>.Default.Equals(Value11, other),
        T12 other when ValueIndex is Union15Index.Value12 => EqualityComparer<T12?>.Default.Equals(Value12, other),
        T13 other when ValueIndex is Union15Index.Value13 => EqualityComparer<T13?>.Default.Equals(Value13, other),
        T14 other when ValueIndex is Union15Index.Value14 => EqualityComparer<T14?>.Default.Equals(Value14, other),
        T15 other when ValueIndex is Union15Index.Value15 => EqualityComparer<T15?>.Default.Equals(Value15, other),
        _ => false
    };
    
    /// <inheritdoc />
    public override int GetHashCode() => ValueIndex switch {
        Union15Index.Value1 => EqualityComparer<T1>.Default.GetHashCode(Value1!),
        Union15Index.Value2 => EqualityComparer<T2>.Default.GetHashCode(Value2!),
        Union15Index.Value3 => EqualityComparer<T3>.Default.GetHashCode(Value3!),
        Union15Index.Value4 => EqualityComparer<T4>.Default.GetHashCode(Value4!),
        Union15Index.Value5 => EqualityComparer<T5>.Default.GetHashCode(Value5!),
        Union15Index.Value6 => EqualityComparer<T6>.Default.GetHashCode(Value6!),
        Union15Index.Value7 => EqualityComparer<T7>.Default.GetHashCode(Value7!),
        Union15Index.Value8 => EqualityComparer<T8>.Default.GetHashCode(Value8!),
        Union15Index.Value9 => EqualityComparer<T9>.Default.GetHashCode(Value9!),
        Union15Index.Value10 => EqualityComparer<T10>.Default.GetHashCode(Value10!),
        Union15Index.Value11 => EqualityComparer<T11>.Default.GetHashCode(Value11!),
        Union15Index.Value12 => EqualityComparer<T12>.Default.GetHashCode(Value12!),
        Union15Index.Value13 => EqualityComparer<T13>.Default.GetHashCode(Value13!),
        Union15Index.Value14 => EqualityComparer<T14>.Default.GetHashCode(Value14!),
        Union15Index.Value15 => EqualityComparer<T15>.Default.GetHashCode(Value15!)
    };
    
    /// <summary>
    /// Check if two union types are equal
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Another union type with the same signature as <paramref name="left"/></param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return left.Equals(right);
    }
    
    /// <summary>
    /// Check if two union types are not equal
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Another union type with the same signature as <paramref name="left"/></param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !left.Equals(right);
    }
    
    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T1? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T1? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T1? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T1? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T2? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T2? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T2? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T2? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T3? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T3? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T3? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T3? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T4? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T4? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T4? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T4? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T5? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T5? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T5? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T5? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T6? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T6? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T6? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T6? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T7? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T7? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T7? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T7? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T8? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T8? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T8? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T8? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T9? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T9? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T9? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T9? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T10? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T10? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T10? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T10? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T11? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T11? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T11? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T11? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T12? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T12? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T12? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T12? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T13? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T13? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T13? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T13? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T14? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T14? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T14? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T14? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T15? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> left, T15? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T15? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T15? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> right) {
        return !right.Equals(left);
    }
      
    /// <summary>
    /// <para>Deconstruct union type into variables, one of which will be <see cref="Value"/> and the rest of which will be <c>default</c>.</para>
    /// <para>Can be called with tuple assignment syntax:</para>
    /// <para><c>(T1? val1, T2? val2, T3? val3, T4? val4, T5? val5, T6? val6, T7? val7, T8? val8, T9? val9, T10? val10, T11? val11, T12? val12, T13? val13, T14? val14, T15? val15) = myUnionType;</c></para>
    /// <para>Can also be called directly with <c>out</c> variables:</para>
    /// <para><c>myUnionType.Deconstruct(out T1? val1, out T2? val2, out T3? val3, out T4? val4, out T5? val5, out T6? val6, out T7? val7, out T8? val8, out T9? val9, out T10? val10, out T11? val11, out T12? val12, out T13? val13, out T14? val14, out T15? val15);</c></para>
    /// </summary>
    /// <param name="value1">Value of type <typeparamref name="T1"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value1"/>, otherwise <c>default</c>.</param>
    /// <param name="value2">Value of type <typeparamref name="T2"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value2"/>, otherwise <c>default</c>.</param>
    /// <param name="value3">Value of type <typeparamref name="T3"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value3"/>, otherwise <c>default</c>.</param>
    /// <param name="value4">Value of type <typeparamref name="T4"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value4"/>, otherwise <c>default</c>.</param>
    /// <param name="value5">Value of type <typeparamref name="T5"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value5"/>, otherwise <c>default</c>.</param>
    /// <param name="value6">Value of type <typeparamref name="T6"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value6"/>, otherwise <c>default</c>.</param>
    /// <param name="value7">Value of type <typeparamref name="T7"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value7"/>, otherwise <c>default</c>.</param>
    /// <param name="value8">Value of type <typeparamref name="T8"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value8"/>, otherwise <c>default</c>.</param>
    /// <param name="value9">Value of type <typeparamref name="T9"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value9"/>, otherwise <c>default</c>.</param>
    /// <param name="value10">Value of type <typeparamref name="T10"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value10"/>, otherwise <c>default</c>.</param>
    /// <param name="value11">Value of type <typeparamref name="T11"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value11"/>, otherwise <c>default</c>.</param>
    /// <param name="value12">Value of type <typeparamref name="T12"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value12"/>, otherwise <c>default</c>.</param>
    /// <param name="value13">Value of type <typeparamref name="T13"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value13"/>, otherwise <c>default</c>.</param>
    /// <param name="value14">Value of type <typeparamref name="T14"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value14"/>, otherwise <c>default</c>.</param>
    /// <param name="value15">Value of type <typeparamref name="T15"/> if <see cref="ValueIndex"/> is <see cref="Union15Index.Value15"/>, otherwise <c>default</c>.</param>
    public void Deconstruct(out T1? value1, out T2? value2, out T3? value3, out T4? value4, out T5? value5, out T6? value6, out T7? value7, out T8? value8, out T9? value9, out T10? value10, out T11? value11, out T12? value12, out T13? value13, out T14? value14, out T15? value15) {
        value1 = Value1;
        value2 = Value2;
        value3 = Value3;
        value4 = Value4;
        value5 = Value5;
        value6 = Value6;
        value7 = Value7;
        value8 = Value8;
        value9 = Value9;
        value10 = Value10;
        value11 = Value11;
        value12 = Value12;
        value13 = Value13;
        value14 = Value14;
        value15 = Value15;
    }
}