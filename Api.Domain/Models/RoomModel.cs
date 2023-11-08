using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RoomModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _number;
        public int Number 
        {
            get { return _number; }
            set { _number = value;  } 
        }

        private TypeRoom _typeRoom;
        public TypeRoom TypeRoom 
        {
            get { return _typeRoom; }
            set { _typeRoom = value; } 
        }

        private int _numberBeds;
        public int NumberBeds 
        {
            get { return _numberBeds; }
            set { _numberBeds = value; } 
        }

        private decimal _pricePerNight;
        public decimal PricePerNight 
        {
            get { return _pricePerNight; }
            set { _pricePerNight = value; } 
        }


        private Guid _hotelId;
        public Guid HotelId 
        {
            get { return _hotelId; }
            set { _hotelId = value; } 
        }

        private HotelEntity _hotel;
        public HotelEntity Hotel 
        {
            get { return _hotel; }
            set { _hotel = value; } 
        }
    }
}
