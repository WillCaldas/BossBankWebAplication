using BossBank.Data.Interfaces;
using BossBank.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBank.Data.Repositories
{
    public class RepositoryContaCorrente : RepositoryBase<ContaCorrente>, IRepositoryContaCorrente
    {
        public RepositoryContaCorrente(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}
