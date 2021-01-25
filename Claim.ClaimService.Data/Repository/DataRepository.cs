using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claim.ClaimService.Data.Repository
{   
    public class DataRepository<T> : IDataRepository<T> where T : class
    {
        private DataContext _ctx;
        internal DbSet<T> dbSet;

        public DataRepository(DataContext ctx)
        {
            _ctx = ctx;
            this.dbSet = _ctx.Set<T>();
        }
        public async Task Create(T entity)
        {
           await dbSet.AddAsync(entity);
        }

        public void Delete(T entityToDelete)
        {
            if (_ctx.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public async Task<T> GetById(long id)
        {
           return await dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            dbSet.Attach(entity);
            _ctx.Entry(entity).State = EntityState.Modified;
        }

        public async Task<List<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

    }
}
