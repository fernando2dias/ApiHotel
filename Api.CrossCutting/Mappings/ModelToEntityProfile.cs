using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserEntity, UserModel>()
                .ReverseMap();

            CreateMap<CustomerEntity, CustomerModel>()
                .ReverseMap();

            CreateMap<DependentPersonEntity, DependentPersonModel>()
                .ReverseMap();

            CreateMap<HotelEntity, HotelModel>()
                .ReverseMap();

            CreateMap<RoomEntity, RoomModel>()
                .ReverseMap();

            CreateMap<ReviewEntity, ReviewModel>()
                .ReverseMap();

            CreateMap<ReservationEntity, ReservationModel>()
                .ReverseMap();
        }
    }
}