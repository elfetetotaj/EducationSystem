using ES.Domain.Models;
using ES.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ES.Application.Services.Repository
{
    public class GenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> All() => await dbSet.ToListAsync();

        public virtual async Task<T> GetById(object id) => await dbSet.FindAsync(id);

        public async Task<bool> Add(T entity) => (await dbSet.AddAsync(entity)).Entity != null;

        public async Task<bool> Delete(object id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                var result = await _context.SaveChangesAsync();
                return result > 0;
            }
            return false;
        }

        public async Task<bool> Upsert(T entity)
        {
            var existingEntity = await dbSet.FindAsync(entity);
            if (existingEntity == null)
            {
                await dbSet.AddAsync(entity);
            }
            else
            {
                dbSet.Update(entity);
            }
            var result = await _context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate) => await dbSet.Where(predicate).ToListAsync();

        public async Task<List<T>> FindList(Expression<Func<T, bool>> predicate) => await dbSet.Where(predicate).ToListAsync();
    }
}
