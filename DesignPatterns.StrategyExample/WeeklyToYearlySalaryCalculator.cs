namespace DesignPatterns.StrategyExample
{
    public class WeeklyToYearlySalaryCalculator : ISalaryCalculator
    {
        public double Calculate(double amount)
        {
            return amount * 52;
        }
    }
}
