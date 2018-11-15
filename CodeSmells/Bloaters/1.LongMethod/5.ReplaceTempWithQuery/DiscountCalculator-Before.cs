namespace CodeSmells.Bloaters.LongMethod.ReplaceTempWithQuery
{
    class DiscountCalculator
    {
        int quantity;
        double itemPrice;
        double CalculateTotal()
        {
            double basePrice = quantity * itemPrice;

            if (basePrice > 1000)
            {
                return basePrice * 0.95;
            }
            else
            {
                return basePrice * 0.98;
            }
        }
    }
}
