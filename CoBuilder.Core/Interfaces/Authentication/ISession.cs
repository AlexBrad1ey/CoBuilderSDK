using System;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Interfaces
{
    public interface ISession
    {
        string UserId { get; set; }
        string AccessToken { get; set; }
        bool CanSignOut { get; set; }
        PluginApp AppId { get; set; }
        Guid ContactId { get; set; }
        UserInfo UserInfo { get; set; }
    }
}