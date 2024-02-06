using Microsoft.ServiceHub.Framework;

namespace CalculatorProject
{
    internal class Calculator : ICalculator
    {
        private readonly State state;
        public static readonly ServiceMoniker Moniker = new("Mohaimen.CoolExtension.Calculator", new Version("1.0"));


        internal Calculator(State state)
        {
            this.state = state;
        }

        public event EventHandler<int> NewTotal
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
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