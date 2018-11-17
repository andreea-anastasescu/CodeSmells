
namespace CodeSmells.Bloaters.LongMethod.PreserveWholeObject
{
    class Sample
    {
        void PlanTripClothings()
        { 

            int low = GetTemperatureRange().getLow();
            int high = GetTemperatureRange().getHigh();
            //...
            int thermicFactor  = Plan.GetThermicFactor(low, high);
        }

        void PlanTripClothings2()
        {

            //...
            int thicknessFactor = Plan.GetThermicFactor(GetTemperatureRange());
        }
               
        private TemperatureRange GetTemperatureRange()
        {
            //reads from stats
            return new TemperatureRange();
        }

        internal class TemperatureRange
        {
            internal int getLow()
            {
               return 10;
            }

            internal int getHigh()
            {
                //read from statistics
                return 20;
            }

        }
    }
}
