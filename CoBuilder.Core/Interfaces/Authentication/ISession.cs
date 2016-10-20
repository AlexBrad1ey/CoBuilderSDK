using System;
using System.Threading.Tasks;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Enums;
using CoBuilder.Core.RestModels;

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
        string Pass { get; set; }
        void Clear();
        void Update (LoginResult result, string username,string pass, bool canSignOut);
        void Update(ISession session);
    }
}