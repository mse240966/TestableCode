using System;

namespace TestableCode.Example
{
    public interface IHoursCalculator
    {
        DateTime AddHoursToCurrentLocalTime(int hours);
    }
}
