using System;
using System.ComponentModel.DataAnnotations;

namespace InvoiceIssuer.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        private DateTime? _createdAt = DateTime.UtcNow;
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { _createdAt = (value == null ? DateTime.UtcNow : value); }
        }
        public DateTime? UpdatedAt { get; set; }
    }
}