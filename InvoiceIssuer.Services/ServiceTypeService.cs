using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;

namespace InvoiceIssuer.Services
{
    public class ServiceTypeService : IServiceTypeService
    {
        private readonly IServiceTypeRepository _serviceTypeRepository;
        public ServiceTypeService(IServiceTypeRepository serviceTypeRepository) => _serviceTypeRepository = serviceTypeRepository;
        public async Task<IEnumerable<ServiceType>> GetAll() => await _serviceTypeRepository.GetAll();
    }
}