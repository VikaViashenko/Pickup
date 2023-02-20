using Microsoft.Extensions.DependencyInjection;
using Pickup.DAL.Interfaces;
using Pickup.DAL.Repositories;
using Pickup.Domain.Entity;
using Pickup.Service.Implementations;
using Pickup.Service.Interfaces;

namespace Pickup
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Phone>, PhoneRepository>();
            services.AddScoped<IBaseRepository<User>, UserRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<IPhoneService, PhoneService>();
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}
