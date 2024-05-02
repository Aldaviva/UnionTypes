using System.Text;

namespace Generator;

public class UnionTypeGenerator(int typeCount) {

    private const int MaxUnionSize = 16;

    private static readonly Encoding Utf8 = new UTF8Encoding(false, true);

    public static async Task Main() {
        for (int unionSize = 2; unionSize <= MaxUnionSize; unionSize++) {
            UnionTypeGenerator generator    = new(unionSize);
            string             filePath     = Path.GetFullPath($@"..\..\..\..\UnionTypes\Union{unionSize}.cs");
            string             fileContents = generator.GenerateUnionType();
            await File.WriteAllTextAsync(filePath, fileContents, Utf8);
            Console.WriteLine(filePath);
        }
    }

    public string GenerateUnionType() =>
        $$"""
          using System;
          using System.CodeDom.Compiler;
          using System.Collections.Generic;
          using System.Diagnostics;

          namespace UnionTypes;

          /// <summary>
          /// Indicates which constituent value is used by a union type instance
          /// </summary>
          [GeneratedCode("Aldaviva/UnionTypes", null)]
          public enum Union{{typeCount}}Index {

          {{JoinEach(i => $"    /// <summary>Union type's value is of the union's {Nth(i)} type</summary>\r\n    Value{i} = {i}", ",\r\n\r\n")}}

          }

          /// <summary>
          /// A union type whose value can be 1 of {{typeCount}} possible types.
          /// </summary>
          {{JoinEach(i => $"/// <typeparam name=\"T{i}\">Possible type of value {i}</typeparam>")}}
          [GeneratedCode("Aldaviva/UnionTypes", null)]
          [DebuggerDisplay("{Value}")]
          public readonly struct Union<{{GenericPlaceholders()}}>: IUnion, IEquatable<Union<{{GenericPlaceholders()}}>> {
            
              /// <summary>
              /// Which constituent type the value current has
              /// </summary>
              public Union{{typeCount}}Index ValueIndex { get; }
              
          {{JoinEach(i => $"    /// <summary>The value of the union type if <see cref=\"HasValue{i}\"/> is <c>true</c>, or equivalently if <see cref=\"ValueIndex\"/> is <see cref=\"Union{typeCount}Index.Value{i}\"/>; otherwise <c>default</c>.</summary>\r\n    public T{i}? Value{i} {{ get; }}", "\r\n\r\n")}}

          {{JoinEach(i =>
              $$"""
                    /// <summary>
                    /// Create an instance of the union type with the given value.
                    /// </summary>
                    /// <param name="value{{i}}">The value of the union type</param>
                    public Union(T{{i}}? value{{i}}) {
                        Value{{i}} = value{{i}};
                        ValueIndex = Union{{typeCount}}Index.Value{{i}};
                    }
                """, "\r\n\r\n")}}
            
              /// <inheritdoc />
              public object? Value => ValueIndex switch {
          {{JoinEach(i => $"        Union{typeCount}Index.Value{i} => Value{i}", ",\r\n")}}
              };
              
              /// <inheritdoc />
              public Type ValueType => ValueIndex switch {
          {{JoinEach(i => $"        Union{typeCount}Index.Value{i} => typeof(T{i})", ",\r\n")}}
              };
              
          {{JoinEach(i => $"    /// <summary><c>true</c> if the value of the union type is <see cref=\"Value1\"/>, false otherwise</summary>\r\n    public bool HasValue{i} => ValueIndex == Union{typeCount}Index.Value{i};")}}
              
          {{JoinEach(i => $"    /// <summary>\r\n    /// Implicitly cast a value to this union type\r\n    /// </summary>\r\n    /// <param name=\"value\">Value of the union type</param>\r\n    public static implicit operator Union<{GenericPlaceholders()}>(T{i}? value) => new(value);", "\r\n\r\n")}}
              
              /// <inheritdoc cref="Object.ToString"/>
              public override string? ToString() => ValueIndex switch {
          {{JoinEach(i => $"        Union{typeCount}Index.Value{i} => Value{i}?.ToString()", ",\r\n")}}
              };
              
              /// <inheritdoc />
              public bool Equals(Union<{{GenericPlaceholders()}}> other) => ValueIndex switch {
          {{JoinEach(i => $"        Union{typeCount}Index.Value{i} when other.ValueIndex is Union{typeCount}Index.Value{i} => EqualityComparer<T{i}?>.Default.Equals(Value{i}, other.Value{i}),")}}
                  _ => Value?.Equals(other.Value) ?? other.Value is null
              };
              
          {{JoinEach(i =>
              $$"""
                    /// <inheritdoc cref="IEquatable{T}.Equals(T)" />
                    public bool Equals(T{{i}}? other) => ValueIndex switch {
                {{JoinEach(j => $"        Union{typeCount}Index.Value{j} => " + (i == j
                    ? $"EqualityComparer<T{i}?>.Default.Equals(Value{i}, other)"
                    : $"Value{j} is not null ? Value{j}.Equals(other) : other is null"), ",\r\n")}}
                    };
                """, "\r\n\r\n")}}
                    
              /// <inheritdoc />
              public override bool Equals(object? obj) => obj switch {
                  Union<{{GenericPlaceholders()}}> other => Equals(other),
                  IUnion other => Value?.Equals(other.Value) ?? other.Value is null,
          {{JoinEach(i => $"        T{i} other when ValueIndex is Union{typeCount}Index.Value{i} => EqualityComparer<T{i}?>.Default.Equals(Value{i}, other),")}}
                  _ => false
              };
              
              /// <inheritdoc />
              public override int GetHashCode() => ValueIndex switch {
          {{JoinEach(i => $"        Union{typeCount}Index.Value{i} => EqualityComparer<T{i}?>.Default.GetHashCode(Value{i})", ",\r\n")}}
              };
              
              /// <summary>
              /// Check if two union types are equal
              /// </summary>
              /// <param name="left">Union type</param>
              /// <param name="right">Another union type with the same signature as <paramref name="left"/></param>
              /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
              public static bool operator ==(Union<{{GenericPlaceholders()}}> left, Union<{{GenericPlaceholders()}}> right) {
                  return left.Equals(right);
              }
              
              /// <summary>
              /// Check if two union types are not equal
              /// </summary>
              /// <param name="left">Union type</param>
              /// <param name="right">Another union type with the same signature as <paramref name="left"/></param>
              /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
              public static bool operator !=(Union<{{GenericPlaceholders()}}> left, Union<{{GenericPlaceholders()}}> right) {
                  return !left.Equals(right);
              }
              
          {{JoinEach(i =>
              $$"""
                    /// <summary>
                    /// Check if a union type is equal to a value
                    /// </summary>
                    /// <param name="left">Union type</param>
                    /// <param name="right">Value</param>
                    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
                    public static bool operator ==(Union<{{GenericPlaceholders()}}> left, T{{i}}? right) {
                        return left.Equals(right);
                    }
                
                    /// <summary>
                    /// Check if a union type is not equal to a value
                    /// </summary>
                    /// <param name="left">Union type</param>
                    /// <param name="right">Value</param>
                    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
                    public static bool operator !=(Union<{{GenericPlaceholders()}}> left, T{{i}}? right) {
                        return !left.Equals(right);
                    }
                
                    /// <summary>
                    /// Check if a value is equal to a union type
                    /// </summary>
                    /// <param name="left">Value</param>
                    /// <param name="right">Union type</param>
                    /// <returns><c>true</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>false</c> otherwise</returns>
                    public static bool operator ==(T{{i}}? left, Union<{{GenericPlaceholders()}}> right) {
                        return right.Equals(left);
                    }
                
                    /// <summary>
                    /// Check if a value is not equal to a union type
                    /// </summary>
                    /// <param name="left">Value</param>
                    /// <param name="right">Union type</param>
                    /// <returns><c>false</c> if <paramref name="left"/> and <paramref name="right"/> are equal, <c>true</c> otherwise</returns>
                    public static bool operator !=(T{{i}}? left, Union<{{GenericPlaceholders()}}> right) {
                        return !right.Equals(left);
                    }
                """, "\r\n\r\n")}}
                
              /// <summary>
              /// <para>Deconstruct union type into variables, one of which will be <see cref="Value"/> and the rest of which will be <c>default</c>.</para>
              /// <para>Can be called with tuple assignment syntax:</para>
              /// <para><c>({{JoinEach(i => $"T{i}? val{i}", ", ")}}) = myUnionType;</c></para>
              /// <para>Can also be called directly with <c>out</c> variables:</para>
              /// <para><c>myUnionType.Deconstruct({{JoinEach(i => $"out T{i}? val{i}", ", ")}});</c></para>
              /// </summary>
          {{JoinEach(i => $"    /// <param name=\"value{i}\">Value of type <typeparamref name=\"T{i}\"/> if <see cref=\"ValueIndex\"/> is <see cref=\"Union{typeCount}Index.Value{i}\"/>, otherwise <c>default</c>.</param>")}}
              public void Deconstruct({{JoinEach(i => $"out T{i}? value{i}", ", ")}}) {
          {{JoinEach(i => $"        value{i} = Value{i};")}}
              }
          }
          """;

    private static string Nth(int n) => n.ToString("N0") + Math.Abs(n) switch {
        11 or 12 or 13             => "th",
        var abs when abs % 10 is 1 => "st",
        var abs when abs % 10 is 2 => "nd",
        var abs when abs % 10 is 3 => "rd",
        _                          => "th"
    };

    private string GenericPlaceholders() => JoinEach(i => $"T{i}", ", ");

    private string JoinEach(Func<int, string> f, string joiner = "\r\n") => string.Join(joiner, Enumerable.Range(1, typeCount).Select(f));

}