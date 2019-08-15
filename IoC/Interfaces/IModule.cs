using Microsoft.Extensions.DependencyInjection;

namespace IoC.Interfaces
{
    public interface IModule
    {
        void ConfigureServices(IServiceCollection services);
    }
}
