using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seguros.Settings.Classes.Bases.Repository.Interfaces;

namespace Seguros.Settings.Classes.Bases.Repository
{
    public abstract class BaseCRUDRepository<TEntity> : IBaseCRUDRepository<TEntity> where TEntity : class
    {
        public DbContext DataBaseConnection;
        public DbSet<TEntity> Table;
        public BaseCRUDRepository(DbContext dbContext)
        {
            DataBaseConnection = dbContext;
            Table = DataBaseConnection.Set<TEntity>();
        }

        public TEntity Create(TEntity entity, bool autoSave = true)
        {
            Table.Add(entity);
            if (autoSave)
                DataBaseConnection.SaveChanges();

            return entity;
        }

        public async Task<TEntity> CreateAsync(TEntity entity, bool autoSave = true)
        {
            Table.Add(entity);
            if (autoSave)
               await DataBaseConnection.SaveChangesAsync();

            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public IQueryable<TEntity> GetAllSkipAndTake(int skip, int take)
        {
            return Table.Skip(skip).Take(take);
        }

        public TEntity Update(TEntity entity, bool autoSave = true)
        {
            if (entity == null)
            {
                return null;
            }
            TEntity exist = Table.Find(entity);
            if (exist != null)
            {
                DataBaseConnection.Entry(exist).CurrentValues.SetValues(entity);
                if (autoSave)
                {
                    DataBaseConnection.SaveChanges();
                }
            }

            return exist;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, bool autoSave = true)
        {
            if (entity == null)
            {
                return null;
            }
            TEntity exist = Table.Find(entity);
            if (exist != null)
            {
                DataBaseConnection.Entry(exist).CurrentValues.SetValues(entity);
                if (autoSave)
                {
                    await DataBaseConnection.SaveChangesAsync();
                }
            }

            return exist;
        }
        
        public TEntity Delete(TEntity entity, bool autoSave = true)
        {
            if (entity == null)
            {
                return null;
            }
            TEntity exist = Table.Find(entity);
            if (exist != null)
            {
                DataBaseConnection.Entry(exist).State = EntityState.Deleted;
                if (autoSave)
                {
                    DataBaseConnection.SaveChanges();
                }
            }

            return exist;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity, bool autoSave = true)
        {
            if (entity == null)
            {
                return null;
            }
            TEntity exist = Table.Find(entity);
            if (exist != null)
            {
                DataBaseConnection.Entry(exist).CurrentValues.SetValues(entity);
                if (autoSave)
                {
                    await DataBaseConnection.SaveChangesAsync();
                }
            }

            return exist;
        }
    }
}
