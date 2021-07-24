using System;

namespace InvoiceIssuer.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid TakerId { get; set; }
        public virtual Taker Taker { get; set; }
        public Guid ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public decimal TaxValue { get; set; }
    }
}