﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BossBank.Data.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ContaCorrente = new HashSet<ContaCorrente>();
            ContaPoupanca = new HashSet<ContaPoupanca>();
        }

        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Required]
        [Column("nome_cliente")]
        [StringLength(100)]
        [System.ComponentModel.DisplayName("Nome")]
        public string NomeCliente { get; set; }
        [Required]
        [Column("cpf_cliente")]
        [StringLength(50)]
        [System.ComponentModel.DisplayName("CPF")]
        public string CpfCliente { get; set; }
        [Required]
        [Column("prof_cliente")]
        [StringLength(100)]
        [System.ComponentModel.DisplayName("Profisão")]
        public string ProfCliente { get; set; }
        [Required]
        [Column("renda_cliente")]
        [StringLength(100)]
        [System.ComponentModel.DisplayName("Renda")]
        public string RendaCliente { get; set; }
        [Required]
        [Column("end_cliente")]
        [StringLength(100)]
        [System.ComponentModel.DisplayName("Endereço")]
        public string EndCliente { get; set; }
        [Required]
        [Column("cidade_cliente")]
        [StringLength(50)]
        [System.ComponentModel.DisplayName("Cidade")]
        public string CidadeCliente { get; set; }

        [InverseProperty("TitularCcNavigation")]
        public virtual ICollection<ContaCorrente> ContaCorrente { get; set; }
        [InverseProperty("TitularCpNavigation")]
        public virtual ICollection<ContaPoupanca> ContaPoupanca { get; set; }
    }
}