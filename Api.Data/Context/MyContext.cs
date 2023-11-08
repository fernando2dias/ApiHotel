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
        public DbSet<ReviewEntity> Reviews { get; set; }
        public DbSet<ReservationEntity> Reservations { get; set; }


        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<CustomerEntity>(new CustomerMap().Configure);
            modelBuilder.Entity<DependentPersonEntity>(new DependentPersonMap().Configure);
            modelBuilder.Entity<HotelEntity>(new HotelMap().Configure);
            modelBuilder.Entity<RoomEntity>(new RoomMap().Configure);
            modelBuilder.Entity<ReviewEntity>(new ReviewMap().Configure);
            modelBuilder.Entity<ReservationEntity>(new ReservationMap().Configure);

            Guid _hotelId1 = Guid.NewGuid();
            Guid _hotelId2 = Guid.NewGuid();
            Guid _hotelId3 = Guid.NewGuid();
            Guid _hotelId4 = Guid.NewGuid();
            Guid _hotelId5 = Guid.NewGuid();

            Guid[] _hotelsId = { _hotelId1, _hotelId2, _hotelId3, _hotelId4, _hotelId5 };
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
                    CPF = "111.222.333-44",
                    Password = "123mudar",
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                }
            );


            modelBuilder.Entity<HotelEntity>().HasData(
                new HotelEntity
                {
                    Id = _hotelId1,
                    Name = "Facens Hotel",
                    Address = "Rodovia Senador José Ermírio de Moraes, 1425",
                    ZipCode = "18085-784",
                    State = "SP",
                    City = "Sorocaba",
                    AvgTicket = 150,
                    Rooms = null,
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                },
                new HotelEntity
                {
                    Id = _hotelId2,
                    Name = "Luxury Palace Hotel",
                    Address = "Avenida das Estrelas, 123",
                    ZipCode = "12345-678",
                    State = "SP",
                    City = "Sorocaba",
                    AvgTicket = 250,
                    Rooms = null,
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                },
             new HotelEntity
             {
                 Id = _hotelId3,
                 Name = "Cozy Inn",
                 Address = "Rua das Flores, 456",
                 ZipCode = "54321-987",
                 State = "SP",
                 City = "Sorocaba",
                 AvgTicket = 120,
                 Rooms = null,
                 CreateAt = DateTime.Now,
                 UpdateAt = DateTime.Now
             },
             new HotelEntity
             {
                 Id = _hotelId4,
                 Name = "Harbor View Hotel",
                 Address = "Avenida Beira-Mar, 789",
                 ZipCode = "98765-432",
                 State = "SP",
                 City = "Sorocaba",
                 AvgTicket = 180,
                 Rooms = null,
                 CreateAt = DateTime.Now,
                 UpdateAt = DateTime.Now
             },
             new HotelEntity
             {
                 Id = _hotelId5,
                 Name = "Golden Sands Resort",
                 Address = "Praia da Areia Dourada, S/N",
                 ZipCode = "34567-890",
                 State = "SP",
                 City = "Sorocaba",
                 AvgTicket = 300,
                 Rooms = null,
                 CreateAt = DateTime.Now,
                 UpdateAt = DateTime.Now
             },
             new HotelEntity
             {
                 Id = Guid.NewGuid(),
                 Name = "Riverside Lodge",
                 Address = "Margem do Rio, 987",
                 ZipCode = "76543-210",
                 State = "SP",
                 City = "Sorocaba",
                 AvgTicket = 160,
                 Rooms = null,
                 CreateAt = DateTime.Now,
                 UpdateAt = DateTime.Now
             },
             new HotelEntity
             {
                 Id = Guid.NewGuid(),
                 Name = "The Grand Plaza Hotel",
                 Address = "Praça Principal, 654",
                 ZipCode = "23456-789",
                 State = "SP",
                 City = "Sorocaba",
                 AvgTicket = 280,
                 Rooms = null,
                 CreateAt = DateTime.Now,
                 UpdateAt = DateTime.Now
             },
             new HotelEntity
             {
                 Id = Guid.NewGuid(),
                 Name = "Sunset View Inn",
                 Address = "Avenida do Pôr do Sol, 321",
                 ZipCode = "87654-321",
                 State = "SP",
                 City = "Sorocaba",
                 AvgTicket = 140,
                 Rooms = null,
                 CreateAt = DateTime.Now,
                 UpdateAt = DateTime.Now
             },
             new HotelEntity
             {
                 Id = Guid.NewGuid(),
                 Name = "Majestic Heights Hotel",
                 Address = "Rua das Montanhas, 567",
                 ZipCode = "54321-234",
                 State = "SP",
                 City = "Sorocaba",
                 AvgTicket = 200,
                 Rooms = null,
                 CreateAt = DateTime.Now,
                 UpdateAt = DateTime.Now
             },
             new HotelEntity
             {
                 Id = Guid.NewGuid(),
                 Name = "Sorocaba Suites",
                 Address = "Avenida Central, 876",
                 ZipCode = "12345-543",
                 State = "SP",
                 City = "Sorocaba",
                 AvgTicket = 130,
                 Rooms = null,
                 CreateAt = DateTime.Now,
                 UpdateAt = DateTime.Now
             },
             new HotelEntity
             {
                 Id = Guid.NewGuid(),
                 Name = "Mountain View Lodge",
                 Address = "Trilha da Montanha, 765",
                 ZipCode = "65432-123",
                 State = "SP",
                 City = "Sorocaba",
                 AvgTicket = 190,
                 Rooms = null,
                 CreateAt = DateTime.Now,
                 UpdateAt = DateTime.Now
             }
            );


            Random random = new Random();
            modelBuilder.Entity<RoomEntity>().HasData(
                new RoomEntity
                {
                    Id = Guid.NewGuid(),
                    Number = random.Next(1,100),  // Número do quarto
                    TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                    NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                    PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                    Status = Status.Available,  // Status fixo como Available
                    HotelId = _hotelsId[random.Next(0,4)]  // HotelId aleatório a partir do array
                },
                 new RoomEntity
                 {
                     Id = Guid.NewGuid(),
                     Number = random.Next(1, 100),  // Número do quarto
                     TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                     NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                     PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                     Status = Status.Available,  // Status fixo como Available
                     HotelId = _hotelsId[random.Next(0, 4)]  // HotelId aleatório a partir do array
                 },
                  new RoomEntity
                  {
                      Id = Guid.NewGuid(),
                      Number = random.Next(1, 100),  // Número do quarto
                      TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                      NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                      PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                      Status = Status.Available,  // Status fixo como Available
                      HotelId = _hotelsId[random.Next(0, 4)]  // HotelId aleatório a partir do array
                  },
                   new RoomEntity
                   {
                       Id = Guid.NewGuid(),
                       Number = random.Next(1, 100),  // Número do quarto
                       TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                       NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                       PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                       Status = Status.Available,  // Status fixo como Available
                       HotelId = _hotelsId[random.Next(0, 4)]  // HotelId aleatório a partir do array
                   },
                    new RoomEntity
                    {
                        Id = Guid.NewGuid(),
                        Number = random.Next(1, 100),  // Número do quarto
                        TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                        NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                        PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                        Status = Status.Available,  // Status fixo como Available
                        HotelId = _hotelsId[random.Next(0, 4)]  // HotelId aleatório a partir do array
                    },
                     new RoomEntity
                     {
                         Id = Guid.NewGuid(),
                         Number = random.Next(1, 100),  // Número do quarto
                         TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                         NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                         PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                         Status = Status.Available,  // Status fixo como Available
                         HotelId = _hotelsId[random.Next(0, 4)]  // HotelId aleatório a partir do array
                     },
                      new RoomEntity
                      {
                          Id = Guid.NewGuid(),
                          Number = random.Next(1, 100),  // Número do quarto
                          TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                          NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                          PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                          Status = Status.Available,  // Status fixo como Available
                          HotelId = _hotelsId[random.Next(0, 4)]  // HotelId aleatório a partir do array
                      },
                       new RoomEntity
                       {
                           Id = Guid.NewGuid(),
                           Number = random.Next(1, 100),  // Número do quarto
                           TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                           NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                           PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                           Status = Status.Available,  // Status fixo como Available
                           HotelId = _hotelsId[random.Next(0, 4)]  // HotelId aleatório a partir do array
                       },
                        new RoomEntity
                        {
                            Id = Guid.NewGuid(),
                            Number = random.Next(1, 100),  // Número do quarto
                            TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                            NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                            PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                            Status = Status.Available,  // Status fixo como Available
                            HotelId = _hotelsId[random.Next(0, 4)]  // HotelId aleatório a partir do array
                        },
                         new RoomEntity
                         {
                             Id = Guid.NewGuid(),
                             Number = random.Next(1, 100),  // Número do quarto
                             TypeRoom = (TypeRoom)random.Next(1, 12),  // Tipo de quarto aleatório
                             NumberBeds = random.Next(1, 5),  // Número de camas entre 1 e 4
                             PricePerNight = random.Next(80, 200),  // Preço por noite aleatório
                             Status = Status.Available,  // Status fixo como Available
                             HotelId = _hotelsId[random.Next(0, 4)]  // HotelId aleatório a partir do array
                         }
            );

            




        }


    }
}