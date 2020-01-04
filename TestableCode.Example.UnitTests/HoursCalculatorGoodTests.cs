using System;
using System.Collections.Generic;
using TestableCode.Common;
using NUnit.Framework;
using Moq;

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

        public IEnumerable<AddHoursToCurrentTimeTestData> AddHoursToCurrentTimeTestData()
        {
            yield return new AddHoursToCurrentTimeTestData() { CurrentUtcDateTime = new DateTime(2020, 01, 02, 08, 30, 10), ExpectedLocalDateTime = new DateTime(2020, 01, 02, 10, 30, 10), Hours = 2 };
        }
    }
}
