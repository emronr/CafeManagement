using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CafeManagement.Domain.Context;
using CafeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CafeManagement.Domain.Repositories.Base
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>, new()
        where TKey : IComparable
    {
        protected readonly CafeManagementContext _context;

        public BaseRepository(CafeManagementContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(List<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
            _context.SaveChanges();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public async Task<TEntity> FindAsync(TKey entityId)
        {
            return await _context.Set<TEntity>().FindAsync(entityId);
        }

        public IQueryable<TEntity> Query()
        {
            return _context.Set<TEntity>().AsQueryable();
        }


        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
    }
}