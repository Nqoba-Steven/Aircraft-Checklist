using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NAC_Aircraft_Checklist.Migrations
{
    /// <inheritdoc />
    public partial class B1900IPadManuals : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentFormat",
                schema: "B1900Proofs",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "DocumentFormat",
                schema: "B1900Entries",
                table: "ManualsIPad");

            migrationBuilder.RenameColumn(
                name: "SetNumber",
                schema: "B1900Proofs",
                table: "ManualsIPad",
                newName: "SetNumberPIC");

            migrationBuilder.RenameColumn(
                name: "SetNumberFlagged",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                newName: "SetNumberPICFlagged");

            migrationBuilder.RenameColumn(
                name: "DocumentFormatFlagged",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                newName: "SetNumberFOFlagged");

            migrationBuilder.RenameColumn(
                name: "SetNumber",
                schema: "B1900Entries",
                table: "ManualsIPad",
                newName: "SetNumberPIC");

            migrationBuilder.AddColumn<int>(
                name: "SetNumberFO",
                schema: "B1900Proofs",
                table: "ManualsIPad",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SetNumberFO",
                schema: "B1900Entries",
                table: "ManualsIPad",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SetNumberFO",
                schema: "B1900Proofs",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "SetNumberFO",
                schema: "B1900Entries",
                table: "ManualsIPad");

            migrationBuilder.RenameColumn(
                name: "SetNumberPIC",
                schema: "B1900Proofs",
                table: "ManualsIPad",
                newName: "SetNumber");

            migrationBuilder.RenameColumn(
                name: "SetNumberPICFlagged",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                newName: "SetNumberFlagged");

            migrationBuilder.RenameColumn(
                name: "SetNumberFOFlagged",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                newName: "DocumentFormatFlagged");

            migrationBuilder.RenameColumn(
                name: "SetNumberPIC",
                schema: "B1900Entries",
                table: "ManualsIPad",
                newName: "SetNumber");

            migrationBuilder.AddColumn<string>(
                name: "DocumentFormat",
                schema: "B1900Proofs",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DocumentFormat",
                schema: "B1900Entries",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
