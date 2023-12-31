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
    [Migration("20231108234316_fixreview2")]
    partial class fixreview2
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
                            Id = new Guid("32dbe5c4-4b77-4b1e-808c-fb104e4e88ff"),
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7423),
                            Email = "fer@admin.com.br",
                            Name = "Administrador",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7434)
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
                            Id = new Guid("25b6c777-4a13-4004-952b-bfddf66caa9c"),
                            BirthDate = new DateTime(1986, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "111.222.333-44",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7588),
                            Email = "fernando3dias@gmail.com",
                            LastName = "Dias Motta",
                            Name = "Fernando",
                            Password = "123mudar",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7589)
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
                            Id = new Guid("6f134138-26e8-4485-be91-6ce45e37fa4f"),
                            Address = "Rodovia Senador José Ermírio de Moraes, 1425",
                            AvgTicket = 150m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7602),
                            Name = "Facens Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7603),
                            ZipCode = "18085-784"
                        },
                        new
                        {
                            Id = new Guid("1d87ad36-bcbd-4181-8405-bedb13e6d952"),
                            Address = "Avenida das Estrelas, 123",
                            AvgTicket = 250m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7604),
                            Name = "Luxury Palace Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7605),
                            ZipCode = "12345-678"
                        },
                        new
                        {
                            Id = new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"),
                            Address = "Rua das Flores, 456",
                            AvgTicket = 120m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7606),
                            Name = "Cozy Inn",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7607),
                            ZipCode = "54321-987"
                        },
                        new
                        {
                            Id = new Guid("337388f1-3da4-4e30-88a1-caf45fb78447"),
                            Address = "Avenida Beira-Mar, 789",
                            AvgTicket = 180m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7608),
                            Name = "Harbor View Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7609),
                            ZipCode = "98765-432"
                        },
                        new
                        {
                            Id = new Guid("cc6ed24a-fb03-42cb-9c54-4dc29c3cbaaf"),
                            Address = "Praia da Areia Dourada, S/N",
                            AvgTicket = 300m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7610),
                            Name = "Golden Sands Resort",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7610),
                            ZipCode = "34567-890"
                        },
                        new
                        {
                            Id = new Guid("eadceebe-8411-45b5-9cab-df11d5133e40"),
                            Address = "Margem do Rio, 987",
                            AvgTicket = 160m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7612),
                            Name = "Riverside Lodge",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7612),
                            ZipCode = "76543-210"
                        },
                        new
                        {
                            Id = new Guid("6fd229f6-a963-403e-9497-e938c0866642"),
                            Address = "Praça Principal, 654",
                            AvgTicket = 280m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7645),
                            Name = "The Grand Plaza Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7645),
                            ZipCode = "23456-789"
                        },
                        new
                        {
                            Id = new Guid("7c4aa550-3a37-4b36-ae37-5ad929a7b007"),
                            Address = "Avenida do Pôr do Sol, 321",
                            AvgTicket = 140m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7647),
                            Name = "Sunset View Inn",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7647),
                            ZipCode = "87654-321"
                        },
                        new
                        {
                            Id = new Guid("0cf96aeb-36d7-4432-ace3-833449a2769b"),
                            Address = "Rua das Montanhas, 567",
                            AvgTicket = 200m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7649),
                            Name = "Majestic Heights Hotel",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7649),
                            ZipCode = "54321-234"
                        },
                        new
                        {
                            Id = new Guid("6842b955-7eda-430a-b40d-d66b8f49d189"),
                            Address = "Avenida Central, 876",
                            AvgTicket = 130m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7651),
                            Name = "Sorocaba Suites",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7652),
                            ZipCode = "12345-543"
                        },
                        new
                        {
                            Id = new Guid("fca839a5-7e7c-418d-aeb4-a43e25ffa9b1"),
                            Address = "Trilha da Montanha, 765",
                            AvgTicket = 190m,
                            City = "Sorocaba",
                            CreateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7653),
                            Name = "Mountain View Lodge",
                            State = "SP",
                            UpdateAt = new DateTime(2023, 11, 8, 20, 43, 16, 337, DateTimeKind.Local).AddTicks(7654),
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
                            Id = new Guid("13301f3c-c3c6-4cee-8023-f075986b9327"),
                            HotelId = new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"),
                            Number = 1,
                            NumberBeds = 2,
                            PricePerNight = 161m,
                            Status = 1,
                            TypeRoom = 8
                        },
                        new
                        {
                            Id = new Guid("077ac67d-3a91-48be-a718-9f3682cd2df9"),
                            HotelId = new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"),
                            Number = 64,
                            NumberBeds = 1,
                            PricePerNight = 84m,
                            Status = 1,
                            TypeRoom = 7
                        },
                        new
                        {
                            Id = new Guid("a2b9d2f4-982c-4c99-a73e-3aa9810987dd"),
                            HotelId = new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"),
                            Number = 34,
                            NumberBeds = 3,
                            PricePerNight = 125m,
                            Status = 1,
                            TypeRoom = 5
                        },
                        new
                        {
                            Id = new Guid("3c727f96-e7ca-45ae-a742-85691d74a361"),
                            HotelId = new Guid("6f134138-26e8-4485-be91-6ce45e37fa4f"),
                            Number = 24,
                            NumberBeds = 2,
                            PricePerNight = 163m,
                            Status = 1,
                            TypeRoom = 5
                        },
                        new
                        {
                            Id = new Guid("37356558-4658-4831-b19a-a3492952b795"),
                            HotelId = new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"),
                            Number = 2,
                            NumberBeds = 3,
                            PricePerNight = 107m,
                            Status = 1,
                            TypeRoom = 10
                        },
                        new
                        {
                            Id = new Guid("41470ba6-dec4-4ed6-bbea-e659c2f72c8c"),
                            HotelId = new Guid("337388f1-3da4-4e30-88a1-caf45fb78447"),
                            Number = 25,
                            NumberBeds = 2,
                            PricePerNight = 152m,
                            Status = 1,
                            TypeRoom = 2
                        },
                        new
                        {
                            Id = new Guid("f30b1862-32bc-4587-a491-86b2e960e86f"),
                            HotelId = new Guid("6f134138-26e8-4485-be91-6ce45e37fa4f"),
                            Number = 63,
                            NumberBeds = 1,
                            PricePerNight = 189m,
                            Status = 1,
                            TypeRoom = 3
                        },
                        new
                        {
                            Id = new Guid("876c663c-1ddb-4330-906f-0452dd11ad43"),
                            HotelId = new Guid("a39400fe-a3be-41e3-9c78-487006b620b3"),
                            Number = 32,
                            NumberBeds = 1,
                            PricePerNight = 188m,
                            Status = 1,
                            TypeRoom = 6
                        },
                        new
                        {
                            Id = new Guid("62a08296-56c0-483c-881a-61a2bda8784b"),
                            HotelId = new Guid("1d87ad36-bcbd-4181-8405-bedb13e6d952"),
                            Number = 10,
                            NumberBeds = 1,
                            PricePerNight = 190m,
                            Status = 1,
                            TypeRoom = 4
                        },
                        new
                        {
                            Id = new Guid("57508cef-9d2b-4f88-9c65-fa977a496056"),
                            HotelId = new Guid("1d87ad36-bcbd-4181-8405-bedb13e6d952"),
                            Number = 16,
                            NumberBeds = 3,
                            PricePerNight = 196m,
                            Status = 1,
                            TypeRoom = 8
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
