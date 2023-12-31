using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Domain.Interfaces.Services.Customer;
using Domain.Interfaces.Services.Hotel;
using Domain.Interfaces.Services.Reservation;
using Domain.Interfaces.Services.Review;
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
            serviceCollection.AddTransient<IDependentPersonService, DependentPersonService>();
            serviceCollection.AddTransient<IHotelService, HotelService>();
            serviceCollection.AddTransient<IRoomService, RoomService>();
            serviceCollection.AddTransient<IReviewService, ReviewService>();
            serviceCollection.AddTransient<IReservationService, ReservationService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}