﻿using Api.Domain.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IRoomRepository : IRepository<RoomEntity>
    {
        Task<RoomEntity> FindByHotel(HotelEntity hotel);
    }
}
