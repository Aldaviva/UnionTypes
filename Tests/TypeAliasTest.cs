using FluentAssertions;
using UnionTypes;

namespace Tests;

// Type aliases are a C# 12 feature: https://blog.jetbrains.com/dotnet/2023/09/25/rsrp-2023-3-eap1/#working-with-aliases
using Cluster = Union<TypeAliasTest.WellKnownCluster, string>;
using XPathSegment = Union<string, int>;

public class TypeAliasTest {

    [Fact]
    public void TypeAliasWorks() {
        Cluster cluster = new(WellKnownCluster.Prod);
        cluster.Value.Should().Be(WellKnownCluster.Prod);
    }

    internal enum WellKnownCluster {

        Prod,
        Stage,
        Test

    }

    [Fact]
    public void ReadmeTest() {
        IList<XPathSegment> path = ["xConfiguration", "Network", 1, "DNS", "Server", 3, "Address"];
        string message = path[0].Switch(
            case1: first => $"First item is string {first.Trim()}",
            case2: first => $"First item is int {Math.Abs(first)}"
        );

        string message2 = "";
        path[0].Switch(
            case1: first => { message2 = $"First item is string {first.Trim()}"; },
            case2: first => { message2 = $"First item is int {Math.Abs(first)}"; }
        );
        Console.WriteLine(message2);
    }

}