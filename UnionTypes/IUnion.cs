namespace UnionTypes;

/// <summary>
/// <para>Non-generic union type that can return a weakly-typed value.</para>
/// <para>For strongly-typed union types, see <see cref="Union{T1,T2}"/> and related types.</para>
/// </summary>
public interface IUnion {

    /// <summary>
    /// <para>The untyped value of the union type.</para>
    /// <para>To get a strongly typed value, use <c>Value1</c>, <c>Value2</c>, etc.</para>
    /// </summary>
    object? Value { get; }

}