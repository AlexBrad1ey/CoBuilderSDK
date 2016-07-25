using System;

namespace CoBuilder.Core.Domain
{
    public class CoBuilderUser
    {
        public string AccessToken { get; set; }

        public string AdminName { get; set; }

        public bool CanWrite { get; set; }

        public string CompanyName { get; set; }

        public Guid ContactId { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }
    }
}