using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NAC_Aircraft_Checklist.Migrations
{
    /// <inheritdoc />
    public partial class AddedRevisionText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "OperationDocumentsEquipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "OperationDocumentsEquipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "OperationDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "OperationDocuments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "OperationDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Manuals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Interior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Interior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Interior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Interior",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Interior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Flight",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Exterior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Exterior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Exterior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Exterior",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Exterior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Equipment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Cockpit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Cabin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "AdditionalItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "OperationDocumentsEquipment");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "OperationDocumentsEquipment");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "OperationDocuments");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "OperationDocuments");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "OperationDocuments");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofs",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetEntries",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Proofs",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "B1900ProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900Entries",
                table: "AdditionalItems");
        }
    }
}
