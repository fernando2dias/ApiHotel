﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class HotelModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;
        public string Address 
        {
            get { return _address; }
            set { _address = value; } 
        }

        private string _zipCode;
        public String ZipCode 
        {
            get { return _zipCode; }
            set { _zipCode = value; } 
        }
        
        private string _state;
        public string State 
        {
            get { return _state; }
            set { _state = value; } 
        }

        private string _city;
        public string City 
        {
            get { return _city; }
            set { _city = value; } 
        }

        private decimal _avgTicket;
        public decimal AvgTicket 
        {
            get { return _avgTicket; }
            set { _avgTicket = value; } 
        }

        private List<RoomEntity> _rooms;
        public List<RoomEntity> Rooms 
        {
            get { return _rooms; }
            set { _rooms = value; } 
        }

    }
}
