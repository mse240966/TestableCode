using System;
using TestableCode.Example;
using TestableCode.Ninject;

namespace TestableCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ninjectContainer = new NinjectContainer();
            ninjectContainer.Initialise();

            IHoursCalculator hoursCalculator = ninjectContainer.GetHoursCalculator();

            Console.WriteLine(hoursCalculator.AddHoursToCurrentLocalTime(1));
            Console.ReadLine();
        }
    }
}
