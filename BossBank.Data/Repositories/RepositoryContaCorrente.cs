using BossBank.Data.Context;
using BossBank.Data.Entities;
using BossBank.Data.Interfaces;

namespace BossBank.Data.Repositories
{
    public class RepositoryContaCorrente : RepositoryBase<ContaCorrente>, IRepositoryContaCorrente
    {
        public RepositoryContaCorrente(BossBankDbContext context) : base(context)
        {

        }
    }
}
