using FluentAssertions;
using UnionTypes;

#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
#pragma warning disable CS1718 // Comparison made to same variable

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
        a.ValueType.Should().Be(typeof(string));

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

    [Fact]
    public void Switching() {
        Union<string, int> a = "a";
        string actual = a switch {
            { Value1: { } val } => val,
            { Value2: var val } => val.ToString()
        };
        actual.Should().Be("a");

        actual = a.Switch(s => s!, i => i.ToString());
        actual.Should().Be("a");

        Union<string, int> b = 8;
        actual = b switch {
            { Value1: { } val } => val,
            { Value2: var val } => val.ToString()
        };
        actual.Should().Be("8");

        actual = b.Switch(s => s!, i => i.ToString());
        actual.Should().Be("8");

        Union<int, long> c = 17;
        actual = c switch {
            { ValueIndex: Union2Index.Value1, Value1: var val } => "int " + val,
            { ValueIndex: Union2Index.Value2, Value2: var val } => "long " + val
        };
        actual.Should().Be("int 17");

        Union<int, long> d = 88L;
        actual = d switch {
            { HasValue1: true, Value1: var val } => "int " + val,
            { HasValue2: true, Value2: var val } => "long " + val
        };
        actual.Should().Be("long 88");

        actual = d switch {
            { Value: int val }  => "int " + val,
            { Value: long val } => "long " + val
        };
        actual.Should().Be("long 88");

        d.Switch(i => { actual = "int " + i; }, l => { actual = "long " + l; });
        actual.Should().Be("long 88");
    }

    [Fact]
    public void Deconstruction() {
        Union<string, int> a = "a";
        (string? actual1, int actual2) = a;
        actual1.Should().Be("a");
        actual2.Should().Be(0);

        a.Deconstruct(out actual1, out actual2);
        actual1.Should().Be("a");
        actual2.Should().Be(0);
    }

    [Fact]
    public void SameType() {
        Union<int, int> allInts = new(value1: 1);
        allInts.HasValue1.Should().BeTrue();
        allInts.ValueIndex.Should().Be(Union2Index.Value1);
        allInts.Value1.Should().Be(1);
        allInts.Value2.Should().Be(0);
    }

    [Fact]
    public void NullReferenceTypes() {
        var a = new Union<string?, int>(null);
        a.HasValue1.Should().BeTrue();
        a.Value1.Should().BeNull();
        a.ValueIndex.Should().Be(Union2Index.Value1);
        a.ValueType.Should().Be(typeof(string));
    }

    [Fact]
    public void NullValueTypes() {
        var a = new Union<string, int?>((int?) null);
        a.HasValue2.Should().BeTrue();
        a.Value2.Should().BeNull();
        a.ValueIndex.Should().Be(Union2Index.Value2);
        a.ValueType.Should().Be(typeof(int?));
    }

}