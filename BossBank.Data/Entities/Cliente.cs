using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BossBank.Data.Entities
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteCPF { get; set; }
        public string ClienteTel { get; set; }
        public string ClienteEmail { get; set; }
        public string ClienteEmpre { get; set; }
        public string ClienteCNPJ { get; set; }
        public string ClienteFunc { get; set; }
        public double ClienteSalario { get; set; }
        public string ClienteRua { get; set; }
        public string ClienteBairro { get; set; }
        public string ClienteCidade { get; set; }
        public string ClienteEstado { get; set; }
    }
}