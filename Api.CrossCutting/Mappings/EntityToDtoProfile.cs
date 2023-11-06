using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;
using Domain.Dtos.Customer;
using Domain.Dtos.Hotel;
using Domain.Dtos.Review;
using Domain.Entities;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDto, UserEntity>()
                .ReverseMap();

            CreateMap<UserDtoCreateResult, UserEntity>()
                .ReverseMap();

            CreateMap<UserDtoUpdateResult, UserEntity>()
                .ReverseMap();



            CreateMap<CustomerDto, CustomerEntity>()
                .ReverseMap();

            CreateMap<CustomerDtoCreateResult, CustomerEntity>()
                .ReverseMap();

            CreateMap<CustomerDtoUpdateResult, CustomerEntity>()
                .ReverseMap();



            //CreateMap<DependentPersonDto, DependentPersonEntity>()
            //    .ReverseMap();

            //CreateMap<DependentPersonDtoCreateResult, DependentPersonEntity>()
            //    .ReverseMap();

            //CreateMap<DependentPersonDtoUpdateResult, DependentPersonEntity>()
            //    .ReverseMap();



            CreateMap<HotelDto, HotelEntity>()
                .ReverseMap();

            CreateMap<HotelDtoCreateResult, HotelEntity>()
                .ReverseMap();

            CreateMap<HotelDtoUpdateResult, HotelEntity>()
                .ReverseMap();


            CreateMap<RoomDto, RoomEntity>()
                .ReverseMap();

            CreateMap<RoomDtoCreateResult, RoomEntity>()
                .ReverseMap();

            CreateMap<RoomDtoUpdateResult, RoomEntity>()
                .ReverseMap();



            CreateMap<ReviewDto, ReviewEntity>()
                .ReverseMap();

            CreateMap<ReviewDtoCreateResult, RoomEntity>()
                .ReverseMap();

            CreateMap<ReviewDtoUpdateResult, RoomEntity>()
                .ReverseMap();


        }
    }
}