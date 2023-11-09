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


        private Guid _customerId;
        public Guid CustomerId 
        {
            get { return _customerId; }
            set { _customerId = value; } 
        }

        private Guid _roomId;
        public Guid RoomId 
        {
            get { return _roomId; }
            set { _roomId = value; } 
        }
    }
}
