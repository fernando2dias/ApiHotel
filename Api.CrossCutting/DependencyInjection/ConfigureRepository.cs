using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Data.Implementations;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, IConfiguration configuration )
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            serviceCollection.AddScoped<ICustomerRepository, CustomerImplementation>();
            serviceCollection.AddScoped<IDependentPersonRepository, DependentPersonImplementation>();
            serviceCollection.AddScoped<IHotelRepository, HotelImplementation>();
            serviceCollection.AddScoped<IRoomRepository, RoomImplementation>();
            serviceCollection.AddScoped<IReviewRepository, ReviewImplementation>();
            serviceCollection.AddScoped<IReservationRepository, ReservationImplementation>();


            serviceCollection.AddDbContext<MyContext>(
                    options => options.UseSqlite(configuration.GetConnectionString("Default"))
                );
            

        }
    }
}