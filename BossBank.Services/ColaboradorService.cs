using BossBank.Data.Context;
using BossBank.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBank.Data.Services
{
    public class ColaboradorService
    {
        public RepositoryColaborador RepColab { get; set; }

        public ColaboradorService(BossBankDbContext context)
        {
            RepColab = new RepositoryColaborador(context);
        }
    }
}
