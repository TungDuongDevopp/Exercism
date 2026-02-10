public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    private static bool sameCurrency(CurrencyAmount left, CurrencyAmount right)
        => left.currency == right.currency;

    public override bool Equals(object obj)
    {
        if (obj is not CurrencyAmount other)
            return false;

        return currency == other.currency
            && amount == other.amount;
    }

    public override int GetHashCode()
        => HashCode.Combine(amount, currency);

    public static bool operator ==(CurrencyAmount left, CurrencyAmount right)
        => sameCurrency(left, right)? left.Equals(right) : throw new ArgumentException();

    public static bool operator !=(CurrencyAmount left, CurrencyAmount right)
        => sameCurrency(left, right)? !left.Equals(right) : throw new ArgumentException();

    public static bool operator >(CurrencyAmount left, CurrencyAmount right)
        => sameCurrency(left, right)
            ? left.amount > right.amount
            : throw new ArgumentException();

    public static bool operator <(CurrencyAmount left, CurrencyAmount right)
        => sameCurrency(left, right)
            ? left.amount < right.amount
            : throw new ArgumentException();

    public static CurrencyAmount operator +(CurrencyAmount left, CurrencyAmount right)
        => sameCurrency(left, right)
            ? new CurrencyAmount(left.amount + right.amount, left.currency)
            : throw new ArgumentException();

    public static CurrencyAmount operator -(CurrencyAmount left, CurrencyAmount right)
        => sameCurrency(left, right)
            ? new CurrencyAmount(left.amount - right.amount, left.currency)
            : throw new ArgumentException();

    public static CurrencyAmount operator *(CurrencyAmount left, decimal number)
        => new CurrencyAmount(left.amount * number, left.currency);

    public static CurrencyAmount operator /(CurrencyAmount left, decimal number)
        => number == 0
            ? throw new DivideByZeroException()
            : new CurrencyAmount(left.amount / number, left.currency);

    public static implicit operator decimal(CurrencyAmount c)
    => c.amount;

    public static explicit operator double(CurrencyAmount c)
        => (double)c.amount;
}
