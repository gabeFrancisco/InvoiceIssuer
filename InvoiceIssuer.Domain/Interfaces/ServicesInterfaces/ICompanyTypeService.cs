using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces.ServicesInterfaces
{
    public interface ICompanyTypeService
    {
        Task<IEnumerable<CompanyType>> GetAll();
    }
}