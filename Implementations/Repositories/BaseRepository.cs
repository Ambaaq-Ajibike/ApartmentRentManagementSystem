using ApartmentRentManagementSystem.Interfaces.Repositories;using System;
using System.Collections.Generic;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using ApartmentRentManagementSystem.Contracts;
using System.Linq;
using System.Threading.Tasks;
using ApartmentRentManagementSystem.Context;
using System.Linq.Expressions;
namespace ApartmentRentManagementSystem.Implementations.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        protected ApplicationContext _context;
        public async Task<T> Register(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Get(Expression<Func<T, bool>> expression)
        {
            var ans = await _context.Set<T>().SingleOrDefaultAsync(expression);
            return ans;
        }
        public async Task<IList<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<bool> Delete(T entity)
        {
             _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<IList<T>> GetByExpression(Expression<Func<T, bool>> expression)
        {
            var get = await _context.Set<T>().Where(expression).ToListAsync();
            return get;
        }
    }
}