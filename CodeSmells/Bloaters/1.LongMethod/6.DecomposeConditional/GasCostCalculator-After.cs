using System;

namespace CodeSmells.Bloaters.LongMethod.DecomposeConditional
{
    class GasCostCalculator2
    {
        private readonly DateTime SUMMER_START;

        private readonly DateTime SUMMER_END;
        private double charge;
        private double quantity;
        private double winterRate;
        private double winterServiceCharge;
        private double summerRate;

        public void Calculate()
        {
            DateTime date = DateTime.Now;
            if (isSummer(date))
            {
                charge = SummerCharge(quantity);
            }
            else
            {
                charge = WinterCharge(quantity);
            }
        }

        private bool isSummer(DateTime date)
        {
            return (date < SUMMER_START || date > SUMMER_END);
        }
        private double WinterCharge(double quantity)
        {
            return quantity * winterRate + winterServiceCharge;
        }

        private double SummerCharge(double quantity)
        {
            return charge = quantity * summerRate;
        }
    }

}
