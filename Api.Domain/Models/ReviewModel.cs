using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ReviewModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _evaluationStars;
        public int EvaluationStars 
        {
            get { return _evaluationStars; }
            set { _evaluationStars = value; } 
        }

        private string _comment;
        public string Comment 
        {
            get { return _comment; }
            set { _comment = value; } 
        }

        private Guid _customerId;
        public Guid CustomerId 
        {
            get { return _customerId; }
            set { _customerId = value; } 
        }

        private Guid _hotelId;
        public Guid HotelId 
        {
            get { return _hotelId; }
            set { _hotelId = value; } 
        }
    }
}
