using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BossBank.Data.Entities
{
    public partial class ContaCorrente
    {
        [Key]
        [Column("conta_cc")]
        public string ContaCc { get; set; }

        [Column("agencia_cc")]
        public string AgenciaCc { get; set; }

        [Column("titular_cc")]
        public Cliente TitularCc { get; set; }

        [Column("gerente_cc")]
        public Colaborador GerenteCc { get; set; }

        [Required]
        [Column("saldo_cc")]
        [StringLength(100)]
        public string SaldoCc { get; set; }

        [Column("credito_cc")]
        [StringLength(100)]
        public string CreditoCc { get; set; }
        
    }
}