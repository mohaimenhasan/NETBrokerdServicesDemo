using System;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public interface ICalculator : IDisposable
    {
        event EventHandler<int> NewTotal;

        ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken);

        ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken);
    }
}
