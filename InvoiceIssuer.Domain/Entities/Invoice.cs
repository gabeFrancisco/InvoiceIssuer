using System;
using System.ComponentModel.DataAnnotations;

namespace InvoiceIssuer.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid ProviderId { get; set; }
        public virtual Provider Provider { get; set; }
        public Guid TakerId { get; set; }
        public virtual Taker Taker { get; set; }
        public Guid ServiceTypeId { get; set; }
        public virtual ServiceType ServiceType { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public decimal TaxValue { get; set; }
        private bool _isCanceled;
        public bool IsCanceled
        {
            get
            {
                return _isCanceled;
            }
            set
            {
                IsCanceled = value;
                _isEditable = false;
            }
        }

        private bool _isEditable;
        public bool IsEditable
        {
            get
            {
                if (Date.Month != DateTime.Now.Month)
                    return _isEditable = false;
                else
                    return _isEditable = true;
            }
        }
    }
}