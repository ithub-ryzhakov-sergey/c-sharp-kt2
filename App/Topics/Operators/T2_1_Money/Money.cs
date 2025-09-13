namespace App.Topics.Operators.T2_1_Money;

public struct Money : IEquatable<Money>
{
    public string Currency { get; }
    public long Amount { get; }

    public Money(string currency, long amount)
    {
        if (string.IsNullOrEmpty(currency))
            throw new ArgumentException("Currency cannot be null or empty", nameof(currency));

        Currency = currency.ToUpperInvariant();
        Amount = amount;
    }

    // Реализация IEquatable<Money>
    public bool Equals(Money other)
    {
        return Currency == other.Currency && Amount == other.Amount;
    }

    // Переопределение Equals(object)
    public override bool Equals(object obj)
    {
        return obj is Money other && Equals(other);
    }

    // Переопределение GetHashCode
    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + Currency.GetHashCode();
            hash = hash * 23 + Amount.GetHashCode();
            return hash;
        }
    }

    // Перегрузка оператора ==
    public static bool operator ==(Money left, Money right)
    {
        return left.Equals(right);
    }

    // Перегрузка оператора !=
    public static bool operator !=(Money left, Money right)
    {
        return !left.Equals(right);
    }

    // Переопределение ToString для удобства отладки
    public override string ToString()
    {
        return $"{Amount} {Currency}";
    }
}