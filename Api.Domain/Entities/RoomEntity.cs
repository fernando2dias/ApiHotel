using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RoomEntity : BaseEntity
    {
        public int Number { get; set; }
        public TypeRoom TypeRoom { get; set; }
        public int NumberBeds { get; set; }
        public decimal PricePerNight { get; set; }
        public Status Status { get; set; }

        public HotelEntity Hotel { get; set; }
    }

    public enum Status
    {
        Available = 1,
        Busy = 2,
        Reserved = 3
    }


    public enum TypeRoom
    {
        Single = 1,
        Double = 2,
        Triple = 3,
        Quad = 4,
        Queen = 5,
        King = 6,
        Twin = 7,
        DoubleDouble = 8,
        Suite = 9,
        MiniSuite = 10,
        PresidentSuite = 11
    }
}
