using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DependentPersonEntity : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Passport { get; set; }
        public CustomerEntity Customer { get; set; }
    }
}
