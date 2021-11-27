using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;

namespace InvoiceIssuer.Services
{
    public class TakerService : ITakerService
    {
        private readonly ITakerRepository _takerRepository;
        public TakerService(ITakerRepository takerRepository)
        {
            _takerRepository = takerRepository;
        }
        public async Task<Taker> ReadTaker(string companyIndex)
        {
            return await _takerRepository.GetByCI(companyIndex);
        }
    }
}