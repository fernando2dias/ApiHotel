using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Hotel
{
    public class RoomDto
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public TypeRoom TypeRoom { get; set; }
        public int NumberBeds { get; set; }
        public decimal PricePerNight { get; set; }
        public HotelEntity Hotel { get; set; }
    }
}
