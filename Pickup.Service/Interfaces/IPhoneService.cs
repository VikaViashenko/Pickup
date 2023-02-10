using Pickup.Domain.Entity;
using Pickup.Domain.Response;
using Pickup.Domain.ViewModels.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.Service.Interfaces
{
    public interface IPhoneService
    {
        Task<IBaseResponse<IEnumerable<Phone>>> GetPhones();

        Task<IBaseResponse<Phone>> GetPhone(int id);

        Task<IBaseResponse<PhoneViewModel>> CreatePhone(PhoneViewModel phoneViewModel);

        Task<IBaseResponse<bool>> DeletePhone(int id);

        Task<IBaseResponse<Phone>> GetPhoneByName(string name);

        Task<IBaseResponse<Phone>> Edit(int id, PhoneViewModel model);
    }
}
