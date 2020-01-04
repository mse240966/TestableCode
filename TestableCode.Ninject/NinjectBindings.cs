using Ninject.Modules;
using TestableCode.Example;
using TestableCode.Common;

namespace TestableCode.Ninject
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IHoursCalculator>().To<HoursCalculatorBad>();
            Bind<IDateTimeHelper>().To<DateTimeHelper>();
        }
    }
}
