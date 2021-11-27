using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;

namespace InvoiceIssuer.Services
{
    public class CompanyTypeService : ICompanyTypeService
    {
        private readonly ICompanyTypeRepository _companyTypeRepository;
        public CompanyTypeService(ICompanyTypeRepository companyTypeRepository) => _companyTypeRepository = companyTypeRepository;
        public async Task<IEnumerable<CompanyType>> GetAll() => await _companyTypeRepository.GetAll();
    }
}