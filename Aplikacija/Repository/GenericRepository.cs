using Aplikacija.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Aplikacija.Repository
{
        public class GenericRepository<Tbl_Entity> : IRepository<Tbl_Entity> where Tbl_Entity : class
        {
            DbSet<Tbl_Entity> _dbSet;

            private ProdajaKamionaEntities _DBEntity;

            public GenericRepository(ProdajaKamionaEntities DBEntity)
            {
                _DBEntity = DBEntity;
                _dbSet = _DBEntity.Set<Tbl_Entity>();
            }

            public void Add(Tbl_Entity entity)
            {
                _dbSet.Add(entity);
                _DBEntity.SaveChanges();
            }

            public int GetAllrecordCount()
            {
                return _dbSet.Count();
            }

            public IEnumerable<Tbl_Entity> GetAllRecords()
            {
                return _dbSet.ToList();
            }

            public IQueryable<Tbl_Entity> GetAllRecordsIQueryable()
            {
                return _dbSet;
            }

            public Tbl_Entity GetFirstorDefault(int recordId)
            {
                return _dbSet.Find(recordId);
            }

            public void Remove(Tbl_Entity entity)
            {
                if (_DBEntity.Entry(entity).State == EntityState.Detached)
                    _dbSet.Attach(entity);
                _dbSet.Remove(entity);

            }

            public void Update(Tbl_Entity entity)
            {
                _dbSet.Attach(entity);
                _DBEntity.Entry(entity).State = EntityState.Modified;
                _DBEntity.SaveChanges();
            }

        public IEnumerable<Tbl_Entity> GetProduct()
        {
            return _dbSet.ToList();
        }

    }
    }
