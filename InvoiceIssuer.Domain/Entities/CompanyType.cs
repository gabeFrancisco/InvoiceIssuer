using InvoiceIssuer.Domain.Entities.Enums;

namespace InvoiceIssuer.Domain.Entities
{
    public class CompanyType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TaxClassEnum TaxClass { get; set; }
        private decimal _taxRate;
        public decimal TaxRate
        {
            get { return _taxRate; }
            set
            {
                if (TaxClass == TaxClassEnum.IndividualBusiness)
                {
                    _taxRate = 0.0M;
                }
                if (TaxClass == TaxClassEnum.SmallBusiness)
                {
                    _taxRate = 1.7M;
                }
                if (TaxClass == TaxClassEnum.MediumCompany)
                {
                    _taxRate = 3.5M;
                }
                if (TaxClass == TaxClassEnum.LargeCompany)
                {
                    _taxRate = 7.5M;
                }
            }
        }
    }
}