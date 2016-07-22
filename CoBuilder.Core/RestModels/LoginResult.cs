using System;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.RestModels
{
    public class LoginResult
    {
        public string TokenData { get; set; }
        public Guid ContactId { get; set; }
        public bool CanWrite { get; set; }
        public bool MissingProappAuthorization { get; set; }
        public string AdminName { get; set; }
        public string CompanyName { get; set; }

        /// <exclude />
        public AuthenticationRequestStatus Status { get; set; }
    }
}