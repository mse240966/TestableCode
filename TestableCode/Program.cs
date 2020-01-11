using System;
using TestableCode.Example;
using TestableCode.Ninject;

namespace TestableCode
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");

            var ninjectContainer = new NinjectContainer();
            ninjectContainer.Initialise();

            IHoursCalculator hoursCalculator = ninjectContainer.GetHoursCalculator();

            Console.WriteLine(hoursCalculator.AddHoursToCurrentTime(0).ToLocalTime());
            Console.ReadLine();
        }
    }
}
