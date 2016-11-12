namespace DesignPatterns.StrategyExample
{
    public class HourlyToYearlySalaryCalculator : ISalaryCalculator
    {
        public double Calculate(double amount)
        {
            return amount * 8 * 5 * 52;
        }
    }
}
