using BossBank.Data.Context;
using BossBank.Data.Entities;
using BossBank.Data.Interfaces;

namespace BossBank.Data.Repositories
{
    public class RepositoryColaborador : RepositoryBase<Colaborador>, IRepositoryColaborador
    {
        public RepositoryColaborador(BossBankDbContext context, bool saveChanges = true) : base(context, saveChanges)
        {

        }
    }
}
