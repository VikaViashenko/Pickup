using Pickup.Domain.Response;
using Pickup.Domain.ViewModels.Account;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Pickup.Service.Interfaces
{
    public interface IAccountService
    {
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);
    }
}
