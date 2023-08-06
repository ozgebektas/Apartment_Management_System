using Apartment.DataAccessLayer.Context;
using Apartment.EntityLayer.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApartmentDbContext _apartmetDbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApartmentDbContext apartmetDbContext, DbSet<T> dbSet)
        {
            _apartmetDbContext = apartmetDbContext;
            _dbSet = dbSet;
        }

        public async Task Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _apartmetDbContext.Entry(entity).State = EntityState.Modified;
        }

    }
}
