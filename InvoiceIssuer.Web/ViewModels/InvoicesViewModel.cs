using InvoiceIssuer.Domain.Entities;
using System;
using System.Collections.Generic;

namespace InvoiceIssuer.Web.ViewModels
{
    public class InvoicesViewModel
    {
        public Provider Provider { get; set; }
        public Taker Taker { get; set; }
        public Invoice Invoice { get; set; }
        public DateTime Date { get; set; }
        public Address Address { get; set; }
        public string ServiceType { get; set; }
        public string CompanyType { get; set; }
        public IEnumerable<CompanyType> CompanyTypes { get; set; }
        public IEnumerable<Invoice> Invoices { get; set; }
        public IEnumerable<ServiceType> ServiceTypes { get; set; }
    }
}