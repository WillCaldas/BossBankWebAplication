using BossBank.Data.Context;
using BossBank.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBank.Data.Services
{
    public class ClienteService
    {
        public RepositoryCliente RepCliente { get; set; }

        public ClienteService(BossBankDbContext context)
        {
            RepCliente = new RepositoryCliente(context);
        }
    }
}
