using System;

namespace TestableCode.Example.UnitTests
{
    public class AddHoursToCurrentTimeTestData
    {
        public DateTime CurrentDateTime { get; set; }
        public DateTime ExpectedResult { get; set; }
        public int Hours { get; set; }
    }
}
