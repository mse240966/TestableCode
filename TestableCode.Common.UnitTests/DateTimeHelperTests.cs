using NUnit.Framework;
using System;

namespace TestableCode.Common.UnitTests
{
    [TestFixture]
    public class DateTimeHelperTests
    {
        public IDateTimeHelper _dateTimeHelper;

        [SetUp]
        public void TestSetUp()
        {
            _dateTimeHelper = new DateTimeHelper();
        }

        [Test]
        public void Test_DateTime_Now_Returns_Local()
        {
            Assert.AreEqual(DateTimeKind.Local, _dateTimeHelper.Now().Kind);
        }

        [Test]
        public void Test_DateTime_UtcNow_Returns_Utc()
        {
            Assert.AreEqual(DateTimeKind.Utc, _dateTimeHelper.UtcNow().Kind);
        }
    }
}
