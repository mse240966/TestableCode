using System;
using TestableCode.Example;

namespace TestableCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHoursCalculator hoursCalculator = new HoursCalculatorBad();

            Console.WriteLine(hoursCalculator.AddHoursToCurrentLocalTime(1));
            Console.ReadLine();
        }
    }
}
