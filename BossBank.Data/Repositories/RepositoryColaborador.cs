using BossBank.Data.Entities;
using BossBank.Data.Interfaces;

namespace BossBank.Data.Repositories
{
    public class RepositoryColaborador : RepositoryBase<Colaborador>, IRepositoryColaborador
    {
        public RepositoryColaborador(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}
