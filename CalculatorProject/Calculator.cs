using Microsoft.ServiceHub.Framework;

namespace CalculatorProject
{
    internal class Calculator : ICalculator
    {
        private readonly State state;
        public static readonly ServiceMoniker Moniker = new("CalculatorProject");


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        internal Calculator(State state)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.state = state;
        }

        public event EventHandler<int> NewTotal;

        public void Dispose()
        {
        }

        public ValueTask<double> AddAsync(double a, double b, CancellationToken cancellationToken)
        {
            this.state.IncrementCounter();
            return new ValueTask<double>(a + b);
        }

        public ValueTask<double> SubtractAsync(double a, double b, CancellationToken cancellationToken)
        {
            this.state.IncrementCounter();
            return new ValueTask<double>(a - b);
        }

        internal class State
        {
            private int operationCounter;

            internal int OperationCounter => this.operationCounter;

            internal void IncrementCounter() => Interlocked.Increment(ref this.operationCounter);
        }
    }
}