using Microsoft.EntityFrameworkCore.Migrations;

namespace api_codefirst.Migrations
{
    public partial class ManutencaoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_Endereco_EnderecoId",
                table: "Imoveis");

            migrationBuilder.DropForeignKey(
                name: "FK_Proprietario_Imoveis_ImovelId",
                table: "Proprietario");

            migrationBuilder.DropIndex(
                name: "IX_Proprietario_ImovelId",
                table: "Proprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "ImovelId",
                table: "Proprietario");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "enderecos_sistema");

            migrationBuilder.RenameColumn(
                name: "Uf",
                table: "enderecos_sistema",
                newName: "uf");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "enderecos_sistema",
                newName: "rua");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "enderecos_sistema",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "enderecos_sistema",
                newName: "complemento");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "enderecos_sistema",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "enderecos_sistema",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "enderecos_sistema",
                newName: "bairro");

            migrationBuilder.AlterColumn<string>(
                name: "uf",
                table: "enderecos_sistema",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rua",
                table: "enderecos_sistema",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "numero",
                table: "enderecos_sistema",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "complemento",
                table: "enderecos_sistema",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "enderecos_sistema",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bairro",
                table: "enderecos_sistema",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "referencia",
                table: "enderecos_sistema",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enderecos_sistema",
                table: "enderecos_sistema",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ImovelProprietario",
                columns: table => new
                {
                    ImoveisId = table.Column<int>(type: "int", nullable: false),
                    ProprietariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImovelProprietario", x => new { x.ImoveisId, x.ProprietariosId });
                    table.ForeignKey(
                        name: "FK_ImovelProprietario_Imoveis_ImoveisId",
                        column: x => x.ImoveisId,
                        principalTable: "Imoveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImovelProprietario_Proprietario_ProprietariosId",
                        column: x => x.ProprietariosId,
                        principalTable: "Proprietario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImovelProprietario_ProprietariosId",
                table: "ImovelProprietario",
                column: "ProprietariosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "enderecos_sistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imoveis_enderecos_sistema_EnderecoId",
                table: "Imoveis");

            migrationBuilder.DropTable(
                name: "ImovelProprietario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enderecos_sistema",
                table: "enderecos_sistema");

            migrationBuilder.DropColumn(
                name: "referencia",
                table: "enderecos_sistema");

            migrationBuilder.RenameTable(
                name: "enderecos_sistema",
                newName: "Endereco");

            migrationBuilder.RenameColumn(
                name: "uf",
                table: "Endereco",
                newName: "Uf");

            migrationBuilder.RenameColumn(
                name: "rua",
                table: "Endereco",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "Endereco",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "complemento",
                table: "Endereco",
                newName: "Complemento");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "Endereco",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Endereco",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "Endereco",
                newName: "Bairro");

            migrationBuilder.AddColumn<int>(
                name: "ImovelId",
                table: "Proprietario",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Uf",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Rua",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Proprietario_ImovelId",
                table: "Proprietario",
                column: "ImovelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imoveis_Endereco_EnderecoId",
                table: "Imoveis",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proprietario_Imoveis_ImovelId",
                table: "Proprietario",
                column: "ImovelId",
                principalTable: "Imoveis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
