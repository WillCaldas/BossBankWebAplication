using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBank.Data.Entities
{
    public class Gerente : Colaborador
    {
        public List<ContaCorrente> ContaCorrentes { get; set; }
    }
}
