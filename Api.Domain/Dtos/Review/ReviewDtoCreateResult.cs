using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Review
{
    public class ReviewDtoCreateResult
    {
        public Guid Id { get; set; }
        public int EvaluationStars { get; set; }
        public string Comment { get; set; }
        public CustomerEntity Customer { get; set; }
        public HotelEntity Hotel { get; set; }
    }
}
