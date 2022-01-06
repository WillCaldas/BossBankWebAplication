using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBank.Data.Interfaces
{
    internal interface IRepositoryModel<T> where T : class
    {
        List<T> GetAll();
        T GetPk(params object[] varT);
        T Add(T item);
        T Update(T item);
        void Delete(T item);
        void Delete(params object[] varT);
        void SaveChanges();
    }
}

namespace BossBank.Data
{
    public class IReposirotyModel
    {
    }
}