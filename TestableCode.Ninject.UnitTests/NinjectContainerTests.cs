using NUnit.Framework;

namespace TestableCode.Ninject.UnitTests
{
    public class NinjectContainerTests
    {
        public NinjectContainer _ninjectContainer;

        [SetUp]
        public void TestSetUp()
        {
            _ninjectContainer = new NinjectContainer();
            _ninjectContainer.Initialise();
        }

        [Test]
        public void Test_Container_Knows_Of_HoursCalculatorGood()
        {
            Assert.AreEqual("TestableCode.Example.HoursCalculatorGood", _ninjectContainer.GetHoursCalculator().GetType().FullName);
        }
    }
}
