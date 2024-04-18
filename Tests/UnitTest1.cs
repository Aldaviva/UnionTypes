using FluentAssertions;
using UnionTypes;

// ReSharper disable EqualExpressionComparison
// ReSharper disable SuspiciousTypeConversion.Global

namespace Tests;

public class UnitTest1 {

    [Fact]
    public void ImplicitCasts() {
        IList<Union<string, int>> path = ["xConfiguration", "Network", 1, "DNS", "Server", 3, "Address"];

        string actual = string.Join(' ', path);

        actual.Should().Be("xConfiguration Network 1 DNS Server 3 Address");
    }

    [Fact]
    public void Equality() {
        Union<string, int> a = "a";
        Union<string, int> b = "a";

        a.Should().Be(b);
        a.Equals(b).Should().BeTrue();
        b.Equals(a).Should().BeTrue();
        a.Equals("a").Should().BeTrue();
        (a == a).Should().BeTrue();
        (a != a).Should().BeFalse();
        (a == b).Should().BeTrue();
        (a == "a").Should().BeTrue();
        (a != "a").Should().BeFalse();
        a.GetHashCode().Should().Be(b.GetHashCode());
        a.Value.Should().Be("a");
        a.HasValue1.Should().BeTrue();
        a.Value1.Should().Be("a");

        Union<double, string> c = "a";
        a.Equals(c).Should().BeTrue();
        c.Equals(c).Should().BeTrue();

        Union<IntHolderA, IntHolderB> d = new(new IntHolderA(1));
        Union<IntHolderA, IntHolderB> e = new(new IntHolderB(1));
        Union<IntHolderB, IntHolderA> f = new(new IntHolderA(1));
        Union<IntHolderB, IntHolderA> g = new(new IntHolderB(1));
        d.Equals(e).Should().BeTrue();
        d.Equals(f).Should().BeTrue();
        d.Equals(g).Should().BeTrue();
        e.Equals(d).Should().BeTrue();
        e.Equals(f).Should().BeTrue();
        e.Equals(g).Should().BeTrue();
        f.Equals(d).Should().BeTrue();
        f.Equals(e).Should().BeTrue();
        f.Equals(g).Should().BeTrue();
        g.Equals(d).Should().BeTrue();
        g.Equals(e).Should().BeTrue();
        g.Equals(f).Should().BeTrue();
    }

    [Fact]
    public void Inequality() {
        Union<string, int> a = "a";
        Union<string, int> b = "b";

        a.Should().NotBe(b);
        a.Equals(b).Should().BeFalse();
        b.Equals(a).Should().BeFalse();
        a.Equals("b").Should().BeFalse();
        a.Equals(1).Should().BeFalse();
        (a == b).Should().BeFalse();
        (a != b).Should().BeTrue();
        (a == "b").Should().BeFalse();
        (a != "b").Should().BeTrue();
        a.GetHashCode().Should().NotBe(b.GetHashCode());
        (a == 1).Should().BeFalse();
        (a != 1).Should().BeTrue();
    }

}