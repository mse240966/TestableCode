using System;

namespace TestableCode.Example
{
    public interface IHoursCalculator
    {
        DateTime AddHoursToCurrentTime(int hours);
    }
}
