namespace Tests;

internal readonly struct IntHolderA(int value): IEquatable<IntHolderA> {

    public int Value { get; } = value;

    public bool Equals(IntHolderA other) {
        return Value == other.Value;
    }

    public override bool Equals(object? obj) => obj switch {
        IntHolderA other => Value == other.Value,
        IntHolderB other => Value == other.Value,
        _                => false
    };

    public override int GetHashCode() {
        return Value;
    }

    public static bool operator ==(IntHolderA left, IntHolderA right) {
        return left.Equals(right);
    }

    public static bool operator !=(IntHolderA left, IntHolderA right) {
        return !left.Equals(right);
    }

}