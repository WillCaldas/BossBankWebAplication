using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BossBank.Data.Entities
{
    public partial class Cliente
    {
        [Key]
        [Column("id_cliente")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        [Required]
        [Column("nome_cliente")]
        [StringLength(100)]
        [DisplayName("Nome")]
        public string NomeCliente { get; set; }

        [Required]
        [Column("cpf_cliente")]
        [StringLength(50)]
        [DisplayName("CPF")]
        public string CpfCliente { get; set; }

        [Required]
        [Column("tel_cliente")]
        [StringLength(50)]
        [DisplayName("Telefone")]
        public string TelCliente { get; set; }

        [Required]
        [Column("email_cliente")]
        [StringLength(50)]
        [DisplayName("Email")]
        public string EmailCliente { get; set; }

        [Required]
        [Column("empre_cliente")]
        [StringLength(100)]
        [DisplayName("Empresa")]
        public string EmpreCliente { get; set; }

        [Required]
        [Column("CNPJ_cliente")]
        [StringLength(100)]
        [DisplayName("CNPJ")]
        public string CNPJCliente { get; set; }

        [Required]
        [Column("func_cliente")]
        [StringLength(100)]
        [DisplayName("Função")]
        public string FunCliente { get; set; }

        [Required]
        [Column("sal_cliente")]
        [StringLength(100)]
        [DisplayName("Salario")]
        public string SalarioCliente { get; set; }

        [Required]
        [Column("rua_cliente")]
        [StringLength(100)]
        [DisplayName("Rua")]
        public string RuaCliente { get; set; }

        [Required]
        [Column("bairro_cliente")]
        [StringLength(50)]
        [DisplayName("Bairro")]
        public string BairroCliente { get; set; }

        [Required]
        [Column("cidade_cliente")]
        [StringLength(50)]
        [DisplayName("Cidade")]
        public string CidadeCliente { get; set; }

        [Required]
        [Column("estado_cliente")]
        [StringLength(50)]
        [DisplayName("Estado")]
        public string EstadoCliente { get; set; }
    }
}