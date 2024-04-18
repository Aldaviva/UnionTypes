namespace Tests;

internal readonly struct IntHolderB(int value): IEquatable<IntHolderB> {

    public int Value { get; } = value;

    public bool Equals(IntHolderB other) {
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

    public static bool operator ==(IntHolderB left, IntHolderB right) {
        return left.Equals(right);
    }

    public static bool operator !=(IntHolderB left, IntHolderB right) {
        return !left.Equals(right);
    }

}