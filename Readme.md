UnionTypes
===

[![NuGet](https://img.shields.io/nuget/v/UnionTypes)](https://www.nuget.org/packages/UnionTypes/) [![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/Aldaviva/UnionTypes/dotnetpackage.yml?branch=master&logo=github)](https://github.com/Aldaviva/UnionTypes/actions/workflows/dotnetpackage.yml)

## Introduction

A union type is a type whose value can be any one of a specific set of types. For example, you may define a union type whose value must be either an `int` or a `string`.

Once defined, you can use instances of this union in a type safe way. For example, if you want a list that can contain only `string` and `int` values, but no other types, you can create a `List<T>` whose generic type is your new union type, instead of making a `List<object>` that could allow values of other types to be added. This way, you don't have to check whether or not each value is either a `string` or `int` when you read them, because it's statically guaranteed at compile time.

## Usage

### Dependencies

[This package is available on NuGet Gallery.](https://www.nuget.org/packages/UnionTypes/)

It can run in .NET Standard 2.0 runtimes and later, as well as .NET Framework 4.5.2 and later.

```sh
dotnet add package UnionTypes
```

### Writing

```cs
using UnionTypes;

Union<string, int> myUnion = "hi";

IList<Union<string, int>> path = ["xConfiguration", "Network", 1, "DNS", "Server", 3, "Address"];
string message = string.Join(' ', path); // "xConfiguration Network 1 DNS Server 3 Address"
```

#### Type alias

You can make the type more readable by [aliasing](https://blog.jetbrains.com/dotnet/2023/09/25/rsrp-2023-3-eap1/#working-with-aliases) a meaningful name to it. This is a C# 12 feature.

```cs
using XPathSegment = Union<string, int>;

IList<XPathSegment> path = ["xConfiguration", "Network", 1, "DNS", "Server", 3, "Address"];
```

### Reading

For each of the union's constituent types, you can test if the value of an instance of the union type is of that constituent type with the `HasValue1` and other properties, or `ValueIndex`. You can get the strongly-typed value with the related `Value1` and other properties.

```cs
if (path[0].HasValue1) {
    string message = $"First item is the string {path[0].Value1}"; // "First item is xConfiguration"
}
```

```cs
if (path[0] is { HasValue1: true, Value1: var firstItem }) {
    string message = $"First item is {firstItem?.Trim()}"; // "First item is xConfiguration"
}
```

```cs
if (path[0].ValueIndex == Union2Index.Value1) {
    string message = $"First item is the string {path[0].Value1}"; // "First item is xConfiguration"
}
```

```cs
string message = path[0] switch {
    { ValueIndex: Union2Index.Value1, Value1: var first } => $"First item is string {first?.Trim()}",
    { ValueIndex: Union2Index.Value2, Value2: var first } => $"First item is int {Math.Abs(first)}",
};
```

If you don't need the value to be strongly typed, you can get it as an `object` using the `Value` property.

```cs
Console.WriteLine($"{path[0].ValueType} {path[0].Value}); // System.String xConfiguration
```

## Union size

This library allows unions of 2 or more types, up to a maximum limit of 16 types.