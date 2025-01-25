using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnionTypes;

/// <summary>
/// Indicates which constituent value is used by a union type instance
/// </summary>
[GeneratedCode("Aldaviva/UnionTypes", null)]
public enum Union9Index {

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
    Value9 = 9

}

/// <summary>
/// A union type whose value can be 1 of 9 possible types.
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
[GeneratedCode("Aldaviva/UnionTypes", null)]
[DebuggerDisplay("{Value}")]
public readonly struct Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>: IUnion, IEquatable<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>> {
  
    /// <summary>
    /// Which constituent type the value current has
    /// </summary>
    public Union9Index ValueIndex { get; }
    
    /// <summary>The value of the union type if <see cref="HasValue1"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union9Index.Value1"/>; otherwise <c>default</c>.</summary>
    public T1? Value1 { get; }

    /// <summary>The value of the union type if <see cref="HasValue2"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union9Index.Value2"/>; otherwise <c>default</c>.</summary>
    public T2? Value2 { get; }

    /// <summary>The value of the union type if <see cref="HasValue3"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union9Index.Value3"/>; otherwise <c>default</c>.</summary>
    public T3? Value3 { get; }

    /// <summary>The value of the union type if <see cref="HasValue4"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union9Index.Value4"/>; otherwise <c>default</c>.</summary>
    public T4? Value4 { get; }

    /// <summary>The value of the union type if <see cref="HasValue5"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union9Index.Value5"/>; otherwise <c>default</c>.</summary>
    public T5? Value5 { get; }

    /// <summary>The value of the union type if <see cref="HasValue6"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union9Index.Value6"/>; otherwise <c>default</c>.</summary>
    public T6? Value6 { get; }

    /// <summary>The value of the union type if <see cref="HasValue7"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union9Index.Value7"/>; otherwise <c>default</c>.</summary>
    public T7? Value7 { get; }

    /// <summary>The value of the union type if <see cref="HasValue8"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union9Index.Value8"/>; otherwise <c>default</c>.</summary>
    public T8? Value8 { get; }

    /// <summary>The value of the union type if <see cref="HasValue9"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union9Index.Value9"/>; otherwise <c>default</c>.</summary>
    public T9? Value9 { get; }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value1">The value of the union type</param>
    public Union(T1? value1) {
        Value1 = value1;
        ValueIndex = Union9Index.Value1;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value2">The value of the union type</param>
    public Union(T2? value2) {
        Value2 = value2;
        ValueIndex = Union9Index.Value2;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value3">The value of the union type</param>
    public Union(T3? value3) {
        Value3 = value3;
        ValueIndex = Union9Index.Value3;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value4">The value of the union type</param>
    public Union(T4? value4) {
        Value4 = value4;
        ValueIndex = Union9Index.Value4;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value5">The value of the union type</param>
    public Union(T5? value5) {
        Value5 = value5;
        ValueIndex = Union9Index.Value5;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value6">The value of the union type</param>
    public Union(T6? value6) {
        Value6 = value6;
        ValueIndex = Union9Index.Value6;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value7">The value of the union type</param>
    public Union(T7? value7) {
        Value7 = value7;
        ValueIndex = Union9Index.Value7;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value8">The value of the union type</param>
    public Union(T8? value8) {
        Value8 = value8;
        ValueIndex = Union9Index.Value8;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value9">The value of the union type</param>
    public Union(T9? value9) {
        Value9 = value9;
        ValueIndex = Union9Index.Value9;
    }
  
    /// <inheritdoc />
    public object? Value => ValueIndex switch {
        Union9Index.Value1 => Value1,
        Union9Index.Value2 => Value2,
        Union9Index.Value3 => Value3,
        Union9Index.Value4 => Value4,
        Union9Index.Value5 => Value5,
        Union9Index.Value6 => Value6,
        Union9Index.Value7 => Value7,
        Union9Index.Value8 => Value8,
        Union9Index.Value9 => Value9
    };
    
    /// <inheritdoc />
    public Type ValueType => ValueIndex switch {
        Union9Index.Value1 => typeof(T1),
        Union9Index.Value2 => typeof(T2),
        Union9Index.Value3 => typeof(T3),
        Union9Index.Value4 => typeof(T4),
        Union9Index.Value5 => typeof(T5),
        Union9Index.Value6 => typeof(T6),
        Union9Index.Value7 => typeof(T7),
        Union9Index.Value8 => typeof(T8),
        Union9Index.Value9 => typeof(T9)
    };
    
    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue1 => ValueIndex == Union9Index.Value1;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue2 => ValueIndex == Union9Index.Value2;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue3 => ValueIndex == Union9Index.Value3;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue4 => ValueIndex == Union9Index.Value4;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue5 => ValueIndex == Union9Index.Value5;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue6 => ValueIndex == Union9Index.Value6;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue7 => ValueIndex == Union9Index.Value7;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue8 => ValueIndex == Union9Index.Value8;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue9 => ValueIndex == Union9Index.Value9;

    /// <summary>
    /// switch (statement)
    /// </summary>
    public void Switch(Action<T1?> case1, Action<T2?> case2, Action<T3?> case3, Action<T4?> case4, Action<T5?> case5, Action<T6?> case6, Action<T7?> case7, Action<T8?> case8, Action<T9?> case9) {
        switch (ValueIndex) {
            case Union9Index.Value1:
                case1(Value1);
                break;
            case Union9Index.Value2:
                case2(Value2);
                break;
            case Union9Index.Value3:
                case3(Value3);
                break;
            case Union9Index.Value4:
                case4(Value4);
                break;
            case Union9Index.Value5:
                case5(Value5);
                break;
            case Union9Index.Value6:
                case6(Value6);
                break;
            case Union9Index.Value7:
                case7(Value7);
                break;
            case Union9Index.Value8:
                case8(Value8);
                break;
            case Union9Index.Value9:
                case9(Value9);
                break;
        }
    }
    
    /// <summary>
    /// switch (expression)
    /// </summary>
    public TResult Switch<TResult>(Func<T1?, TResult> case1, Func<T2?, TResult> case2, Func<T3?, TResult> case3, Func<T4?, TResult> case4, Func<T5?, TResult> case5, Func<T6?, TResult> case6, Func<T7?, TResult> case7, Func<T8?, TResult> case8, Func<T9?, TResult> case9) => ValueIndex switch {
        Union9Index.Value1 => case1(Value1),
        Union9Index.Value2 => case2(Value2),
        Union9Index.Value3 => case3(Value3),
        Union9Index.Value4 => case4(Value4),
        Union9Index.Value5 => case5(Value5),
        Union9Index.Value6 => case6(Value6),
        Union9Index.Value7 => case7(Value7),
        Union9Index.Value8 => case8(Value8),
        Union9Index.Value9 => case9(Value9)
    };
    
    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1? value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2? value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3? value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4? value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5? value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6? value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7? value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8? value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9? value) => new(value);
    
    /// <inheritdoc cref="Object.ToString"/>
    public override string? ToString() => ValueIndex switch {
        Union9Index.Value1 => Value1?.ToString(),
        Union9Index.Value2 => Value2?.ToString(),
        Union9Index.Value3 => Value3?.ToString(),
        Union9Index.Value4 => Value4?.ToString(),
        Union9Index.Value5 => Value5?.ToString(),
        Union9Index.Value6 => Value6?.ToString(),
        Union9Index.Value7 => Value7?.ToString(),
        Union9Index.Value8 => Value8?.ToString(),
        Union9Index.Value9 => Value9?.ToString()
    };
    
    /// <inheritdoc />
    public bool Equals(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> other) => ValueIndex switch {
        Union9Index.Value1 when other.ValueIndex is Union9Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other.Value1),
        Union9Index.Value2 when other.ValueIndex is Union9Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other.Value2),
        Union9Index.Value3 when other.ValueIndex is Union9Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other.Value3),
        Union9Index.Value4 when other.ValueIndex is Union9Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other.Value4),
        Union9Index.Value5 when other.ValueIndex is Union9Index.Value5 => EqualityComparer<T5?>.Default.Equals(Value5, other.Value5),
        Union9Index.Value6 when other.ValueIndex is Union9Index.Value6 => EqualityComparer<T6?>.Default.Equals(Value6, other.Value6),
        Union9Index.Value7 when other.ValueIndex is Union9Index.Value7 => EqualityComparer<T7?>.Default.Equals(Value7, other.Value7),
        Union9Index.Value8 when other.ValueIndex is Union9Index.Value8 => EqualityComparer<T8?>.Default.Equals(Value8, other.Value8),
        Union9Index.Value9 when other.ValueIndex is Union9Index.Value9 => EqualityComparer<T9?>.Default.Equals(Value9, other.Value9),
        _ => Value?.Equals(other.Value) ?? other.Value is null
    };
    
    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T1? other) => ValueIndex switch {
        Union9Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        Union9Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union9Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union9Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union9Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union9Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union9Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union9Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union9Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T2? other) => ValueIndex switch {
        Union9Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union9Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        Union9Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union9Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union9Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union9Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union9Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union9Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union9Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T3? other) => ValueIndex switch {
        Union9Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union9Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union9Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        Union9Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union9Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union9Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union9Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union9Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union9Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T4? other) => ValueIndex switch {
        Union9Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union9Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union9Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union9Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other),
        Union9Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union9Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union9Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union9Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union9Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T5? other) => ValueIndex switch {
        Union9Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union9Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union9Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union9Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union9Index.Value5 => EqualityComparer<T5?>.Default.Equals(Value5, other),
        Union9Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union9Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union9Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union9Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T6? other) => ValueIndex switch {
        Union9Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union9Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union9Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union9Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union9Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union9Index.Value6 => EqualityComparer<T6?>.Default.Equals(Value6, other),
        Union9Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union9Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union9Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T7? other) => ValueIndex switch {
        Union9Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union9Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union9Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union9Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union9Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union9Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union9Index.Value7 => EqualityComparer<T7?>.Default.Equals(Value7, other),
        Union9Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union9Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T8? other) => ValueIndex switch {
        Union9Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union9Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union9Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union9Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union9Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union9Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union9Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union9Index.Value8 => EqualityComparer<T8?>.Default.Equals(Value8, other),
        Union9Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T9? other) => ValueIndex switch {
        Union9Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union9Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union9Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union9Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union9Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union9Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union9Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union9Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union9Index.Value9 => EqualityComparer<T9?>.Default.Equals(Value9, other)
    };
          
    /// <inheritdoc />
    public override bool Equals(object? obj) => obj switch {
        Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> other => Equals(other),
        IUnion other => Value?.Equals(other.Value) ?? other.Value is null,
        T1 other when ValueIndex is Union9Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        T2 other when ValueIndex is Union9Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        T3 other when ValueIndex is Union9Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        T4 other when ValueIndex is Union9Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other),
        T5 other when ValueIndex is Union9Index.Value5 => EqualityComparer<T5?>.Default.Equals(Value5, other),
        T6 other when ValueIndex is Union9Index.Value6 => EqualityComparer<T6?>.Default.Equals(Value6, other),
        T7 other when ValueIndex is Union9Index.Value7 => EqualityComparer<T7?>.Default.Equals(Value7, other),
        T8 other when ValueIndex is Union9Index.Value8 => EqualityComparer<T8?>.Default.Equals(Value8, other),
        T9 other when ValueIndex is Union9Index.Value9 => EqualityComparer<T9?>.Default.Equals(Value9, other),
        _ => false
    };
    
    /// <inheritdoc />
    public override int GetHashCode() => ValueIndex switch {
        Union9Index.Value1 => EqualityComparer<T1?>.Default.GetHashCode(Value1),
        Union9Index.Value2 => EqualityComparer<T2?>.Default.GetHashCode(Value2),
        Union9Index.Value3 => EqualityComparer<T3?>.Default.GetHashCode(Value3),
        Union9Index.Value4 => EqualityComparer<T4?>.Default.GetHashCode(Value4),
        Union9Index.Value5 => EqualityComparer<T5?>.Default.GetHashCode(Value5),
        Union9Index.Value6 => EqualityComparer<T6?>.Default.GetHashCode(Value6),
        Union9Index.Value7 => EqualityComparer<T7?>.Default.GetHashCode(Value7),
        Union9Index.Value8 => EqualityComparer<T8?>.Default.GetHashCode(Value8),
        Union9Index.Value9 => EqualityComparer<T9?>.Default.GetHashCode(Value9)
    };
    
    /// <summary>
    /// Check if two union types are equal
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Another union type with the same signature as <paramref name="left"/></param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return left.Equals(right);
    }
    
    /// <summary>
    /// Check if two union types are not equal
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Another union type with the same signature as <paramref name="left"/></param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !left.Equals(right);
    }
    
    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T1? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T1? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T1? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T1? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T2? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T2? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T2? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T2? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T3? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T3? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T3? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T3? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T4? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T4? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T4? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T4? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T5? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T5? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T5? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T5? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T6? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T6? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T6? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T6? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T7? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T7? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T7? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T7? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T8? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T8? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T8? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T8? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T9? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> left, T9? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T9? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T9? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9> right) {
        return !right.Equals(left);
    }
      
    /// <summary>
    /// <para>Deconstruct union type into variables, one of which will be <see cref="Value"/> and the rest of which will be <c>default</c>.</para>
    /// <para>Can be called with tuple assignment syntax:</para>
    /// <para><c>(T1? val1, T2? val2, T3? val3, T4? val4, T5? val5, T6? val6, T7? val7, T8? val8, T9? val9) = myUnionType;</c></para>
    /// <para>Can also be called directly with <c>out</c> variables:</para>
    /// <para><c>myUnionType.Deconstruct(out T1? val1, out T2? val2, out T3? val3, out T4? val4, out T5? val5, out T6? val6, out T7? val7, out T8? val8, out T9? val9);</c></para>
    /// </summary>
    /// <param name="value1">Value of type <typeparamref name="T1"/> if <see cref="ValueIndex"/> is <see cref="Union9Index.Value1"/>, otherwise <c>default</c>.</param>
    /// <param name="value2">Value of type <typeparamref name="T2"/> if <see cref="ValueIndex"/> is <see cref="Union9Index.Value2"/>, otherwise <c>default</c>.</param>
    /// <param name="value3">Value of type <typeparamref name="T3"/> if <see cref="ValueIndex"/> is <see cref="Union9Index.Value3"/>, otherwise <c>default</c>.</param>
    /// <param name="value4">Value of type <typeparamref name="T4"/> if <see cref="ValueIndex"/> is <see cref="Union9Index.Value4"/>, otherwise <c>default</c>.</param>
    /// <param name="value5">Value of type <typeparamref name="T5"/> if <see cref="ValueIndex"/> is <see cref="Union9Index.Value5"/>, otherwise <c>default</c>.</param>
    /// <param name="value6">Value of type <typeparamref name="T6"/> if <see cref="ValueIndex"/> is <see cref="Union9Index.Value6"/>, otherwise <c>default</c>.</param>
    /// <param name="value7">Value of type <typeparamref name="T7"/> if <see cref="ValueIndex"/> is <see cref="Union9Index.Value7"/>, otherwise <c>default</c>.</param>
    /// <param name="value8">Value of type <typeparamref name="T8"/> if <see cref="ValueIndex"/> is <see cref="Union9Index.Value8"/>, otherwise <c>default</c>.</param>
    /// <param name="value9">Value of type <typeparamref name="T9"/> if <see cref="ValueIndex"/> is <see cref="Union9Index.Value9"/>, otherwise <c>default</c>.</param>
    public void Deconstruct(out T1? value1, out T2? value2, out T3? value3, out T4? value4, out T5? value5, out T6? value6, out T7? value7, out T8? value8, out T9? value9) {
        value1 = Value1;
        value2 = Value2;
        value3 = Value3;
        value4 = Value4;
        value5 = Value5;
        value6 = Value6;
        value7 = Value7;
        value8 = Value8;
        value9 = Value9;
    }
}