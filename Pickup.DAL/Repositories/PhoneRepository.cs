using Microsoft.EntityFrameworkCore;
using Pickup.DAL.Interfaces;
using Pickup.Domain.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pickup.DAL.Repositories
{
    public class PhoneRepository : IBaseRepository<Phone>
    {
        private readonly ApplicationDbContext _db;
        
        public PhoneRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task Create(Phone entity)
        {
            await _db.Phone.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Delete(Phone entity)
        {
            _db.Phone.Remove(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Phone> GetAll()
        {
            return _db.Phone;
        }

        public async Task<Phone> Update(Phone entity)
        {
            _db.Phone.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
