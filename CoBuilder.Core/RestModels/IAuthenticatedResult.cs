using CoBuilder.Core.Enums;

namespace CoBuilder.Core.RestModels
{
    public interface IAuthenticatedResult
    {
        AuthenticationRequestStatus Status { get; set; }
    }
}