using Microsoft.ServiceHub.Framework;
using Nerdbank.Streams;
using System;

namespace CalculatorBrokeredClient
{
    public static class Descriptors
    {
        public static readonly ServiceMoniker Moniker = new ServiceMoniker("CalculatorProject");

        public static readonly ServiceRpcDescriptor CalculatorService = new ServiceJsonRpcDescriptor(
            Moniker,
            clientInterface: null,
            ServiceJsonRpcDescriptor.Formatters.MessagePack,
            ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader,
            new MultiplexingStream.Options { ProtocolMajorVersion = 3 })
            .WithExceptionStrategy(StreamJsonRpc.ExceptionProcessing.ISerializable);
    }
}
