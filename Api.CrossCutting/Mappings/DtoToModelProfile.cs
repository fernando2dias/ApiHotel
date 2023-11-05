using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;
using Domain.Dtos.Customer;
using Domain.Dtos.Hotel;
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

            CreateMap<DependentPersonModel, DependentPersonDto>().ReverseMap();
            CreateMap<DependentPersonModel, DependentPersonDtoCreate>().ReverseMap();
            CreateMap<DependentPersonModel, DependentPersonDtoUpdate>().ReverseMap();

            CreateMap<HotelModel, HotelDto>().ReverseMap();
            CreateMap<HotelModel, HotelDtoCreate>().ReverseMap();
            CreateMap<HotelModel, HotelDtoUpdate>().ReverseMap();

            CreateMap<RoomModel, RoomDto>().ReverseMap();
            CreateMap<RoomModel, RoomDtoCreate>().ReverseMap();
            CreateMap<RoomModel, RoomDtoUpdate>().ReverseMap();


        }
    }
}