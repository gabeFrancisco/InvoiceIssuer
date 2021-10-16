using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces
{
    public interface ICompanyTypeRepository : IBaseRepository<CompanyType>
    {
        Task<CompanyType> GetByName(string name);
    }
}