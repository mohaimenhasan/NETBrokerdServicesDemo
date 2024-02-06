using Microsoft.ServiceHub.Framework;
using Nerdbank.Streams;

namespace CalculatorProject
{
    public static class Descriptors
    {
        public static readonly ServiceRpcDescriptor CalculatorService = new ServiceJsonRpcDescriptor(
            Calculator.Moniker,
            clientInterface: null,
            ServiceJsonRpcDescriptor.Formatters.MessagePack,
            ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader,
            new MultiplexingStream.Options { ProtocolMajorVersion = 3 })
            .WithExceptionStrategy(StreamJsonRpc.ExceptionProcessing.ISerializable);
    }
}
