using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ReservationModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _checkin;
        public DateTime Checkin 
        {
            get { return _checkin; }
            set { _checkin = value; } 
        }

        private DateTime _checkout;
        public DateTime Checkout 
        {
            get { return _checkout; }
            set { _checkout = value; } 
        }

        private DateTime _reservationDateInit;
        public DateTime ReservationDateInit
        {
            get { return _reservationDateInit; }
            set { _reservationDateInit = value; }
        }

        private DateTime _reservationDateEnd;
        public DateTime ReservationDateEnd
        {
            get { return _reservationDateEnd; }
            set { _reservationDateEnd = value; }
        }


        private CustomerEntity _customer;
        public CustomerEntity Customer 
        {
            get { return _customer; }
            set { _customer = value; } 
        }

        private RoomEntity _room;
        public RoomEntity Room 
        {
            get { return _room; }
            set { _room = value; } 
        }
    }
}
