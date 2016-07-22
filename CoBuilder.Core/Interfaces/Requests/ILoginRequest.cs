using System.Threading.Tasks;
using CoBuilder.Core.RestModels;

namespace CoBuilder.Core.Interfaces
{
    public interface ILoginRequest
    {
        string Password { get; }
        string Username { get; }


        Task<LoginResult> GetAsync();
    }
}