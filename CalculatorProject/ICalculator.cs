namespace CalculatorProject
{
    public interface ICalculator
    {
        ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken);
        ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken);
    }
}
