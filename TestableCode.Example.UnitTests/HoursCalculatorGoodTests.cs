using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestableCode.Example.UnitTests
{
    public class HoursCalculatorGoodTests
    {
        public IHoursCalculator _hoursCalculator;

        [TestCaseSource("AddHoursToCurrentTimeTestData")]
        public void Test_AddHoursToCurrentTime_Returns_Correct_Value(AddHoursToCurrentTimeTestData testCaseData)
        {
            _hoursCalculator = new HoursCalculatorGood();
        }

        public IEnumerable<AddHoursToCurrentTimeTestData> AddHoursToCurrentTimeTestData()
        {
            yield return new AddHoursToCurrentTimeTestData() { CurrentDateTime = new DateTime(2020, 01, 02, 08, 30, 10), ExpectedResult = new DateTime(2020, 01, 02, 10, 30, 10), Hours = 2 };
        }

    }
}
