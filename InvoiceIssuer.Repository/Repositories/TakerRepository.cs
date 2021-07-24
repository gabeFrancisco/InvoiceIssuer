using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Repository.Context;

namespace InvoiceIssuer.Repository.Repositories
{
    public class TakerRepository : BaseRepository<Taker>, ITakerRepository
    {
        public TakerRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}