using System;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Service.Domain
{
    public class CoBuilderUser : ICoBuilderUser
    {
        public CoBuilderUser(ISession session)
        {
            AdminName = session.UserInfo.AdminName;
            CanWrite = session.UserInfo.CanWrite;
            CompanyName = session.UserInfo.CompanyName;
            ContactId = session.ContactId;
            Username = session.UserId;
        }

        public string AdminName { get; }

        public bool CanWrite { get; }

        public string CompanyName { get; }

        public Guid ContactId { get; }

        public string Username { get; }
    }
}