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

          namespace UnionTypes;

          [GeneratedCode("Aldaviva/UnionTypes", null)]
          public enum Union{{typeCount}}Index {

          {{JoinEach(i => $"    Value{i} = {i}", ",\r\n")}}

          }

          [GeneratedCode("Aldaviva/UnionTypes", null)]
          public readonly struct Union<{{GenericPlaceholders()}}>: IUnion, IEquatable<Union<{{GenericPlaceholders()}}>> {
            
              public Union{{typeCount}}Index ValueIndex { get; }
          {{JoinEach(i => $"    public T{i}? Value{i} {{ get; }}")}}

          {{JoinEach(i =>
              $$"""
                    public Union(T{{i}}? value) {
                        Value{{i}} = value;
                        ValueIndex = Union{{typeCount}}Index.Value{{i}};
                    }
                """, "\r\n\r\n")}}
            
              public object? Value => ValueIndex switch {
          {{JoinEach(i => $"        Union{typeCount}Index.Value{i} => Value{i}", ",\r\n")}}
              };
              
          {{JoinEach(i => $"    public bool HasValue{i} => ValueIndex == Union{typeCount}Index.Value{i};")}}
              
          {{JoinEach(i => $"    public static implicit operator Union<{GenericPlaceholders()}>(T{i}? value) => new(value);")}}
              
              public override string? ToString() => ValueIndex switch {
          {{JoinEach(i => $"        Union{typeCount}Index.Value{i} => Value{i}?.ToString()", ",\r\n")}}
              };
              
              public bool Equals(Union<{{GenericPlaceholders()}}> other) => ValueIndex switch {
          {{JoinEach(i => $"        Union{typeCount}Index.Value{i} when other.ValueIndex is Union{typeCount}Index.Value{i} => EqualityComparer<T{i}?>.Default.Equals(Value{i}, other.Value{i}),")}}
                  _ => Value?.Equals(other.Value) ?? other.Value is null
              };
              
          {{JoinEach(i =>
              $$"""
                    public bool Equals(T{{i}}? other) => ValueIndex switch {
                {{JoinEach(j => $"        Union{typeCount}Index.Value{j} => " + (i == j
                    ? $"EqualityComparer<T{i}?>.Default.Equals(Value{i}, other)"
                    : $"Value{j} is not null ? Value{j}.Equals(other) : other is null"), ",\r\n")}}
                    };
                """, "\r\n\r\n")}}
                    
              public override bool Equals(object? obj) => obj switch {
                  Union<{{GenericPlaceholders()}}> other => Equals(other),
                  IUnion other => Value?.Equals(other.Value) ?? other.Value is null,
          {{JoinEach(i => $"        T{i} other when ValueIndex is Union{typeCount}Index.Value{i} => EqualityComparer<T{i}?>.Default.Equals(Value{i}, other),")}}
                  _ => false
              };
              
              public override int GetHashCode() => ValueIndex switch {
          {{JoinEach(i => $"        Union{typeCount}Index.Value{i} => EqualityComparer<T{i}?>.Default.GetHashCode(Value{i})", ",\r\n")}}
              };
              
              public static bool operator ==(Union<{{GenericPlaceholders()}}> left, Union<{{GenericPlaceholders()}}> right) {
                  return left.Equals(right);
              }
              
              public static bool operator !=(Union<{{GenericPlaceholders()}}> left, Union<{{GenericPlaceholders()}}> right) {
                  return !left.Equals(right);
              }
              
          {{JoinEach(i =>
              $$"""
                    public static bool operator ==(Union<{{GenericPlaceholders()}}> left, T{{i}}? right) {
                        return left.Equals(right);
                    }
                
                    public static bool operator !=(Union<{{GenericPlaceholders()}}> left, T{{i}}? right) {
                        return !left.Equals(right);
                    }
                
                    public static bool operator ==(T{{i}}? left, Union<{{GenericPlaceholders()}}> right) {
                        return right.Equals(left);
                    }
                
                    public static bool operator !=(T{{i}}? left, Union<{{GenericPlaceholders()}}> right) {
                        return !right.Equals(left);
                    }
                """, "\r\n\r\n")}}
                
          }
          """;

    private string GenericPlaceholders() {
        return JoinEach(i => $"T{i}", ", ");
    }

    private string JoinEach(Func<int, string> f, string joiner = "\r\n") {
        return string.Join(joiner, Enumerable.Range(1, typeCount).Select(f));
    }

}