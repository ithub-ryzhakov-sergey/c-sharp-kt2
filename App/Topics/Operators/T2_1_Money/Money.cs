// Topic: Operators — T2.1 Money (==, !=, Equals/GetHashCode)
// Задача: реализовать value object для денег.
// Требования:
// - Реализовать IEquatable<Money>, переопределить Equals(object), GetHashCode, операторы == и !=.
// - Деньги равны только если совпадают и валюта, и сумма.
// Подсказка: подумайте о нормализации регистра Currency (например, ToUpperInvariant) — оговорено в тестах.

namespace App.Topics.Operators.T2_1_Money;

public struct Money : IEquatable<Money>
{
    public string Currency { get; init; }
    public long Amount { get; init; }
    public Money(string currency, long amount)
    {
        if (currency == null || currency.Trim() == "")
        {
            throw new ArgumentException();
        }
        this.Currency = currency.Trim().ToUpper();
        this.Amount = amount;
    }
    // 3) Перегрузите операторы == и != в соответствии с требованиями.
    public static Money operator +(Money moneyFirst, Money moneySecond)
    {
        if (moneyFirst.Currency != moneySecond.Currency) {
            throw new InvalidOperationException();
        }
        return new Money(moneyFirst.Currency, moneyFirst.Amount+moneySecond.Amount);
    }
    public static Money operator -(Money moneyFirst, Money moneySecond)
    {
        if (moneyFirst.Currency != moneySecond.Currency) {
            throw new InvalidOperationException();
        }
        return new Money(moneyFirst.Currency, moneyFirst.Amount-moneySecond.Amount);
    }
    public static Money operator ++(Money money)
    {
        return new Money(money.Currency, money.Amount+1);
    }
    public static Money operator --(Money money)
    {
        return new Money(money.Currency, money.Amount-1);
    }
    public static bool operator ==(Money moneyFirst, Money moneySecond)
    {
        return moneyFirst.Currency == moneySecond.Currency ? moneyFirst.Amount == moneySecond.Amount ? true : false : false;
    }
    public static bool operator !=(Money moneyFirst, Money moneySecond)
    {
        return moneyFirst.Currency == moneySecond.Currency ? moneyFirst.Amount == moneySecond.Amount ? false : true : true;
    }
    public bool Equals(Money other)
    {
        throw new NotImplementedException();
    }
}
