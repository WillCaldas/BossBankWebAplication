using BossBank.Data.Interfaces;
using BossBank.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBank.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected BossbankDBContext _BossBankContexto;
        public bool _SaveChanges = true;

        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _BossBankContexto = new BossbankDBContext();
        }

        public T Add(T item)
        {
            _BossBankContexto.Set<T>().Add(item);

            if (_SaveChanges)
            {
                _BossBankContexto.SaveChanges();
            }

            return item;
        }

        public void Delete(T item)
        {
            _BossBankContexto.Set<T>().Remove(item);

            if (_SaveChanges)
            {
                _BossBankContexto.SaveChanges();
            }
        }

        public void Delete(params object[] varT)
        {
            var obj = GetPk(varT);
            Delete(obj);
        }

        public void Dispose()
        {
            _BossBankContexto.Dispose();
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

            if (_SaveChanges)
            {
                _BossBankContexto.SaveChanges();
            }
            return item;
        }
    }
}
