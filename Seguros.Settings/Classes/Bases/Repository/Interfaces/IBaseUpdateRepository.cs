using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Settings.Classes.Bases.Repository.Interfaces
{
    public interface IBaseUpdateRepository<TEntity> where TEntity : class
    {
        TEntity Update(TEntity entity, bool autoSave = true);
        Task<TEntity> UpdateAsync(TEntity entity, bool autoSave = true);
    }
}
