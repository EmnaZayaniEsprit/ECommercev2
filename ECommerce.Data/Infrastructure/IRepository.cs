﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Infrastructure
{
    public interface IRepository<T> where T : class 
    { 
        void Add(T entity);
        void Update(T entity); 
        void Delete(T entity); 
        void Delete(Expression<Func<T, bool>> where); 
        T GetById(long Id); T GetById(string Id); 
        T Get(Expression<Func<T, bool>> where); 
        IEnumerable<T> GetAll(); 
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
    }
}