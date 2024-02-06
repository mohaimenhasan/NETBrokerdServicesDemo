namespace CalculatorProject
{
    internal class Calculator : ICalculator
    {
        public ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken)
        {
            return new ValueTask<double>(a + b);
        }

        public ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken)
        {
            return new ValueTask<double>(a - b);
        }
    }
}