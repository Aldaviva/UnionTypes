using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace UnionTypes;

[GeneratedCode("Aldaviva/UnionTypes", null)]
public enum Union4Index {

    Value1 = 1,
    Value2 = 2,
    Value3 = 3,
    Value4 = 4

}

[GeneratedCode("Aldaviva/UnionTypes", null)]
public readonly struct Union<T1, T2, T3, T4>: IUnion, IEquatable<Union<T1, T2, T3, T4>> {
  
    public Union4Index ValueIndex { get; }
    public T1? Value1 { get; }
    public T2? Value2 { get; }
    public T3? Value3 { get; }
    public T4? Value4 { get; }

    public Union(T1? value) {
        Value1 = value;
        ValueIndex = Union4Index.Value1;
    }

    public Union(T2? value) {
        Value2 = value;
        ValueIndex = Union4Index.Value2;
    }

    public Union(T3? value) {
        Value3 = value;
        ValueIndex = Union4Index.Value3;
    }

    public Union(T4? value) {
        Value4 = value;
        ValueIndex = Union4Index.Value4;
    }
  
    public object? Value => ValueIndex switch {
        Union4Index.Value1 => Value1,
        Union4Index.Value2 => Value2,
        Union4Index.Value3 => Value3,
        Union4Index.Value4 => Value4
    };
    
    public bool HasValue1 => ValueIndex == Union4Index.Value1;
    public bool HasValue2 => ValueIndex == Union4Index.Value2;
    public bool HasValue3 => ValueIndex == Union4Index.Value3;
    public bool HasValue4 => ValueIndex == Union4Index.Value4;
    
    public static implicit operator Union<T1, T2, T3, T4>(T1? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4>(T2? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4>(T3? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4>(T4? value) => new(value);
    
    public override string? ToString() => ValueIndex switch {
        Union4Index.Value1 => Value1?.ToString(),
        Union4Index.Value2 => Value2?.ToString(),
        Union4Index.Value3 => Value3?.ToString(),
        Union4Index.Value4 => Value4?.ToString()
    };
    
    public bool Equals(Union<T1, T2, T3, T4> other) => ValueIndex switch {
        Union4Index.Value1 when other.ValueIndex is Union4Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other.Value1),
        Union4Index.Value2 when other.ValueIndex is Union4Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other.Value2),
        Union4Index.Value3 when other.ValueIndex is Union4Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other.Value3),
        Union4Index.Value4 when other.ValueIndex is Union4Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other.Value4),
        _ => Value?.Equals(other.Value) ?? other.Value is null
    };
    
    public bool Equals(T1? other) => ValueIndex switch {
        Union4Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        Union4Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union4Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union4Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null
    };

    public bool Equals(T2? other) => ValueIndex switch {
        Union4Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union4Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        Union4Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union4Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null
    };

    public bool Equals(T3? other) => ValueIndex switch {
        Union4Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union4Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union4Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        Union4Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null
    };

    public bool Equals(T4? other) => ValueIndex switch {
        Union4Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union4Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union4Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union4Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other)
    };
          
    public override bool Equals(object? obj) => obj switch {
        Union<T1, T2, T3, T4> other => Equals(other),
        IUnion other => Value?.Equals(other.Value) ?? other.Value is null,
        T1 other when ValueIndex is Union4Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        T2 other when ValueIndex is Union4Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        T3 other when ValueIndex is Union4Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        T4 other when ValueIndex is Union4Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other),
        _ => false
    };
    
    public override int GetHashCode() => ValueIndex switch {
        Union4Index.Value1 => EqualityComparer<T1?>.Default.GetHashCode(Value1),
        Union4Index.Value2 => EqualityComparer<T2?>.Default.GetHashCode(Value2),
        Union4Index.Value3 => EqualityComparer<T3?>.Default.GetHashCode(Value3),
        Union4Index.Value4 => EqualityComparer<T4?>.Default.GetHashCode(Value4)
    };
    
    public static bool operator ==(Union<T1, T2, T3, T4> left, Union<T1, T2, T3, T4> right) {
        return left.Equals(right);
    }
    
    public static bool operator !=(Union<T1, T2, T3, T4> left, Union<T1, T2, T3, T4> right) {
        return !left.Equals(right);
    }
    
    public static bool operator ==(Union<T1, T2, T3, T4> left, T1? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4> left, T1? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T1? left, Union<T1, T2, T3, T4> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T1? left, Union<T1, T2, T3, T4> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4> left, T2? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4> left, T2? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T2? left, Union<T1, T2, T3, T4> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T2? left, Union<T1, T2, T3, T4> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4> left, T3? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4> left, T3? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T3? left, Union<T1, T2, T3, T4> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T3? left, Union<T1, T2, T3, T4> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4> left, T4? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4> left, T4? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T4? left, Union<T1, T2, T3, T4> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T4? left, Union<T1, T2, T3, T4> right) {
        return !right.Equals(left);
    }
      
}