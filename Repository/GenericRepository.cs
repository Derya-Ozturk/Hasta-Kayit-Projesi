﻿using OnlineCRF_ProjeIT.Abstract;
using OnlineCRF_ProjeIT.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace OnlineCRF_ProjeIT.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        readonly ProjeIT_DBContext c  = new ProjeIT_DBContext();

        readonly DbSet<T> _object;

        //ctor tab tab, yapıcı metodlar
        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public T Get(Expression<Func<T, int>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }



    }
}