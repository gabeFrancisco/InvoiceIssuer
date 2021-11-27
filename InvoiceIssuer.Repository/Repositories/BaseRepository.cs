using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoiceIssuer.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly AppDbContext _context;
        private DbSet<TEntity> _dataset;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
            _dataset = _context.Set<TEntity>();
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            try
            {
                if (entity.Id == Guid.Empty)
                    entity.Id = Guid.NewGuid();

                entity.CreatedAt = DateTime.UtcNow;
                _dataset.Add(entity);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(x => x.Id.Equals(id));
                if (result == null)
                    return false;

                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _context.DisposeAsync();
        }

        public async Task<bool> Exists(Guid id)
        {
            return await _dataset.AnyAsync(x => x.Id.Equals(id));
        }

        public async Task<ICollection<TEntity>> GetAll()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<TEntity> Read(Guid id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(x => x.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(x => x.Id.Equals(entity.Id));
                if (result == null)
                    return null;

                entity.UpdatedAt = DateTime.UtcNow;
                entity.CreatedAt = result.CreatedAt;

                _context.Entry(result).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }
    }
}