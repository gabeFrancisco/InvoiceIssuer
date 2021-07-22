namespace InvoiceIssuer.Domain.Entities
{
    public abstract class Company : BaseEntity
    {
        //CI stands for "Company Identifier", a 7 digit number
        public int CI { get; set; } 
        public string ComercialName { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public CompanyType CompanyType { get; set; }
    }
}