using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.Customer
{
    public class CustomerDtoCreate
    {
        [Required(ErrorMessage = "Nome é campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sobrenome é campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
       // [DataType(DataType.Date)]
       // [Display(Name = "Data de Nascimento")]
       // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
       // [Range(typeof(DateTime), "01/01/1900","", ErrorMessage = "A data de nascimento deve estar entre 01/01/1900 e a data de hoje.")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Email é campo obrigatório")]
        [EmailAddress(ErrorMessage = "Email em formato inválido.")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres")]
        public string Email { get; set; }


        [StringLength(14, MinimumLength = 14, ErrorMessage = "O CPF deve ter 11 dígitos e ser formatado como '999.999.999-99'.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Formato de CPF inválido. Use '999.999.999-99'.")]
        public string CPF { get; set; }


        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}-\d{1}$", ErrorMessage = "Formato de RG inválido. Use '99.999.999-9'.")]
        public string RG { get; set; }

        [StringLength(30, ErrorMessage = "Passaporte deve ter no máximo {1} caracteres")]
        public string Passport { get; set; }

        [StringLength(20, ErrorMessage = "Senha deve ter no máximo {1} caracteres")]
        [Required(ErrorMessage = "Senha é campo obrigatório")]
        public string Password { get; set; }



    }

}
