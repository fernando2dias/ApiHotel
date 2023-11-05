using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Hotel
{
    public class HotelDtoCreate
    {
        [Required(ErrorMessage = "Nome do Hotel é campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome do Hotel deve ter no máximo {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Endereço é campo obrigatório")]
        [StringLength(200, ErrorMessage = "Endereço deve ter no máximo {1} caracteres")]
        public string Address { get; set; }

        [Required(ErrorMessage = "CEP é campo obrigatório")]
        [StringLength(8, ErrorMessage = "CEP deve ter no máximo {1} caracteres")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Estado é campo obrigatório")]
        [StringLength(2, ErrorMessage = "Estado deve ter no máximo {1} caracteres")]
        public string State { get; set; }

        [Required(ErrorMessage = "Cidade é campo obrigatório")]
        [StringLength(30, ErrorMessage = "Cidade deve ter no máximo {1} caracteres")]
        public string City { get; set; }

        [Required(ErrorMessage = "Média de valor é campo obrigatório")]
        public decimal AvgTicket { get; set; }
        public List<RoomEntity>? Rooms { get; set; }
    }
}
