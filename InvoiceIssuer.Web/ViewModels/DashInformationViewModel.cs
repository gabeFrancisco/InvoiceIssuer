using System.Collections.Generic;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Web.ViewModels
{
    public class DashInformationViewModel
    {
        public Provider Provider { get; set; }
        public Invoice Invoice { get; set; }
        public IEnumerable<Invoice> Invoices { get; set; }
    }
}