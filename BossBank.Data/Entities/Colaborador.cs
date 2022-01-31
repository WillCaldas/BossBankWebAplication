using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BossBank.Data.Entities
{
    public partial class Colaborador
    {
        [Key]
        [Column("id_colab")]
        [DisplayName("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdColab { get; set; }

        [Required]
        [Column("nome_colab")]
        [StringLength(100)]
        [DisplayName("Nome")]
        public string NomeColab { get; set; }

        [Required]
        [Column("cpf_colab")]
        [StringLength(50)]
        [DisplayName("CPF")]
        public string CpfColab { get; set; }

        [Required]
        [Column("cargo_colab")]
        [StringLength(50)]
        [DisplayName("Função")]
        public string CargoColab { get; set; }

        [Required]
        [Column("setor_colab")]
        [StringLength(50)]
        [DisplayName("Setor")]
        public string SetorColab { get; set; }

        [Required]
        [Column("gestor_colab")]
        [StringLength(50)]
        [DisplayName("Gestor")]
        public string GestorColab { get; set; }

        [Required]
        [Column("salario_colab")]
        [StringLength(100)]
        [DisplayName("Salário")]
        public string SalarioColab { get; set; }

    }
}