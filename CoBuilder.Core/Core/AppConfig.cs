using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core
{
    public class AppConfig : IAppConfig
    {
        public PluginApp AppId { get; set; }
        public string ProgramVersion { get; set; }
        public string ClientId { get; set; }
    }
}