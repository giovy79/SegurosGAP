﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Settings.Classes.Bases.Repository.Interfaces
{
    public interface IBaseDeleteRepository<TEntity> where TEntity : class
    {
        TEntity Delete(TEntity entity, bool autoSave = true);
        Task<TEntity> DeleteAsync(TEntity entity, bool autoSave = true);
    }
}
