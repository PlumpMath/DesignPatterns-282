namespace DesignPatterns.StrategyExample
{
    public class SalaryCalculatorClient
    {
        ISalaryCalculator _calculator;

        public double Calculate(double amount)
        {
            return _calculator.Calculate(amount);
        }

        public void SetCalculator(ISalaryCalculator calculator)
        {
            _calculator = calculator;
        }
    }
}
