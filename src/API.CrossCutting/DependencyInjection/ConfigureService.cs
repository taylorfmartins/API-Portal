using API.Domain.Interfaces.Services.User;
using API.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace API.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
        }
    }
}
