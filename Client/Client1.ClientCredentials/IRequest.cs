using System.Threading.Tasks;

namespace Client1.ClientCredentials
{
    public interface IRequest
    {
        Task GetTokenRequestApiAsync();
    }
}