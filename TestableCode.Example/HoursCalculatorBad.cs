using System;

namespace TestableCode.Example
{
    public class HoursCalculatorBad : IHoursCalculator
    {
        public DateTime AddHoursToCurrentTime(int hours)
        {
            // This is shite it cannot be tested
            return DateTime.Now.AddHours(hours);
        }
    }
}
