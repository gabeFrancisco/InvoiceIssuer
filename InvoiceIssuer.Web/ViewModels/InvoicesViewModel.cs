using System.Collections.Generic;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Web.ViewModels
{
    public class InvoicesViewModel
    {
        public Provider Provider { get; set; }
        public Invoice Invoice { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Address Address { get; set; }
        public string ServiceType { get; set; }
        public IEnumerable<Invoice> Invoices { get; set; }
        public IEnumerable<ServiceType> ServiceTypes { get; set; }
    }
}