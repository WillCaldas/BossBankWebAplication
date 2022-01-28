using BossBank.Data.Entities;
using BossBank.Data.Interfaces;

namespace BossBank.Data.Repositories
{
    public class RepositoryContaCorrente : RepositoryBase<ContaCorrente>, IRepositoryContaCorrente
    {
        public RepositoryContaCorrente(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}
