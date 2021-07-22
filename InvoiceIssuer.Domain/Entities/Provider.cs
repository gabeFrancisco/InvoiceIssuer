using System.Collections.Generic;

namespace InvoiceIssuer.Domain.Entities
{
    public class Provider : Company
    {
        public string Password { get; set; }
        public string LogoPath { get; set; }
    }
}