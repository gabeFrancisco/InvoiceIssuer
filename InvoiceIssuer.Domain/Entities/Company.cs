using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceIssuer.Domain.Entities
{
    public abstract class Company : BaseEntity
    {
        //CI stands for "Company Identifier", a unique 7 digit number
        public string CI { get; set; } 
        public string ComercialName { get; set; }
        public Guid AddressId { get; set; }
        public virtual Address Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guid CompanyTypeId { get; set; }
        public virtual CompanyType CompanyType { get; set; }
    }
}