using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;
using Domain.Dtos.Customer;
using Domain.Models;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>().ReverseMap();
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();

            CreateMap<CustomerModel, CustomerDto>().ReverseMap();
            CreateMap<CustomerModel, CustomerDtoCreate>().ReverseMap();
            CreateMap<CustomerModel, CustomerDtoUpdate>().ReverseMap();
        }
    }
}