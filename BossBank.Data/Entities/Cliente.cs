using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BossBank.Data.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public int OcupacaoId { get; set; }
        public Ocupacao Ocupacao { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}