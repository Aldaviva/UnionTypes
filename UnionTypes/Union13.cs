using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace UnionTypes;

[GeneratedCode("Aldaviva/UnionTypes", null)]
public enum Union13Index {

    Value1 = 1,
    Value2 = 2,
    Value3 = 3,
    Value4 = 4,
    Value5 = 5,
    Value6 = 6,
    Value7 = 7,
    Value8 = 8,
    Value9 = 9,
    Value10 = 10,
    Value11 = 11,
    Value12 = 12,
    Value13 = 13

}

[GeneratedCode("Aldaviva/UnionTypes", null)]
public readonly struct Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>: IUnion, IEquatable<Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> {
  
    public Union13Index ValueIndex { get; }
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
    public T11? Value11 { get; }
    public T12? Value12 { get; }
    public T13? Value13 { get; }

    public Union(T1? value) {
        Value1 = value;
        ValueIndex = Union13Index.Value1;
    }

    public Union(T2? value) {
        Value2 = value;
        ValueIndex = Union13Index.Value2;
    }

    public Union(T3? value) {
        Value3 = value;
        ValueIndex = Union13Index.Value3;
    }

    public Union(T4? value) {
        Value4 = value;
        ValueIndex = Union13Index.Value4;
    }

    public Union(T5? value) {
        Value5 = value;
        ValueIndex = Union13Index.Value5;
    }

    public Union(T6? value) {
        Value6 = value;
        ValueIndex = Union13Index.Value6;
    }

    public Union(T7? value) {
        Value7 = value;
        ValueIndex = Union13Index.Value7;
    }

    public Union(T8? value) {
        Value8 = value;
        ValueIndex = Union13Index.Value8;
    }

    public Union(T9? value) {
        Value9 = value;
        ValueIndex = Union13Index.Value9;
    }

    public Union(T10? value) {
        Value10 = value;
        ValueIndex = Union13Index.Value10;
    }

    public Union(T11? value) {
        Value11 = value;
        ValueIndex = Union13Index.Value11;
    }

    public Union(T12? value) {
        Value12 = value;
        ValueIndex = Union13Index.Value12;
    }

    public Union(T13? value) {
        Value13 = value;
        ValueIndex = Union13Index.Value13;
    }
  
    public object? Value => ValueIndex switch {
        Union13Index.Value1 => Value1,
        Union13Index.Value2 => Value2,
        Union13Index.Value3 => Value3,
        Union13Index.Value4 => Value4,
        Union13Index.Value5 => Value5,
        Union13Index.Value6 => Value6,
        Union13Index.Value7 => Value7,
        Union13Index.Value8 => Value8,
        Union13Index.Value9 => Value9,
        Union13Index.Value10 => Value10,
        Union13Index.Value11 => Value11,
        Union13Index.Value12 => Value12,
        Union13Index.Value13 => Value13
    };
    
    public bool HasValue1 => ValueIndex == Union13Index.Value1;
    public bool HasValue2 => ValueIndex == Union13Index.Value2;
    public bool HasValue3 => ValueIndex == Union13Index.Value3;
    public bool HasValue4 => ValueIndex == Union13Index.Value4;
    public bool HasValue5 => ValueIndex == Union13Index.Value5;
    public bool HasValue6 => ValueIndex == Union13Index.Value6;
    public bool HasValue7 => ValueIndex == Union13Index.Value7;
    public bool HasValue8 => ValueIndex == Union13Index.Value8;
    public bool HasValue9 => ValueIndex == Union13Index.Value9;
    public bool HasValue10 => ValueIndex == Union13Index.Value10;
    public bool HasValue11 => ValueIndex == Union13Index.Value11;
    public bool HasValue12 => ValueIndex == Union13Index.Value12;
    public bool HasValue13 => ValueIndex == Union13Index.Value13;
    
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12? value) => new(value);
    public static implicit operator Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13? value) => new(value);
    
    public override string? ToString() => ValueIndex switch {
        Union13Index.Value1 => Value1?.ToString(),
        Union13Index.Value2 => Value2?.ToString(),
        Union13Index.Value3 => Value3?.ToString(),
        Union13Index.Value4 => Value4?.ToString(),
        Union13Index.Value5 => Value5?.ToString(),
        Union13Index.Value6 => Value6?.ToString(),
        Union13Index.Value7 => Value7?.ToString(),
        Union13Index.Value8 => Value8?.ToString(),
        Union13Index.Value9 => Value9?.ToString(),
        Union13Index.Value10 => Value10?.ToString(),
        Union13Index.Value11 => Value11?.ToString(),
        Union13Index.Value12 => Value12?.ToString(),
        Union13Index.Value13 => Value13?.ToString()
    };
    
    public bool Equals(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other) => ValueIndex switch {
        Union13Index.Value1 when other.ValueIndex is Union13Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other.Value1),
        Union13Index.Value2 when other.ValueIndex is Union13Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other.Value2),
        Union13Index.Value3 when other.ValueIndex is Union13Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other.Value3),
        Union13Index.Value4 when other.ValueIndex is Union13Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other.Value4),
        Union13Index.Value5 when other.ValueIndex is Union13Index.Value5 => EqualityComparer<T5?>.Default.Equals(Value5, other.Value5),
        Union13Index.Value6 when other.ValueIndex is Union13Index.Value6 => EqualityComparer<T6?>.Default.Equals(Value6, other.Value6),
        Union13Index.Value7 when other.ValueIndex is Union13Index.Value7 => EqualityComparer<T7?>.Default.Equals(Value7, other.Value7),
        Union13Index.Value8 when other.ValueIndex is Union13Index.Value8 => EqualityComparer<T8?>.Default.Equals(Value8, other.Value8),
        Union13Index.Value9 when other.ValueIndex is Union13Index.Value9 => EqualityComparer<T9?>.Default.Equals(Value9, other.Value9),
        Union13Index.Value10 when other.ValueIndex is Union13Index.Value10 => EqualityComparer<T10?>.Default.Equals(Value10, other.Value10),
        Union13Index.Value11 when other.ValueIndex is Union13Index.Value11 => EqualityComparer<T11?>.Default.Equals(Value11, other.Value11),
        Union13Index.Value12 when other.ValueIndex is Union13Index.Value12 => EqualityComparer<T12?>.Default.Equals(Value12, other.Value12),
        Union13Index.Value13 when other.ValueIndex is Union13Index.Value13 => EqualityComparer<T13?>.Default.Equals(Value13, other.Value13),
        _ => Value?.Equals(other.Value) ?? other.Value is null
    };
    
    public bool Equals(T1? other) => ValueIndex switch {
        Union13Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T2? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T3? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T4? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other),
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T5? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => EqualityComparer<T5?>.Default.Equals(Value5, other),
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T6? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => EqualityComparer<T6?>.Default.Equals(Value6, other),
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T7? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => EqualityComparer<T7?>.Default.Equals(Value7, other),
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T8? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => EqualityComparer<T8?>.Default.Equals(Value8, other),
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T9? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => EqualityComparer<T9?>.Default.Equals(Value9, other),
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T10? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => EqualityComparer<T10?>.Default.Equals(Value10, other),
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T11? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => EqualityComparer<T11?>.Default.Equals(Value11, other),
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T12? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => EqualityComparer<T12?>.Default.Equals(Value12, other),
        Union13Index.Value13 => Value13 is not null ? Value13.Equals(other) : other is null
    };

    public bool Equals(T13? other) => ValueIndex switch {
        Union13Index.Value1 => Value1 is not null ? Value1.Equals(other) : other is null,
        Union13Index.Value2 => Value2 is not null ? Value2.Equals(other) : other is null,
        Union13Index.Value3 => Value3 is not null ? Value3.Equals(other) : other is null,
        Union13Index.Value4 => Value4 is not null ? Value4.Equals(other) : other is null,
        Union13Index.Value5 => Value5 is not null ? Value5.Equals(other) : other is null,
        Union13Index.Value6 => Value6 is not null ? Value6.Equals(other) : other is null,
        Union13Index.Value7 => Value7 is not null ? Value7.Equals(other) : other is null,
        Union13Index.Value8 => Value8 is not null ? Value8.Equals(other) : other is null,
        Union13Index.Value9 => Value9 is not null ? Value9.Equals(other) : other is null,
        Union13Index.Value10 => Value10 is not null ? Value10.Equals(other) : other is null,
        Union13Index.Value11 => Value11 is not null ? Value11.Equals(other) : other is null,
        Union13Index.Value12 => Value12 is not null ? Value12.Equals(other) : other is null,
        Union13Index.Value13 => EqualityComparer<T13?>.Default.Equals(Value13, other)
    };
          
    public override bool Equals(object? obj) => obj switch {
        Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other => Equals(other),
        IUnion other => Value?.Equals(other.Value) ?? other.Value is null,
        T1 other when ValueIndex is Union13Index.Value1 => EqualityComparer<T1?>.Default.Equals(Value1, other),
        T2 other when ValueIndex is Union13Index.Value2 => EqualityComparer<T2?>.Default.Equals(Value2, other),
        T3 other when ValueIndex is Union13Index.Value3 => EqualityComparer<T3?>.Default.Equals(Value3, other),
        T4 other when ValueIndex is Union13Index.Value4 => EqualityComparer<T4?>.Default.Equals(Value4, other),
        T5 other when ValueIndex is Union13Index.Value5 => EqualityComparer<T5?>.Default.Equals(Value5, other),
        T6 other when ValueIndex is Union13Index.Value6 => EqualityComparer<T6?>.Default.Equals(Value6, other),
        T7 other when ValueIndex is Union13Index.Value7 => EqualityComparer<T7?>.Default.Equals(Value7, other),
        T8 other when ValueIndex is Union13Index.Value8 => EqualityComparer<T8?>.Default.Equals(Value8, other),
        T9 other when ValueIndex is Union13Index.Value9 => EqualityComparer<T9?>.Default.Equals(Value9, other),
        T10 other when ValueIndex is Union13Index.Value10 => EqualityComparer<T10?>.Default.Equals(Value10, other),
        T11 other when ValueIndex is Union13Index.Value11 => EqualityComparer<T11?>.Default.Equals(Value11, other),
        T12 other when ValueIndex is Union13Index.Value12 => EqualityComparer<T12?>.Default.Equals(Value12, other),
        T13 other when ValueIndex is Union13Index.Value13 => EqualityComparer<T13?>.Default.Equals(Value13, other),
        _ => false
    };
    
    public override int GetHashCode() => ValueIndex switch {
        Union13Index.Value1 => EqualityComparer<T1?>.Default.GetHashCode(Value1),
        Union13Index.Value2 => EqualityComparer<T2?>.Default.GetHashCode(Value2),
        Union13Index.Value3 => EqualityComparer<T3?>.Default.GetHashCode(Value3),
        Union13Index.Value4 => EqualityComparer<T4?>.Default.GetHashCode(Value4),
        Union13Index.Value5 => EqualityComparer<T5?>.Default.GetHashCode(Value5),
        Union13Index.Value6 => EqualityComparer<T6?>.Default.GetHashCode(Value6),
        Union13Index.Value7 => EqualityComparer<T7?>.Default.GetHashCode(Value7),
        Union13Index.Value8 => EqualityComparer<T8?>.Default.GetHashCode(Value8),
        Union13Index.Value9 => EqualityComparer<T9?>.Default.GetHashCode(Value9),
        Union13Index.Value10 => EqualityComparer<T10?>.Default.GetHashCode(Value10),
        Union13Index.Value11 => EqualityComparer<T11?>.Default.GetHashCode(Value11),
        Union13Index.Value12 => EqualityComparer<T12?>.Default.GetHashCode(Value12),
        Union13Index.Value13 => EqualityComparer<T13?>.Default.GetHashCode(Value13)
    };
    
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return left.Equals(right);
    }
    
    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !left.Equals(right);
    }
    
    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T1? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T1? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T1? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T1? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T2? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T2? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T2? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T2? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T3? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T3? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T3? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T3? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T4? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T4? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T4? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T4? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T5? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T5? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T5? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T5? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T6? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T6? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T6? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T6? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T7? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T7? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T7? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T7? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T8? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T8? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T8? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T8? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T9? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T9? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T9? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T9? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T10? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T10? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T10? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T10? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T11? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T11? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T11? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T11? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T12? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T12? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T12? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T12? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }

    public static bool operator ==(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T13? right) {
        return left.Equals(right);
    }

    public static bool operator !=(Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> left, T13? right) {
        return !left.Equals(right);
    }

    public static bool operator ==(T13? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return right.Equals(left);
    }

    public static bool operator !=(T13? left, Union<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> right) {
        return !right.Equals(left);
    }
      
}