using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Settings.Classes.Bases.Repository.Interfaces
{
    public interface IBaseCreateRepository<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity, bool autoSave = true);
        Task<TEntity> CreateAsync(TEntity entity, bool autoSave = true);
    }
}
