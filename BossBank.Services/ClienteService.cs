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

        public ClienteService()
        {
            RepCliente = new RepositoryCliente();
        }
    }
}
