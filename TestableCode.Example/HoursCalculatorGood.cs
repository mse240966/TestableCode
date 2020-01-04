using System;

namespace TestableCode.Example
{
    public class HoursCalculatorGood : IHoursCalculator
    {
        public DateTime AddHoursToCurrentLocalTime(int hours)
        {
            throw new NotImplementedException();
        }
    }
}
