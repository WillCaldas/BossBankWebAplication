using BossBank.Data.Entities;
using BossBank.Data.Interfaces;

namespace BossBank.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}
