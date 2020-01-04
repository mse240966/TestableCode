using Ninject;
using System.Reflection;
using TestableCode.Example;

namespace TestableCode.Ninject
{
    public class NinjectContainer
    {
        private readonly StandardKernel _kernel = new StandardKernel();

        public void Initialise()
        {
            _kernel.Load(Assembly.GetExecutingAssembly());
        }

        public IHoursCalculator GetHoursCalculator()
        {
            return _kernel.Get<IHoursCalculator>();
        }
    }
}
