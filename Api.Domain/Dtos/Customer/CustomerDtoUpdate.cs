using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Dtos.Customer
{
    public class CustomerDtoUpdate
    {
        [Required(ErrorMessage = "ID é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sobrenome é campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        //[DataType(DataType.Date)]
        //[Display(Name = "Data de Nascimento")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[Range(typeof(DateTime), "01/01/1900", "", ErrorMessage = "A data de nascimento deve estar entre 01/01/1900 e a data de hoje.")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Email é campo obrigatório")]
        [EmailAddress(ErrorMessage = "Email em formato inválido.")]
        [StringLength(100, ErrorMessage = "Email deve ter no máximo {1} caracteres")]
        public string Email { get; set; }


        [StringLength(14, MinimumLength = 14, ErrorMessage = "O CPF deve ter 11 dígitos e ser formatado como '999.999.999-99'.")]
        //[RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Formato de CPF inválido. Use '999.999.999-99'.")]
        //[CustomValidation(typeof(CpfValidator), "ValidateCpf")]
        public string CPF { get; set; }


        //[RegularExpression(@"^\d{2}\.\d{3}\.\d{3}-\d{1}$", ErrorMessage = "Formato de RG inválido. Use '99.999.999-9'.")]
        //[CustomValidation(typeof(RgValidator), "ValidateRg")]
        public string RG { get; set; }

        public string Passport { get; set; }

        [Required(ErrorMessage = "Senha é campo obrigatório")]
        public string Password { get; set; }




        //private class CpfValidator
        //{
        //    public static ValidationResult ValidateCpf(string cpf, ValidationContext validationContext)
        //    {
        //        cpf = cpf.Replace(".", "").Replace("-", "");
        //        if (cpf.Length != 11 || !IsCpfValid(cpf))
        //        {
        //            return new ValidationResult("CPF inválido.");
        //        }
        //        return ValidationResult.Success;
        //    }

        //    private static bool IsCpfValid(string cpf)
        //    {
        //        // Implemente a lógica de validação do CPF aqui.
        //        // Consultar a Receita Federal ou utilizar um algoritmo de validação de CPF conhecido.
        //        // Essa parte da lógica não está implementada neste exemplo.
        //        return true;
        //    }
        //}

        //public class RgValidator
        //{
        //    private static ValidationResult ValidateRg(string rg, ValidationContext validationContext)
        //    {
        //        rg = rg.Replace(".", "").Replace("-", "");
        //        if (rg.Length != 9 || !IsRgValid(rg))
        //        {
        //            return new ValidationResult("RG inválido.");
        //        }
        //        return ValidationResult.Success;
        //    }

        //    private static bool IsRgValid(string rg)
        //    {
        //        // Implemente a lógica de validação do RG aqui.
        //        // A validação do RG pode variar de um estado para outro, e você deve seguir as regras específicas do estado em questão.
        //        // Essa parte da lógica não está implementada neste exemplo.
        //        return true;
        //    }
        //}
    }
}
