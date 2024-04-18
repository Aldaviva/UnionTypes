using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).

namespace UnionTypes;
              
[GeneratedCode("Aldaviva/UnionTypes", null)]
public readonly struct Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>: IUnion, IEquatable<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> {
  
    private int ValueIndex { get; }
    public T1? Value1 { get; }
    public T2? Value2 { get; }
    public T3? Value3 { get; }
    public T4? Value4 { get; }
    public T5? Value5 { get; }
    public T6? Value6 { get; }
    public T7? Value7 { get; }
    public T8? Value8 { get; }
    public T9? Value9 { get; }
    public T10? Value10 { get; }

    public Union(T1? value) {
        Value1 = value;
        ValueIndex = 1;
    }

    public Union(T2? value) {
        Value2 = value;
        ValueIndex = 2;
    }

    public Union(T3? value) {
        Value3 = value;
        ValueIndex = 3;
    }

    public Union(T4? value) {
        Value4 = value;
        ValueIndex = 4;
    }

    public Union(T5? value) {
        Value5 = value;
        ValueIndex = 5;
    }

    public Union(T6? value) {
        Value6 = value;
        ValueIndex = 6;
    }

    public Union(T7? value) {
        Value7 = value;
        ValueIndex = 7;
    }

    public Union(T8? value) {
        Value8 = value;
        ValueIndex = 8;
    }

    public Union(T9? value) {
        Value9 = value;
        ValueIndex = 9;
    }

    public Union(T10? value) {
        Value10 = value;
        ValueIndex = 10;
    }
  
    public object? Value => ValueIndex switch {
        1 => Value1,
        2 => Value2,
        3 => Value3,
        4 => Value4,
        5 => Value5,
        6 => Value6,
        7 => Value7,
        8 => Value8,
        9 => Value9,
        10 => Value10
    };
    
    public bool HasValue1 => ValueIndex == 1;
    public bool HasValue2 => ValueIndex == 2;
    public bool HasValue3 => ValueIndex == 3;
    public bool HasValue4 => ValueIndex == 4;
    public bool HasValue5 => ValueIndex == 5;
    public bool HasValue6 => ValueIndex == 6;
    public bool HasValue7 => ValueIndex == 7;
    public bool HasValue8 => ValueIndex == 8;
    public bool HasValue9 => ValueIndex == 9;
    public bool HasValue10 => ValueIndex == 10;
    
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10? value) => new(value);
    
    public override string? ToString() => ValueIndex switch {
        1 => Value1?.ToString(),
        2 => Value2?.ToString(),
        3 => Value3?.ToString(),
        4 => Value4?.ToString(),
        5 => Value5?.ToString(),
        6 => Value6?.ToString(),
        7 => Value7?.ToString(),
        8 => Value8?.ToString(),
        9 => Value9?.ToString(),
        10 => Value10?.ToString()
    };
    
    public bool Equals(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other) => ValueIndex switch {
        1 when other.ValueIndex is 1 => EqualityComparer<T1?>.Default.Equals(Value1, other.Value1),
        2 when other.ValueIndex is 2 => EqualityComparer<T2?>.Default.Equals(Value2, other.Value2),
        3 when other.ValueIndex is 3 => EqualityComparer<T3?>.Default.Equals(Value3, other.Value3),
        4 when other.ValueIndex is 4 => EqualityComparer<T4?>.Default.Equals(Value4, other.Value4),
        5 when other.ValueIndex is 5 => EqualityComparer<T5?>.Default.Equals(Value5, other.Value5),
        6 when other.ValueIndex is 6 => EqualityComparer<T6?>.Default.Equals(Value6, other.Value6),
        7 when other.ValueIndex is 7 => EqualityComparer<T7?>.Default.Equals(Value7, other.Value7),
        8 when other.ValueIndex is 8 => EqualityComparer<T8?>.Default.Equals(Value8, other.Value8),
        9 when other.ValueIndex is 9 => EqualityComparer<T9?>.Default.Equals(Value9, other.Value9),
        10 when other.ValueIndex is 10 => EqualityComparer<T10?>.Default.Equals(Value10, other.Value10),
        _ => Value?.Equals(other.Value) ?? other.Value is null
    };
    
    public bool Equals(T1? other) => ValueIndex switch {
        1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        2 => Value2 is not null ? Value2.Equals(other) : other is null,
        3 => Value3 is not null ? Value3.Equals(other) : other is null,
        4 => Value4 is not null ? Value4.Equals(other) : other is null,
        5 => Value5 is not null ? Value5.Equals(other) : other is null,
        6 => Value6 is not null ? Value6.Equals(other) : other is null,
        7 => Value7 is not null ? Value7.Equals(other) : other is null,
        8 => Value8 is not null ? Value8.Equals(other) : other is null,
        9 => Value9 is not null ? Value9.Equals(other) : other is null,
        10 => Value10 is not null ? Value10.Equals(other) : other is null
    };

    public bool Equals(T2? other) => ValueIndex switch {
        1 => Value1 is not null ? Value1.Equals(other) : other is null,
        2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        3 => Value3 is not null ? Value3.Equals(other) : other is null,
        4 => Value4 is not null ? Value4.Equals(other) : other is null,
        5 => Value5 is not null ? Value5.Equals(other) : other is null,
        6 => Value6 is not null ? Value6.Equals(other) : other is null,
        7 => Value7 is not null ? Value7.Equals(other) : other is null,
        8 => Value8 is not null ? Value8.Equals(other) : other is null,
        9 => Value9 is not null ? Value9.Equals(other) : other is null,
        10 => Value10 is not null ? Value10.Equals(other) : other is null
    };

    public bool Equals(T3? other) => ValueIndex switch {
        1 => Value1 is not null ? Value1.Equals(other) : other is null,
        2 => Value2 is not null ? Value2.Equals(other) : other is null,
        3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        4 => Value4 is not null ? Value4.Equals(other) : other is null,
        5 => Value5 is not null ? Value5.Equals(other) : other is null,
        6 => Value6 is not null ? Value6.Equals(other) : other is null,
        7 => Value7 is not null ? Value7.Equals(other) : other is null,
        8 => Value8 is not null ? Value8.Equals(other) : other is null,
        9 => Value9 is not null ? Value9.Equals(other) : other is null,
        10 => Value10 is not null ? Value10.Equals(other) : other is null
    };

    public bool Equals(T4? other) => ValueIndex switch {
        1 => Value1 is not null ? Value1.Equals(other) : other is null,
        2 => Value2 is not null ? Value2.Equals(other) : other is null,
        3 => Value3 is not null ? Value3.Equals(other) : other is null,
        4 => EqualityComparer<T4?>.Default.Equals(Value4, other),
        5 => Value5 is not null ? Value5.Equals(other) : other is null,
        6 => Value6 is not null ? Value6.Equals(other) : other is null,
        7 => Value7 is not null ? Value7.Equals(other) : other is null,
        8 => Value8 is not null ? Value8.Equals(other) : other is null,
        9 => Value9 is not null ? Value9.Equals(other) : other is null,
        10 => Value10 is not null ? Value10.Equals(other) : other is null
    };

    public bool Equals(T5? other) => ValueIndex switch {
        1 => Value1 is not null ? Value1.Equals(other) : other is null,
        2 => Value2 is not null ? Value2.Equals(other) : other is null,
        3 => Value3 is not null ? Value3.Equals(other) : other is null,
        4 => Value4 is not null ? Value4.Equals(other) : other is null,
        5 => EqualityComparer<T5?>.Default.Equals(Value5, other),
        6 => Value6 is not null ? Value6.Equals(other) : other is null,
        7 => Value7 is not null ? Value7.Equals(other) : other is null,
        8 => Value8 is not null ? Value8.Equals(other) : other is null,
        9 => Value9 is not null ? Value9.Equals(other) : other is null,
        10 => Value10 is not null ? Value10.Equals(other) : other is null
    };

    public bool Equals(T6? other) => ValueIndex switch {
        1 => Value1 is not null ? Value1.Equals(other) : other is null,
        2 => Value2 is not null ? Value2.Equals(other) : other is null,
        3 => Value3 is not null ? Value3.Equals(other) : other is null,
        4 => Value4 is not null ? Value4.Equals(other) : other is null,
        5 => Value5 is not null ? Value5.Equals(other) : other is null,
        6 => EqualityComparer<T6?>.Default.Equals(Value6, other),
        7 => Value7 is not null ? Value7.Equals(other) : other is null,
        8 => Value8 is not null ? Value8.Equals(other) : other is null,
        9 => Value9 is not null ? Value9.Equals(other) : other is null,
        10 => Value10 is not null ? Value10.Equals(other) : other is null
    };

    public bool Equals(T7? other) => ValueIndex switch {
        1 => Value1 is not null ? Value1.Equals(other) : other is null,
        2 => Value2 is not null ? Value2.Equals(other) : other is null,
        3 => Value3 is not null ? Value3.Equals(other) : other is null,
        4 => Value4 is not null ? Value4.Equals(other) : other is null,
        5 => Value5 is not null ? Value5.Equals(other) : other is null,
        6 => Value6 is not null ? Value6.Equals(other) : other is null,
        7 => EqualityComparer<T7?>.Default.Equals(Value7, other),
        8 => Value8 is not null ? Value8.Equals(other) : other is null,
        9 => Value9 is not null ? Value9.Equals(other) : other is null,
        10 => Value10 is not null ? Value10.Equals(other) : other is null
    };

    public bool Equals(T8? other) => ValueIndex switch {
        1 => Value1 is not null ? Value1.Equals(other) : other is null,
        2 => Value2 is not null ? Value2.Equals(other) : other is null,
        3 => Value3 is not null ? Value3.Equals(other) : other is null,
        4 => Value4 is not null ? Value4.Equals(other) : other is null,
        5 => Value5 is not null ? Value5.Equals(other) : other is null,
        6 => Value6 is not null ? Value6.Equals(other) : other is null,
        7 => Value7 is not null ? Value7.Equals(other) : other is null,
        8 => EqualityComparer<T8?>.Default.Equals(Value8, other),
        9 => Value9 is not null ? Value9.Equals(other) : other is null,
        10 => Value10 is not null ? Value10.Equals(other) : other is null
    };

    public bool Equals(T9? other) => ValueIndex switch {
        1 => Value1 is not null ? Value1.Equals(other) : other is null,
        2 => Value2 is not null ? Value2.Equals(other) : other is null,
        3 => Value3 is not null ? Value3.Equals(other) : other is null,
        4 => Value4 is not null ? Value4.Equals(other) : other is null,
        5 => Value5 is not null ? Value5.Equals(other) : other is null,
        6 => Value6 is not null ? Value6.Equals(other) : other is null,
        7 => Value7 is not null ? Value7.Equals(other) : other is null,
        8 => Value8 is not null ? Value8.Equals(other) : other is null,
        9 => EqualityComparer<T9?>.Default.Equals(Value9, other),
        10 => Value10 is not null ? Value10.Equals(other) : other is null
    };

    public bool Equals(T10? other) => ValueIndex switch {
        1 => Value1 is not null ? Value1.Equals(other) : other is null,
        2 => Value2 is not null ? Value2.Equals(other) : other is null,
        3 => Value3 is not null ? Value3.Equals(other) : other is null,
        4 => Value4 is not null ? Value4.Equals(other) : other is null,
        5 => Value5 is not null ? Value5.Equals(other) : other is null,
        6 => Value6 is not null ? Value6.Equals(other) : other is null,
        7 => Value7 is not null ? Value7.Equals(other) : other is null,
        8 => Value8 is not null ? Value8.Equals(other) : other is null,
        9 => Value9 is not null ? Value9.Equals(other) : other is null,
        10 => EqualityComparer<T10?>.Default.Equals(Value10, other)
    };
          
    public override bool Equals(object? obj) => obj switch {
        Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other => Equals(other),
        IUnion other => Value?.Equals(other.Value) ?? other.Value is null,
        T1 other when ValueIndex is 1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        T2 other when ValueIndex is 2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        T3 other when ValueIndex is 3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        T4 other when ValueIndex is 4 => EqualityComparer<T4?>.Default.Equals(Value4, other),
        T5 other when ValueIndex is 5 => EqualityComparer<T5?>.Default.Equals(Value5, other),
        T6 other when ValueIndex is 6 => EqualityComparer<T6?>.Default.Equals(Value6, other),
        T7 other when ValueIndex is 7 => EqualityComparer<T7?>.Default.Equals(Value7, other),
        T8 other when ValueIndex is 8 => EqualityComparer<T8?>.Default.Equals(Value8, other),
        T9 other when ValueIndex is 9 => EqualityComparer<T9?>.Default.Equals(Value9, other),
        T10 other when ValueIndex is 10 => EqualityComparer<T10?>.Default.Equals(Value10, other),
        _ => false
    };
    
    public override int GetHashCode() => ValueIndex switch {
        1 => EqualityComparer<T1?>.Default.GetHashCode(Value1),
        2 => EqualityComparer<T2?>.Default.GetHashCode(Value2),
        3 => EqualityComparer<T3?>.Default.GetHashCode(Value3),
        4 => EqualityComparer<T4?>.Default.GetHashCode(Value4),
        5 => EqualityComparer<T5?>.Default.GetHashCode(Value5),
        6 => EqualityComparer<T6?>.Default.GetHashCode(Value6),
        7 => EqualityComparer<T7?>.Default.GetHashCode(Value7),
        8 => EqualityComparer<T8?>.Default.GetHashCode(Value8),
        9 => EqualityComparer<T9?>.Default.GetHashCode(Value9),
        10 => EqualityComparer<T10?>.Default.GetHashCode(Value10)
    };
    
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return left.Equals(right);
    }
    
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !left.Equals(right);
    }
    
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T1? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T1? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T1? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T1? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T2? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T2? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T2? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T2? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T3? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T3? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T3? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T3? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T4? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T4? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T4? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T4? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T5? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T5? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T5? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T5? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T6? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T6? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T6? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T6? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T7? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T7? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T7? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T7? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T8? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T8? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T8? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T8? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T9? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T9? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T9? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T9? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T10? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> left, T10? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T10? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T10? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> right) {
        return !right.Equals(left);
    }
      
}