using Microsoft.EntityFrameworkCore;
using Pickup.Domain.Entity;
using Pickup.Domain.Enum;
using Pickup.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(builder =>
            {
                builder.HasData(new User
                {
                    id = 1,
                    Name = "VikaLiashenko",
                    Password = HashPasswordHelper.HashPassword("1111"),
                    Role = Role.Admin
                });

                builder.ToTable("Users").HasKey(x => x.id);

                builder.Property(x => x.id)
                    .ValueGeneratedOnAdd();

                builder.Property(x => x.Name).HasMaxLength(100).IsRequired();// 
            });
        }
    }
}
