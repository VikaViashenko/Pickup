using Microsoft.EntityFrameworkCore;
using Pickup.DAL.Interfaces;
using Pickup.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.DAL.Repositories
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly ApplicationDbContext _db;
        
        public PhoneRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(Phone entity)
        {
            await _db.Phone.AddAsync(entity);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(Phone entity)
        {
            _db.Phone.Remove(entity);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<Phone> Get(int id)
        {
            return await _db.Phone.FirstOrDefaultAsync(x => x.id == id); //пошук по id з БД
        }

        public async Task<Phone> GetByName(string name)
        {
            return await _db.Phone.FirstOrDefaultAsync(x => x.Name == name); //пошук по Name з БД
        }

        public async Task<List<Phone>> Select()
        {
            return await _db.Phone.ToListAsync();
        }
    }
}
