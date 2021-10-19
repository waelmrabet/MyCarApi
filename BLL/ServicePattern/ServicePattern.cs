﻿using Core.Models;
using Data.Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.ServicePattern
{
    public class ServicePattern<T> : IServicePattern<T> where T : BaseEntity
    {

        private readonly IRepository<T> _repo;
        public ServicePattern(IRepository<T> repository)
        {
            _repo = repository;
        }
        public void Delete(int id)
        {
            _repo.Delete(id);
        }
        public IEnumerable<T> GetAll()
        {
            return _repo.GetAll();
        }
        public T GetById(int id)
        {
            return _repo.GetById(id);
        }
        public void Insert(T entity)
        {
            _repo.Insert(entity);
        }
        public void InsertAll(IEnumerable<T> ts)
        {
            _repo.Insert(ts);
        }
        public void Update(T entity)
        {
            _repo.Update(entity);
        }
        public void UpdateAll(IEnumerable<T> ts)
        {
            _repo.Update(ts);
        }
        public void RollBack()
        {
            _repo.RollBack();
        }
        public void Commit()
        {
            _repo.Commit();
        }
    
    }

}
