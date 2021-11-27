using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces.ServicesInterfaces
{
    public interface IServiceTypeService
    {
        Task<IEnumerable<ServiceType>> GetAll();
    }
}