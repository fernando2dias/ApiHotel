using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DependentPersonModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _cpf;
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value == null ? "000.000.000-00" : value; }
        }

        private string _rg;
        public string RG
        {
            get { return _rg; }
            set { _rg = value == null ? "00.000.000-0" : value; }
        }

        private string _passport;
        public string Passport
        {
            get { return _passport; }
            set { _passport = value == null ? "000000000" : value; }
        }

        private CustomerEntity _customer;
        public CustomerEntity Customer 
        {
            get { return _customer; }
            set { _customer = value; }
        }

    }
}
