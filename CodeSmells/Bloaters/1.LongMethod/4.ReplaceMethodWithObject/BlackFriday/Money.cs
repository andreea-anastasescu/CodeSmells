namespace CodeSmells.Bloaters._1.LongMethod._4.ReplaceMethodWithObject.BlackFriday
{
    public struct Money
    {
        public Money(Currency currency, decimal amount)
        {
            Currency = currency;
            Amount = amount;
        }

        public Currency Currency { get; }
        public decimal Amount { get; }

        public override string ToString()
        {
            return $"Currency: {Currency}, Amount: {Amount}";
        }
    }
}
