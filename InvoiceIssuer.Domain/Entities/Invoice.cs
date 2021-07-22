using System;

namespace InvoiceIssuer.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Taker Taker { get; set; }
        public ServiceType ServiceType { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public decimal TaxValue { get; set; }
    }
}