using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BossBank.Data.Entities
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public string ContaCc { get; set; }
        public string AgenciaCc { get; set; }
        public Cliente TitularCc { get; set; }
        public Colaborador GerenteCc { get; set; }
        public string SaldoCc { get; set; }
        public string CreditoCc { get; set; }

    }
}