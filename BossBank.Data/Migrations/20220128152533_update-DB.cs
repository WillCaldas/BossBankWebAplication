using Microsoft.EntityFrameworkCore.Migrations;

namespace BossBank.Data.Migrations
{
    public partial class updateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id_cliente = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nome_cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cpf_cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tel_cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email_cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    empre_cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CNPJ_cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    func_cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    sal_cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    rua_cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    bairro_cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cidade_cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    estado_cliente = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    id_colab = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nome_colab = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cpf_colab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    cargo_colab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    setor_colab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gestor_colab = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    salario_colab = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.id_colab);
                });

            migrationBuilder.CreateTable(
                name: "ContaCorrente",
                columns: table => new
                {
                    conta_cc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    agencia_cc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitularCcIdCliente = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GerenteCcIdColab = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    saldo_cc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    credito_cc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaCorrente", x => x.conta_cc);
                    table.ForeignKey(
                        name: "FK_ContaCorrente_Cliente_TitularCcIdCliente",
                        column: x => x.TitularCcIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "id_cliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContaCorrente_Colaborador_GerenteCcIdColab",
                        column: x => x.GerenteCcIdColab,
                        principalTable: "Colaborador",
                        principalColumn: "id_colab",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContaCorrente_GerenteCcIdColab",
                table: "ContaCorrente",
                column: "GerenteCcIdColab");

            migrationBuilder.CreateIndex(
                name: "IX_ContaCorrente_TitularCcIdCliente",
                table: "ContaCorrente",
                column: "TitularCcIdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaCorrente");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Colaborador");
        }
    }
}
