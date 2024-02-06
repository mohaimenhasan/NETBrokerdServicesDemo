namespace CalculatorProject
{
    public interface ICalculator
    {
        event EventHandler<int> NewTotal;

        ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken);

        ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken);
    }
}
