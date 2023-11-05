using Api.Data.Mapping;
using Api.Domain.Entities;
using Data.Mapping;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<DependentPersonEntity> DependentPersons { get; set; }
        public DbSet<HotelEntity> Hotels { get; set; }


        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<CustomerEntity>(new CustomerMap().Configure);
            modelBuilder.Entity<HotelEntity>(new HotelMap().Configure);


            modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Administrador",
                    Email = "fer@admin.com.br",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                }
            );




            modelBuilder.Entity<CustomerEntity>().HasData(
                new CustomerEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Fernando",
                    LastName = "Dias Motta",
                    Email = "fernando3dias@gmail.com",
                    BirthDate = DateTime.ParseExact("21/09/1986", "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                    CPF="111.222.333-44",
                    Password="123mudar",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                }
            );


            modelBuilder.Entity<HotelEntity>().HasData(
                new HotelEntity
                {
                    Id = Guid.NewGuid(),
                    Name = "Facens Hotel",
                    Address = "Rodovia Senador José Ermírio de Moraes, 1425",
                    ZipCode = "18085-784",
                    State = "SP",
                    City = "Sorocaba",
                    AvgTicket = 150,
                    Rooms = null,
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                }
            );

        }


    }
}