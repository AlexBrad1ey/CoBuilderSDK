using System;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;

namespace CoBuilder.Core.Authentication
{
    internal class Session : ISession
    {

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
    }
}