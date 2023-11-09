﻿using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ReviewEntity : BaseEntity
    {
        public int EvaluationStars { get; set; }
        public string Comment { get; set; }
        public Guid CustomerId { get; set; }
        public Guid HotelId { get; set; }
    }
}
