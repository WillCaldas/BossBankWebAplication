using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BossBank.Data.Entities
{
    public class Colaborador
    {
        public int ColaboradorId { get; set; }
        public string ColaboradorNome { get; set; }
        public string ColaboradorCPF { get; set; }
        public string ColaboradorCargo { get; set; }
        public string ColaboradorSetor { get; set; }
        public string ColaboradorGestor { get; set; }
        public string ColaboradorSalario { get; set; }

    }
}