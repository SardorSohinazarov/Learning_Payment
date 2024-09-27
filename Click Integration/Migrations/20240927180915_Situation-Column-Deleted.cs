using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Click_Integration.Migrations
{
    /// <inheritdoc />
    public partial class SituationColumnDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situation",
                table: "ClickTransactions");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "ClickTransactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ClickTransactions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Situation",
                table: "ClickTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
