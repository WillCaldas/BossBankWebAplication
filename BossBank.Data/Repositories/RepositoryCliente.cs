using BossBank.Data.Context;
using BossBank.Data.Entities;
using BossBank.Data.Interfaces;

namespace BossBank.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(BossBankDbContext context, bool saveChanges = true) : base(context, saveChanges)
        {

        }
    }
}
