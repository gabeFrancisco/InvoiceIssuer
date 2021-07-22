using System.Collections.Generic;

namespace InvoiceIssuer.Domain.Entities
{
    public class Provider : Company
    {
        public string Password { get; set; }
        public ICollection<ServiceType> ServiceTypes { get; set; }
        public ICollection<Taker> Takers { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}