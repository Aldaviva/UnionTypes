using FluentAssertions;
using UnionTypes;

namespace Tests;

// Type aliases are a C# 12 feature: https://blog.jetbrains.com/dotnet/2023/09/25/rsrp-2023-3-eap1/#working-with-aliases
using Cluster = Union<TypeAliasTest.WellKnownCluster, string>;

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

}