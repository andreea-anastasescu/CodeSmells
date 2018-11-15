using System;

namespace CodeSmells.Bloaters.LongMethod.PreserveWholeObject
{
    internal class Plan
    {
        internal static int GetThermicFactor(int low, int high)
        {
            throw new NotImplementedException();
        }

        internal static int GetThermicFactor(Sample.TemperatureRange temperatureRange)
        {
            throw new NotImplementedException();
        }
    }
}