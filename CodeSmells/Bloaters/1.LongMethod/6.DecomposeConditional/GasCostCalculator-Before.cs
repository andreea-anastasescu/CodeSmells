using System;

namespace CodeSmells.Bloaters.LongMethod.DecomposeConditional
{
    class GasCostCalculator
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
            if (date < SUMMER_START || date > SUMMER_END)
            {
                charge = quantity * winterRate + winterServiceCharge;
            }
            else
            {
                charge = quantity * summerRate;
            }
        }
    }
}
