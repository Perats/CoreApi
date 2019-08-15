using Infrastructure.Interface.Interfaces;
using Infrastructure.Interface.Models;
using Infrastructure.Service.Contexts;
using Infrastructure.Service.Services;
using IoC.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace IoC.Modules
{
    public class InfrastructureModule : IModule
    {
        public void ConfigureServices(IServiceCollection services)
        {

            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = Test; Trusted_Connection = True");

            using (var context = new MyContext(optionsBuilder.Options)) context.Database.EnsureCreated();

            services.AddTransient<MyContext>(_ => new MyContext(optionsBuilder.Options));
            services.AddTransient<IUserRepository, UserServiceRepository>();

        }
    }
}
