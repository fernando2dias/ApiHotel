using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Domain.Interfaces.Services.Customer;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ICustomerService, CustomerService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}