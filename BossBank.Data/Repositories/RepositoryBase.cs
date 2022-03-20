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
        protected BossBankDbContext _BossBankContexto;
        

        public RepositoryBase(BossBankDbContext context)
        {
            
            _BossBankContexto = context;
        }

        public T Add(T item)
        {
            _BossBankContexto.Set<T>().Add(item);

            
                _BossBankContexto.SaveChanges();
            

            return item;
        }

        public void Delete(T item)
        {
            _BossBankContexto.Set<T>().Remove(item);

            _BossBankContexto.SaveChanges();
        }

        public void Delete(params object[] varT)
        {
            var obj = GetPk(varT);
            Delete(obj);
        }

        public void Dispose()
        {
            _BossBankContexto.Dispose();
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_BossBankContexto != null)
                {
                    _BossBankContexto.Dispose();
                    _BossBankContexto = null;
                }
            }
        }

        public List<T> GetAll()
        {
            return _BossBankContexto.Set<T>().ToList();
        }

        public T GetPk(params object[] varT)
        {
            return _BossBankContexto.Set<T>().Find(varT);
        }

        public void SaveChanges()
        {
            _BossBankContexto.SaveChanges();
        }

        public T Update(T item)
        {
            _BossBankContexto.Entry(item).State = EntityState.Modified;

            _BossBankContexto.SaveChanges();
            return item;
        }
    }
}
