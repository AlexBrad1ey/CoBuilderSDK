using CoBuilder.Core;
using System;
using CoBuilder.Core.Enums;

namespace CoBuilder.Navisworks
{
    public class NavisworksAppConfig : AppConfig
    {
        public NavisworksAppConfig()
        {
            AppId = PluginApp.PXCNavisworks;
            ClientId = Guid.NewGuid().ToString();
            ProgramVersion = "2017";
        }
    }
}
