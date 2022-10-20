using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
    public class GenericRepositoryDal<TEntity,TContext> : IGenericRepositoryDal<TEntity> where TEntity : class where TContext : DbContext,new()
    {

        public async Task<TEntity> GetById(int id)
        {
            using (TContext context = new TContext())
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
                
        }
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            using (TContext context = new TContext())
            {
                return await context.Set<TEntity>().ToListAsync();
            }
                
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Add(entity);
                await context.SaveChangesAsync();
                return entity;
            }
                
        }

        public async Task Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
               
        }

        public async Task<TEntity> Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
                return entity;
            }
                

        }

    }
}
