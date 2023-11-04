using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;
using Domain.Dtos.Customer;
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
        }
    }
}