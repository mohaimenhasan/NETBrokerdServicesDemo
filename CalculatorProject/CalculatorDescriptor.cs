using Microsoft.ServiceHub.Framework;
using Nerdbank.Streams;

namespace CalculatorProject
{
    public static class CalculatorDescriptor
    {
        public static readonly ServiceRpcDescriptor CalculatorService = new ServiceJsonRpcDescriptor(
            new ServiceMoniker("MohaimenCoolCompany.CoolMath.Calculator", new Version(1, 0)),
            clientInterface: null,
            ServiceJsonRpcDescriptor.Formatters.MessagePack,
            ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader,
            new MultiplexingStream.Options { ProtocolMajorVersion = 3 })
            .WithExceptionStrategy(StreamJsonRpc.ExceptionProcessing.ISerializable);
    }
}
