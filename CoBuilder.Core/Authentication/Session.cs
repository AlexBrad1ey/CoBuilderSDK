using System;
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;

namespace CoBuilder.Core.Authentication
{

    public class Session : ISession
    {
        public Session() { }

        public Session(LoginResult loginResult, string username)
        {
            UserId = username;
            AccessToken = loginResult.TokenData;
            ContactId = loginResult.ContactId;
            UserInfo = new UserInfo
            {
                AdminName = loginResult.AdminName,
                CanWrite = loginResult.CanWrite,
                CompanyName = loginResult.CompanyName
            };
        }

        public string UserId { get; set; }
        public string AccessToken { get; set; }
        public bool CanSignOut { get; set; }
        public PluginApp AppId { get; set; }
        public Guid ContactId { get; set; }
        public UserInfo UserInfo { get; set; }

        public virtual void Clear()
        {
            UserId = null;
            AccessToken = null;
            CanSignOut = false;
            AppId = PluginApp.Unknown;
            ContactId = Guid.Empty;
            UserInfo = null;
        }

        public void Update(LoginResult result, string username, bool canSignOut)
        {
            UserId = username;
            AccessToken = result.TokenData;
            ContactId = result.ContactId;
            UserInfo = new UserInfo
            {
                AdminName = result.AdminName,
                CanWrite = result.CanWrite,
                CompanyName = result.CompanyName
            };

            CanSignOut = canSignOut;
        }

        public void Update(ISession session)
        {
            UserId = session.UserId;
            AccessToken = session.AccessToken;
            CanSignOut = session.CanSignOut;
            AppId = session.AppId;
            ContactId = session.ContactId;
            UserInfo = session.UserInfo;
        }
    }
}