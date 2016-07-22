namespace CoBuilder.Core.Enums
{
    public enum AuthenticationRequestStatus
    {
        Ok = 0,
        AuthenticationFailed = 1,
        TokenExpired = 2,
        TokenNotProvided = 3,
        ServerFailed = 4,
        NoSuchToken = 5,
        ContactIdMissingOrWrong = 6,
        Error = 7
    }
}