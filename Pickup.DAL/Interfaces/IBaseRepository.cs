using Pickup.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        //bool Create(T entity);
        Task<bool> Create(T entity);

        //T Get(int id);
        Task<T> Get(int id);

        //IEnumerable<T> Select();
        Task<List<T>> Select();

        //bool Delete(T entity);
        Task<bool> Delete(T entity);
    }
}
