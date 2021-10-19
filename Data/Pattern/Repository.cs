using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Pattern
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly MyDataBaseContext context;
        private DbSet<T> _entities;
        public DbSet<T> Entities
        {
            get
            {
                return this._entities;
            }
        }

        string errorMessage = string.Empty;

        public Repository(MyDataBaseContext context)
        {
            this.context = context;
            _entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
        public T GetById(int id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            _entities.Add(entity);
            //context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            //context.SaveChanges();
        }
        public void Delete(int id)
        {
            T entity = _entities.SingleOrDefault(s => s.Id == id);
            _entities.Remove(entity);
        }

        public void Insert(IEnumerable<T> ts)
        {
            if (ts == null) throw new ArgumentNullException("TEntities");

            _entities.AddRange(ts);
        }

        public void Update(IEnumerable<T> ts)
        {
            if (ts == null) throw new ArgumentNullException("TEntities");

            _entities.UpdateRange(ts);
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void RollBack()
        {
            context.Dispose();
        }
    }
}

