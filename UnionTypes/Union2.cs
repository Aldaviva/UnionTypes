using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnionTypes;

/// <summary>
/// Indicates which constituent value is used by a union type instance
/// </summary>
[GeneratedCode("Aldaviva/UnionTypes", null)]
public enum Union2Index {

    /// <summary>Union type's value is of the union's 1st type</summary>
    Value1 = 1,

    /// <summary>Union type's value is of the union's 2nd type</summary>
    Value2 = 2

}

/// <summary>
/// A union type whose value can be 1 of 2 possible types.
/// </summary>
/// <typeparam name="T1">Possible type of value 1</typeparam>
/// <typeparam name="T2">Possible type of value 2</typeparam>
[GeneratedCode("Aldaviva/UnionTypes", null)]
[DebuggerDisplay("{Value}")]
public readonly struct Union<T1, T2>: IUnion, IEquatable<Union<T1, T2>> {
  
    /// <summary>
    /// Which constituent type the value current has
    /// </summary>
    public Union2Index ValueIndex { get; }
    
    /// <summary>The value of the union type if <see cref="HasValue1"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union2Index.Value1"/>; otherwise <c>default</c>.</summary>
    public T1? Value1 { get; }

    /// <summary>The value of the union type if <see cref="HasValue2"/> is <c>true</c>, or equivalently if <see cref="ValueIndex"/> is <see cref="Union2Index.Value2"/>; otherwise <c>default</c>.</summary>
    public T2? Value2 { get; }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value1">The value of the union type</param>
    public Union(T1 value1) {
        Value1 = value1;
        ValueIndex = Union2Index.Value1;
    }

    /// <summary>
    /// Create an instance of the union type with the given value.
    /// </summary>
    /// <param name="value2">The value of the union type</param>
    public Union(T2 value2) {
        Value2 = value2;
        ValueIndex = Union2Index.Value2;
    }
  
    /// <inheritdoc />
    public object? Value => ValueIndex switch {
        Union2Index.Value1 => Value1,
        Union2Index.Value2 => Value2
    };
    
    /// <inheritdoc />
    public Type ValueType => ValueIndex switch {
        Union2Index.Value1 => typeof(T1),
        Union2Index.Value2 => typeof(T2)
    };
    
    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue1 => ValueIndex == Union2Index.Value1;

    /// <summary><c>true</c> if the value of the union type is <see cref="Value1"/>, false otherwise</summary>
    public bool HasValue2 => ValueIndex == Union2Index.Value2;

    /// <summary>
    /// Execute an action depending on which type the value is
    /// </summary>
    public void Switch(Action<T1> case1, Action<T2> case2) {
        switch (ValueIndex) {
            case Union2Index.Value1:
                case1(Value1!);
                break;
            case Union2Index.Value2:
                case2(Value2!);
                break;
        }
    }
    
    /// <summary>
    /// Evaluate an expression depending on which type the value is
    /// </summary>
    public TResult Switch<TResult>(Func<T1, TResult> case1, Func<T2, TResult> case2) => ValueIndex switch {
        Union2Index.Value1 => case1(Value1!),
        Union2Index.Value2 => case2(Value2!)
    };
    
    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2>(T1 value) => new(value);

    /// <summary>
    /// Implicitly cast a value to this union type
    /// </summary>
    /// <param name="value">Value of the union type</param>
    public static implicit operator Union<T1, T2>(T2 value) => new(value);
    
    /// <inheritdoc cref="Object.ToString"/>
    public override string ToString() => ValueIndex switch {
        Union2Index.Value1 => Value1!.ToString(),
        Union2Index.Value2 => Value2!.ToString()
    };
    
    /// <inheritdoc />
    public bool Equals(Union<T1, T2> other) => ValueIndex switch {
        Union2Index.Value1 when other.ValueIndex is Union2Index.Value1 => EqualityComparer<T1>.Default.Equals(Value1!, other.Value1!),
        Union2Index.Value2 when other.ValueIndex is Union2Index.Value2 => EqualityComparer<T2>.Default.Equals(Value2!, other.Value2!),
        _ => Value?.Equals(other.Value) ?? other.Value is null
    };
    
    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T1? other) => ValueIndex switch {
        Union2Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        Union2Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null
    };

    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
    public bool Equals(T2? other) => ValueIndex switch {
        Union2Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union2Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other)
    };
          
    /// <inheritdoc />
    public override bool Equals(object? obj) => obj switch {
        Union<T1, T2> other => Equals(other),
        IUnion other => Value?.Equals(other.Value) ?? other.Value is null,
        T1 other when ValueIndex is Union2Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        T2 other when ValueIndex is Union2Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        _ => false
    };
    
    /// <inheritdoc />
    public override int GetHashCode() => ValueIndex switch {
        Union2Index.Value1 => EqualityComparer<T1>.Default.GetHashCode(Value1!),
        Union2Index.Value2 => EqualityComparer<T2>.Default.GetHashCode(Value2!)
    };
    
    /// <summary>
    /// Check if two union types are equal
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Another union type with the same signature as <paramref name="left"/></param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2> left, Union<T1, T2> right) {
        return left.Equals(right);
    }
    
    /// <summary>
    /// Check if two union types are not equal
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Another union type with the same signature as <paramref name="left"/></param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2> left, Union<T1, T2> right) {
        return !left.Equals(right);
    }
    
    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2> left, T1? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2> left, T1? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T1? left, Union<T1, T2> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T1? left, Union<T1, T2> right) {
        return !right.Equals(left);
    }

    /// <summary>
    /// Check if a union type is equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(Union<T1, T2> left, T2? right) {
        return left.Equals(right);
    }

    /// <summary>
    /// Check if a union type is not equal to a value
    /// </summary>
    /// <param name="left">Union type</param>
    /// <param name="right">Value</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(Union<T1, T2> left, T2? right) {
        return !left.Equals(right);
    }

    /// <summary>
    /// Check if a value is equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
    public static bool operator ==(T2? left, Union<T1, T2> right) {
        return right.Equals(left);
    }

    /// <summary>
    /// Check if a value is not equal to a union type
    /// </summary>
    /// <param name="left">Value</param>
    /// <param name="right">Union type</param>
    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
    public static bool operator !=(T2? left, Union<T1, T2> right) {
        return !right.Equals(left);
    }
      
    /// <summary>
    /// <para>Deconstruct union type into variables, one of which will be <see cref="Value"/> and the rest of which will be <c>default</c>.</para>
    /// <para>Can be called with tuple assignment syntax:</para>
    /// <para><c>(T1? val1, T2? val2) = myUnionType;</c></para>
    /// <para>Can also be called directly with <c>out</c> variables:</para>
    /// <para><c>myUnionType.Deconstruct(out T1? val1, out T2? val2);</c></para>
    /// </summary>
    /// <param name="value1">Value of type <typeparamref name="T1"/> if <see cref="ValueIndex"/> is <see cref="Union2Index.Value1"/>, otherwise <c>default</c>.</param>
    /// <param name="value2">Value of type <typeparamref name="T2"/> if <see cref="ValueIndex"/> is <see cref="Union2Index.Value2"/>, otherwise <c>default</c>.</param>
    public void Deconstruct(out T1? value1, out T2? value2) {
        value1 = Value1;
        value2 = Value2;
    }
}