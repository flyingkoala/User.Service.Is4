using System.Threading.Tasks;

namespace Client1.ResourceOwnerPassword
{
    public interface IRequest
    {
        Task GetTokenRequestApiAsync();
    }
}