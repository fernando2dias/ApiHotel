using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Review
{
    public class ReviewDtoCreate
    {
        [Required(ErrorMessage = "Avaliação é um campo obrigatório")]
        [Range(0, 5, ErrorMessage = "A avaliação deve estar no intervalo de 0 a 5.")]
        public int EvaluationStars { get; set; }

        [StringLength(500, ErrorMessage = "O comentário deve ter no máximo {1} caracteres")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Cliente é um campo obrigatório")]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "Hotel é um campo obrigatório")]
        public Guid HotelId { get; set; }
    }
}
