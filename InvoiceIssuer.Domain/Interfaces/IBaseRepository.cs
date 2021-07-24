using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Read(Guid id);
        Task<TEntity> Update(TEntity entity);
        Task<bool> Delete(Guid id);
        Task<ICollection<TEntity>> GetAll();
        Task<bool> Exists(Guid id);
    }
}