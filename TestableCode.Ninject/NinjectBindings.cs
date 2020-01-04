using Ninject.Modules;
using TestableCode.Common;
using TestableCode.Example;

namespace TestableCode.Ninject
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IHoursCalculator>().To<HoursCalculatorGood>();
            Bind<IDateTimeHelper>().To<DateTimeHelper>();
        }
    }
}
