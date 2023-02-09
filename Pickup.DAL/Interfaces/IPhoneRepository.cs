using Pickup.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.DAL.Interfaces
{
    public interface IPhoneRepository : IBaseRepository<Phone>
    {
        //Phone GetByName(string name);
        Task<Phone> GetByName(string name);
    }
}
