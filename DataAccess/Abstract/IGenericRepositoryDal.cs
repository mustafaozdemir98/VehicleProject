using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericRepositoryDal<TEntity>
    {
        Task<TEntity> GetById(int id);
        Task <IEnumerable<TEntity>> GetAll();
        Task<TEntity> Create(TEntity entity);
        Task Update(TEntity entity);
        Task<TEntity> Delete(TEntity entity);
    }
}
