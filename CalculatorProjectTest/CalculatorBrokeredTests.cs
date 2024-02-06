using CalculatorProject;
using Microsoft.ServiceHub.Framework;
using Microsoft.VisualStudio.Sdk.TestFramework;
using Xunit.Abstractions;

namespace CalculatorProjectTest
{
    public class CalculatorBrokeredTests : BrokeredServiceContractTestBase<ICalculator, MockCalculator>
    {
        public CalculatorBrokeredTests(ITestOutputHelper logger, ServiceRpcDescriptor serviceRpcDescriptor) : base(logger, serviceRpcDescriptor)
        {
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