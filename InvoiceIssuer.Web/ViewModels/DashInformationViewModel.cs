using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Web.ViewModels
{
    public class DashInformationViewModel
    {
        public Provider Provider { get; set; }
        public Address Address { get; set; }
    }
}