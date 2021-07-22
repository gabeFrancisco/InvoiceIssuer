namespace InvoiceIssuer.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string Road { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Block { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}