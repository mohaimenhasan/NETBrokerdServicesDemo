using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProjectTest
{
    public class MockCalculator : ICalculator
    {
        public event EventHandler<int>? NewTotal;

        internal void RaiseNewTotal(int arg) => this.NewTotal?.Invoke(this, arg);


        public ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken)
        {
            return ValueTask.FromResult(a + b);
        }

        public ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken)
        {
            return ValueTask.FromResult(a - b);
        }
    }
}
