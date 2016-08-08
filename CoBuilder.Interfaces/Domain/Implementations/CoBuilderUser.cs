using System;

namespace CoBuilder.Service.Domain
{
    public class CoBuilderUser : ICoBuilderUser
    {
        public string AdminName { get; }

        public bool CanWrite { get; }

        public string CompanyName { get; }

        public Guid ContactId { get; }

        public string Username { get; }
    }
}