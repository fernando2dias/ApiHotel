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
        public String Name { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public String CPF { get; set; }
        public String RG { get; set; }
        public String Passport { get; set; }
        public CustomerEntity Customer { get; set; }
    }
}
