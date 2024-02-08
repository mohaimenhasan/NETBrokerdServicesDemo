using Microsoft.ServiceHub.Framework;
using Microsoft.ServiceHub.Framework.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CalculatorProject.Calculator;

namespace CalculatorProject
{
    public class CalculatorFactory : IMultiVersionedServiceFactory
    {
        private State testState = new();
        public Task<object> CreateAsync(IServiceProvider hostProvidedServices, ServiceMoniker serviceMoniker, ServiceActivationOptions serviceActivationOptions, IServiceBroker serviceBroker, AuthorizationServiceClient authorizationServiceClient, CancellationToken cancellationToken)
        {
            Debugger.Launch();
            return Task.FromResult<Object>(new Calculator(this.testState));
        }

        public ServiceRpcDescriptor GetServiceDescriptor(ServiceMoniker serviceMoniker)
        {
            Debugger.Launch();
            return Descriptors.CalculatorService;
        }
    }
}
