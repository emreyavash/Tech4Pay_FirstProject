using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class,new ()
    {
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll();
        void Add(TEntity entity);   
        void Delete(TEntity entity);
        void Update(TEntity entity);

    }
}
