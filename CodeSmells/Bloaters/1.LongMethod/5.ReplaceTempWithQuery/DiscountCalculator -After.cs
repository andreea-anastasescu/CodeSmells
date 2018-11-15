namespace CodeSmells.Bloaters.LongMethod.ReplaceTempWithQuery
{
    class DiscountCalculator2
    {
        int quantity;
        double itemPrice;
        double CalculateTotal()
        {
            if (BasePrice() > 1000)
            {
                return BasePrice() * 0.95;
            }
            else
            {
                return BasePrice() * 0.98;
            }
        }
        double BasePrice()
        {
            return quantity * itemPrice;
        }
    }
}
