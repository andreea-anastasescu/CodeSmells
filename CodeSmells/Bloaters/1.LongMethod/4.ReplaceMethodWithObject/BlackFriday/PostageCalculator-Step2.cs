using System;

namespace CodeSmells.Bloaters._1.LongMethod._4.ReplaceMethodWithObject.BlackFriday
{
    internal class PackageStep2
    {
        private readonly int weight;
        private readonly int height;
        private readonly int width;
        private readonly int depth;
       
        internal PackageStep2(int weight, int height, int width, int depth)
        {
            this.weight = weight;
            this.height = height;
            this.width = width;
            this.depth = depth;
        }
        internal decimal PostageInBaseCurrency()
        {
            if (weight <= 60 && height <= 229 && width <= 162 && depth <= 25)
            {
                return 120m;
            }
            if (weight <= 500 && height <= 324 && width <= 229 && depth <= 100)
            {
                return weight * 4;
            }
            return Math.Max(weight, height * width * depth / 1000m) * 6;
        }
    }
    
    public class CalculatorStep2
    {
        public Money Calculate(int weight, int height, int width, int depth, Currency currency)
        {
            PackageStep2 package = new PackageStep2(weight, height, width, depth);
            decimal postageInBaseCurrency = package.PostageInBaseCurrency();
            return ConvertCurrency(postageInBaseCurrency, currency);
        }


        private Money ConvertCurrency(decimal amountInBaseCurrency, Currency currency)
        {
            if (currency == Currency.Gbp)
                return new Money(Currency.Gbp, amountInBaseCurrency);
            if (currency == Currency.Eur)
                return new Money(Currency.Eur, (amountInBaseCurrency + 200) * 1.25m);
            if (currency == Currency.Chf)
                return new Money(Currency.Chf, (amountInBaseCurrency + 200) * 1.36m);
            throw new Exception("Currency not supported");
        }
    }
}