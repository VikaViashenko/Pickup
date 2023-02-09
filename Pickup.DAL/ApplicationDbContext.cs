using Microsoft.EntityFrameworkCore;
using Pickup.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pickup.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureCreated(); - створює базу даних і пусту таблицю Phone
        }

        public DbSet<Phone> Phone { get; set; } //створення сутності (сюди будуть підставлятись дані отримані з нашої таблиці базиданих)
    }
}
