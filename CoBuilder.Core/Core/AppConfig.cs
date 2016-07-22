using CoBuilder.Core.Enums;

namespace CoBuilder.Core
{
    public class AppConfig : IAppConfig
    {
        public PluginApp AppId { get; set; }
        public string ProgramVersion { get; set; }
        public string ClientId { get; set; }
    }
}