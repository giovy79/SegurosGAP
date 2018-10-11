using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Settings.Classes.Bases.Repository.Interfaces
{
    public interface IBaseCRUDRepository<TEntity> : IBaseCreateRepository<TEntity>, IBaseReadRepository<TEntity>, IBaseUpdateRepository<TEntity>, IBaseDeleteRepository<TEntity> where TEntity : class
    {
    }
}
