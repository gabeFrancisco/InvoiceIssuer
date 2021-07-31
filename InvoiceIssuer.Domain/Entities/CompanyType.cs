namespace InvoiceIssuer.Domain.Entities
{
    public class CompanyType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TaxRate { get; set; }
        
    }
}