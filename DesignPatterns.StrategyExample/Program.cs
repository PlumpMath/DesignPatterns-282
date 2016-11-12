using System;

namespace DesignPatterns.StrategyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new SalaryCalculatorClient();

            client.SetCalculator(new HourlyToYearlySalaryCalculator());
            var fromHourly = client.Calculate(20.53);

            Console.WriteLine(fromHourly);

            client.SetCalculator(new WeeklyToYearlySalaryCalculator());
            var fromWeekly = client.Calculate(1053.42);

            Console.WriteLine(fromWeekly);

            Console.ReadLine();
        }
    }
}
