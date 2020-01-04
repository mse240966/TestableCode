using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestableCode.Common;

namespace TestableCode.Example.UnitTests
{
    [TestFixture]
    public class HoursCalculatorGoodTests
    {
        public IHoursCalculator _hoursCalculator;
        public Mock<IDateTimeHelper> _dateTimeHelperMock;

        [TestCaseSource(nameof(AddHoursToCurrentTimeTestData))]
        public void Test_AddHoursToCurrentTime_Returns_Correct_Value(AddHoursToCurrentTimeTestData testCaseData)
        {
            // Arrange
            _dateTimeHelperMock = new Mock<IDateTimeHelper>();
            _dateTimeHelperMock.Setup(_ => _.UtcNow()).Returns(testCaseData.CurrentUtcDateTime);

            _hoursCalculator = new HoursCalculatorGood(_dateTimeHelperMock.Object);

            // Act
            var actualResult = _hoursCalculator.AddHoursToCurrentTime(testCaseData.Hours).ToLocalTime();

            // Assert
            Assert.AreEqual(testCaseData.ExpectedLocalDateTime, actualResult, "AddHoursToCurrentTime() calculation is incorrect");
        }

        public static IEnumerable<AddHoursToCurrentTimeTestData> AddHoursToCurrentTimeTestData()
        {
            // Greenwich Mean Time
            yield return new AddHoursToCurrentTimeTestData() { CurrentUtcDateTime = new DateTime(2020, 03, 20, 23, 30, 10), ExpectedLocalDateTime = new DateTime(2020, 03, 21, 04, 30, 10), Hours = 5 };
            yield return new AddHoursToCurrentTimeTestData() { CurrentUtcDateTime = new DateTime(2020, 03, 20, 23, 30, 10), ExpectedLocalDateTime = new DateTime(2020, 03, 20, 23, 30, 10), Hours = 0 };

            // Daylight Saving
            yield return new AddHoursToCurrentTimeTestData() { CurrentUtcDateTime = new DateTime(2020, 03, 29, 23, 30, 10), ExpectedLocalDateTime = new DateTime(2020, 03, 30, 05, 30, 10), Hours = 5 };

            // British Summer Time
            yield return new AddHoursToCurrentTimeTestData() { CurrentUtcDateTime = new DateTime(2020, 04, 29, 23, 30, 10), ExpectedLocalDateTime = new DateTime(2020, 04, 30, 05, 30, 10), Hours = 5 };
            yield return new AddHoursToCurrentTimeTestData() { CurrentUtcDateTime = new DateTime(2020, 04, 29, 23, 30, 10), ExpectedLocalDateTime = new DateTime(2020, 04, 30, 00, 30, 10), Hours = 0 };

            // Leap Year
            yield return new AddHoursToCurrentTimeTestData() { CurrentUtcDateTime = new DateTime(2020, 02, 28, 23, 30, 10), ExpectedLocalDateTime = new DateTime(2020, 02, 29, 04, 30, 10), Hours = 5 };

            // Not Leap Year
            yield return new AddHoursToCurrentTimeTestData() { CurrentUtcDateTime = new DateTime(2021, 02, 28, 23, 30, 10), ExpectedLocalDateTime = new DateTime(2021, 03, 01, 04, 30, 10), Hours = 5 };
        }
    }
}
