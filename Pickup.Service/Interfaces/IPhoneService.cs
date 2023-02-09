using Pickup.Domain.Entity;
using Pickup.Domain.Response;
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
    }
}
