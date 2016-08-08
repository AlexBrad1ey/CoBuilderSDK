using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Interfaces
{
    public interface IAppConfig
    {
        PluginApp AppId { get; set; }
        string ClientId { get; set; }
        string ProgramVersion { get; set; }
    }
}