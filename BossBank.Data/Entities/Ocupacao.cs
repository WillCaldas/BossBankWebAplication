using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossBank.Data.Entities
{
    public class Ocupacao
    {
        public int Id { get; set; }
        public string Funcao { get; set; }
        public double Salario { get; set; }
        public string Empresa { get; set; }
        public string CNPJ { get; set; }
        public Cliente Cliente { get; set; }
    }
}
