using BossBank.Data.Context;
using BossBank.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BossBank.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected BossBankDbContext _context;
        

        public RepositoryBase(BossBankDbContext context)
        {
            
            _context = context;
        }

        public T Add(T item)
        {
            _context.Set<T>().Add(item);

            
                _context.SaveChanges();
            

            return item;
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);

            _context.SaveChanges();
        }

        public void Delete(params object[] varT)
        {
            var obj = GetPk(varT);
            Delete(obj);
        }

        public void Dispose()
        {
            _context.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetPk(params object[] varT)
        {
            return _context.Set<T>().Find(varT);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public T Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;

            _context.SaveChanges();
            return item;
        }
    }
}
