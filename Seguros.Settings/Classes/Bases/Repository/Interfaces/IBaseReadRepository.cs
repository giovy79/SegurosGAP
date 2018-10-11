using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Settings.Classes.Bases.Repository.Interfaces
{
    public interface IBaseReadRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllSkipAndTake(int skip, int take);
    }
}
