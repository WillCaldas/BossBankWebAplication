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
        public string Conta { get; set; }
        public string Agencia { get; set; }
        public int ClienteId { get; set; }
        public Cliente ClienteTitular { get; set; }
        public int GerenteId { get; set; }
        public Gerente Gerente { get; set; }
        public string Saldo { get; set; }
        public string Credito { get; set; }

    }
}