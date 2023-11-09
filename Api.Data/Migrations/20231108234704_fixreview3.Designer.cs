﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20231108234704_fixreview3")]
    partial class fixreview3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("Api.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("762f0d15-b883-4577-a543-6191d5893e91"),
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(239),
                            Email = "fer@admin.com.br",
                            Name = "Administrador",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(249)
                        });
                });

            modelBuilder.Entity("Domain.Entities.CustomerEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Passport")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("RG")
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Customer", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d3b57e8-55ae-405c-b0de-2f30e1288b06"),
                            BirthDate = new DateTime(1986, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "111.222.333-44",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(406),
                            Email = "fernando3dias@gmail.com",
                            LastName = "Dias Motta",
                            Name = "Fernando",
                            Password = "123mudar",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(407)
                        });
                });

            modelBuilder.Entity("Domain.Entities.DependentPersonEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Passport")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("DependentPerson", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.HotelEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("AvgTicket")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Hotel", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("86faabfb-21b8-4eca-a999-db074e489e37"),
                            Address = "Rodovia Senador José Ermírio de Moraes, 1425",
                            AvgTicket = 150m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(420),
                            Name = "Facens Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(420),
                            ZipCode = "18085-784"
                        },
                        new
                        {
                            Id = new Guid("ee459eae-f928-480b-b795-0fa4ec4dcded"),
                            Address = "Avenida das Estrelas, 123",
                            AvgTicket = 250m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(422),
                            Name = "Luxury Palace Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(422),
                            ZipCode = "12345-678"
                        },
                        new
                        {
                            Id = new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"),
                            Address = "Rua das Flores, 456",
                            AvgTicket = 120m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(424),
                            Name = "Cozy Inn",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(424),
                            ZipCode = "54321-987"
                        },
                        new
                        {
                            Id = new Guid("eebfd31c-9492-471f-b844-2dc51d2cc6b7"),
                            Address = "Avenida Beira-Mar, 789",
                            AvgTicket = 180m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(425),
                            Name = "Harbor View Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(426),
                            ZipCode = "98765-432"
                        },
                        new
                        {
                            Id = new Guid("03158875-1b25-4844-81f4-8fe88147d56b"),
                            Address = "Praia da Areia Dourada, S/N",
                            AvgTicket = 300m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(427),
                            Name = "Golden Sands Resort",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(427),
                            ZipCode = "34567-890"
                        },
                        new
                        {
                            Id = new Guid("9fe39e98-4bdd-482a-b835-7b6616a9665d"),
                            Address = "Margem do Rio, 987",
                            AvgTicket = 160m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(429),
                            Name = "Riverside Lodge",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(429),
                            ZipCode = "76543-210"
                        },
                        new
                        {
                            Id = new Guid("98a51d43-35d0-495b-9932-c62311f4b130"),
                            Address = "Praça Principal, 654",
                            AvgTicket = 280m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(430),
                            Name = "The Grand Plaza Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(431),
                            ZipCode = "23456-789"
                        },
                        new
                        {
                            Id = new Guid("2045987e-853c-4fec-9c4e-4813347e044b"),
                            Address = "Avenida do Pôr do Sol, 321",
                            AvgTicket = 140m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(432),
                            Name = "Sunset View Inn",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(433),
                            ZipCode = "87654-321"
                        },
                        new
                        {
                            Id = new Guid("8dc27776-7086-426c-9657-a4f3ebf3c336"),
                            Address = "Rua das Montanhas, 567",
                            AvgTicket = 200m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(434),
                            Name = "Majestic Heights Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(434),
                            ZipCode = "54321-234"
                        },
                        new
                        {
                            Id = new Guid("dcbb8afa-7a1b-4f3c-bf92-88f9f6863c9d"),
                            Address = "Avenida Central, 876",
                            AvgTicket = 130m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(436),
                            Name = "Sorocaba Suites",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(436),
                            ZipCode = "12345-543"
                        },
                        new
                        {
                            Id = new Guid("c56db9bc-65d4-40cf-bd0f-427d1b1ba241"),
                            Address = "Trilha da Montanha, 765",
                            AvgTicket = 190m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(438),
                            Name = "Mountain View Lodge",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 47, 4, 346, DateTimeKind.Local).AddTicks(439),
                            ZipCode = "65432-123"
                        });
                });

            modelBuilder.Entity("Domain.Entities.ReservationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Checkin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Checkout")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReserveDateEnd")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReserveDateInit")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservation", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ReviewEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("EvaluationStars")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Review", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RoomEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberBeds")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeRoom")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Room", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("78d81163-0016-4409-8ffb-956c5bd4a880"),
                            HotelId = new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"),
                            Number = 46,
                            NumberBeds = 1,
                            PricePerNight = 92m,
                            Status = 1,
                            TypeRoom = 11
                        },
                        new
                        {
                            Id = new Guid("4f1ec501-e2b2-4067-9c06-0fe96e6f23a7"),
                            HotelId = new Guid("86faabfb-21b8-4eca-a999-db074e489e37"),
                            Number = 49,
                            NumberBeds = 3,
                            PricePerNight = 80m,
                            Status = 1,
                            TypeRoom = 5
                        },
                        new
                        {
                            Id = new Guid("c50d9ecb-c4f9-41a8-af27-5953cce4871b"),
                            HotelId = new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"),
                            Number = 73,
                            NumberBeds = 3,
                            PricePerNight = 107m,
                            Status = 1,
                            TypeRoom = 2
                        },
                        new
                        {
                            Id = new Guid("3ccbb7c5-8504-4429-aa6c-e8768a9885d8"),
                            HotelId = new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"),
                            Number = 65,
                            NumberBeds = 4,
                            PricePerNight = 156m,
                            Status = 1,
                            TypeRoom = 8
                        },
                        new
                        {
                            Id = new Guid("37fae2e0-c0a3-4d90-babe-ad3daaee523f"),
                            HotelId = new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"),
                            Number = 47,
                            NumberBeds = 1,
                            PricePerNight = 91m,
                            Status = 1,
                            TypeRoom = 8
                        },
                        new
                        {
                            Id = new Guid("016ee195-c138-4ba4-98b6-d8cd6b129715"),
                            HotelId = new Guid("eebfd31c-9492-471f-b844-2dc51d2cc6b7"),
                            Number = 41,
                            NumberBeds = 2,
                            PricePerNight = 94m,
                            Status = 1,
                            TypeRoom = 1
                        },
                        new
                        {
                            Id = new Guid("1a4f6607-4ce3-4ac8-8585-3576f2027789"),
                            HotelId = new Guid("ee459eae-f928-480b-b795-0fa4ec4dcded"),
                            Number = 96,
                            NumberBeds = 3,
                            PricePerNight = 135m,
                            Status = 1,
                            TypeRoom = 11
                        },
                        new
                        {
                            Id = new Guid("31deec56-8a89-4836-ab6f-fea56c0b75b3"),
                            HotelId = new Guid("86faabfb-21b8-4eca-a999-db074e489e37"),
                            Number = 28,
                            NumberBeds = 4,
                            PricePerNight = 141m,
                            Status = 1,
                            TypeRoom = 4
                        },
                        new
                        {
                            Id = new Guid("ee85f342-c4c7-45c6-abe4-3aa9e850e866"),
                            HotelId = new Guid("eebfd31c-9492-471f-b844-2dc51d2cc6b7"),
                            Number = 49,
                            NumberBeds = 2,
                            PricePerNight = 105m,
                            Status = 1,
                            TypeRoom = 2
                        },
                        new
                        {
                            Id = new Guid("5576f8ba-2dd3-42f5-b8ed-608f5b7850e3"),
                            HotelId = new Guid("a8bd52b9-60ae-4de7-a1d0-554c39c27d84"),
                            Number = 1,
                            NumberBeds = 3,
                            PricePerNight = 143m,
                            Status = 1,
                            TypeRoom = 4
                        });
                });

            modelBuilder.Entity("Domain.Entities.DependentPersonEntity", b =>
                {
                    b.HasOne("Domain.Entities.CustomerEntity", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.ReservationEntity", b =>
                {
                    b.HasOne("Domain.Entities.CustomerEntity", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.RoomEntity", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Domain.Entities.RoomEntity", b =>
                {
                    b.HasOne("Domain.Entities.HotelEntity", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Domain.Entities.HotelEntity", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
