using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Hotel
{
    public class RoomDtoUpdate
    {
        [Required(ErrorMessage = "ID é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Número do quarto é campo obrigatório")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Tipo de quarto é campo obrigatório")]
        public TypeRoom TypeRoom { get; set; }

        [Required(ErrorMessage = "Número de camas é campo obrigatório")]
        public int NumberBeds { get; set; }

        [Required(ErrorMessage = "Preço é campo obrigatório")]
        public decimal PricePerNight { get; set; }

        [Required(ErrorMessage = "É preciso ter um hotel cadastrado")]
        public Guid HotelId { get; set; }

    }
}
