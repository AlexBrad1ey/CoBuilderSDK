using CoBuilder.Core.Domain;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.RestModels
{
    public class PluginWriteBackResult
    {
        public AuthenticationRequestStatus Status { get; set; }
        public int ErrorCode { get; set; }
        public PluginUsageLog Log { get; set; }
    }
}