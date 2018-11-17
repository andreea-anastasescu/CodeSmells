using System;

namespace CodeSmells.Bloaters._1.LongMethod._4.ReplaceMethodWithObject.BlackFriday
{

    public class Package
    {
        
        public Package(int weight, int height, int width, int depth)
        {
            this.Weight = weight;
            this.Height = height;
            this.Width = width;
            this.Depth = depth;            
        }

        internal int Weight {  get; private set; }
        internal int Height { get; private set; }
        internal int Width { get; private set; }
        internal int Depth { get; private set; }
    }

    public class CalculatorStep1
    {
        public Money Calculate(int weight, int height, int width, int depth, Currency currency)
        {
            Package package = new Package( weight, height, width, depth);
            var postageInBaseCurrency = PostageInBaseCurrency(package);
            return ConvertCurrency(postageInBaseCurrency, currency);
        }

        private decimal PostageInBaseCurrency(Package package)
        {
            if (package.Weight <= 60 && package.Height <= 229 && package.Width <= 162 && package.Depth <= 25)
            {
                return 120m;
            }
            if (package.Weight <= 500 && package.Height <= 324 && package.Width <= 229 && package.Depth <= 100)
            {
                return package.Weight * 4;
            }
            return Math.Max(package.Weight, package.Height * package.Width * package.Depth / 1000m) * 6;
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