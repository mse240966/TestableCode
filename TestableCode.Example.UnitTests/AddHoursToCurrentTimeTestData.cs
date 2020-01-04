using System;

namespace TestableCode.Example.UnitTests
{
    public class AddHoursToCurrentTimeTestData
    {
        public DateTime CurrentUtcDateTime { get; set; }
        public DateTime ExpectedLocalDateTime { get; set; }
        public int Hours { get; set; }
    }
}
