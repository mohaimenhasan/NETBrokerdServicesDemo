using CalculatorProject;
using Microsoft.ServiceHub.Framework;
using Microsoft.VisualStudio.Sdk.TestFramework;
using Xunit.Abstractions;

namespace CalculatorProjectTest
{
    public class CalculatorBrokeredTests : BrokeredServiceContractTestBase<ICalculator, MockCalculator>
    {
        public CalculatorBrokeredTests(ITestOutputHelper logger) : base(logger, Descriptors.CalculatorService)
        {
        }

        [Fact]
        public async Task TestNewTotalAsync()
        {
            await this.AssertEventRaisedAsync<int>(
                addHandler: (p, h) => p.NewTotal += h, 
                removeHandler: (p, h) => p.NewTotal -= h,
                triggerEvent: s => s.RaiseNewTotal(50),
                argsAssertions: a => Assert.Equal(50, a));
        }

        [Fact]
        public async Task TestAddOperationAsync()
        {
            Assert.Equal(4.0, await this.ClientProxy.AddAsync(1.5, 2.5, CancellationToken.None));
        }

        [Fact]
        public async Task TestSubtractOperationAsync()
        {
            Assert.Equal(-1.0, await this.ClientProxy.SubtractAsync(1.5, 2.5, CancellationToken.None));
        }
    }
}