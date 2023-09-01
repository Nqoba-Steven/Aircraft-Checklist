using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NAC_Aircraft_Checklist.Migrations
{
    /// <inheritdoc />
    public partial class ProofReadUpdateLearjet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RevStatusQTYFlagged",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment",
                newName: "RevTextFlagged");

            migrationBuilder.RenameColumn(
                name: "RevStatuslagged",
                schema: "LearjetProofRead",
                table: "Flight",
                newName: "RevTextFlagged");

            migrationBuilder.RenameColumn(
                name: "QtyStatusFlagged",
                schema: "LearjetProofRead",
                table: "Cabin",
                newName: "StatusFlagged");

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIfApplicable",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatus",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevStatusFlagged",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "OperationDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIfApplicable",
                schema: "B1900ProofRead",
                table: "OperationDocuments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatus",
                schema: "B1900ProofRead",
                table: "OperationDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "OperationDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicationNumber",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatus",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SetNumberFO",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SetNumberPIC",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolumeNumber",
                schema: "B1900ProofRead",
                table: "ManualsIPad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VolumeNumber",
                schema: "LearjetProofs",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SetNumberPIC",
                schema: "LearjetProofs",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SetNumberFO",
                schema: "LearjetProofs",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicationNumber",
                schema: "LearjetProofRead",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatus",
                schema: "LearjetProofRead",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "ManualsEFB",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SetNumberFO",
                schema: "LearjetProofRead",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SetNumberPIC",
                schema: "LearjetProofRead",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolumeNumber",
                schema: "LearjetProofRead",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VolumeNumber",
                schema: "LearjetEntries",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SetNumberPIC",
                schema: "LearjetEntries",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SetNumberFO",
                schema: "LearjetEntries",
                table: "ManualsEFB",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VolumeNumber",
                schema: "LearjetProofs",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SetNumber",
                schema: "LearjetProofs",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentFormat",
                schema: "LearjetProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicationNumber",
                schema: "LearjetProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatus",
                schema: "LearjetProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Manuals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SetNumber",
                schema: "LearjetProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolumeNumber",
                schema: "LearjetProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VolumeNumber",
                schema: "LearjetEntries",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SetNumber",
                schema: "LearjetEntries",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentFormat",
                schema: "B1900ProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicationNumber",
                schema: "B1900ProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatus",
                schema: "B1900ProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SetNumber",
                schema: "B1900ProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolumeNumber",
                schema: "B1900ProofRead",
                table: "Manuals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Interior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Interior",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Interior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Interior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Interior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                schema: "LearjetProofRead",
                table: "Flight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevStatusQTYFlagged",
                schema: "LearjetProofRead",
                table: "Flight",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "LearjetProofRead",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                schema: "B1900ProofRead",
                table: "Flight",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "B1900ProofRead",
                table: "Flight",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Exterior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Exterior",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Exterior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Exterior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Exterior",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIfApplicable",
                schema: "LearjetProofRead",
                table: "Equipment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatusQTY",
                schema: "LearjetProofRead",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Equipment",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIfApplicable",
                schema: "B1900ProofRead",
                table: "Equipment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatusQTY",
                schema: "B1900ProofRead",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                schema: "LearjetProofs",
                table: "Cockpit",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                schema: "LearjetProofRead",
                table: "Cockpit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Cockpit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "LearjetProofRead",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                schema: "LearjetEntries",
                table: "Cockpit",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                schema: "B1900ProofRead",
                table: "Cockpit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "B1900ProofRead",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                schema: "LearjetProofs",
                table: "Cabin",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                schema: "LearjetProofRead",
                table: "Cabin",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Cabin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "LearjetProofRead",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiryDate",
                schema: "LearjetEntries",
                table: "Cabin",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryDate",
                schema: "B1900ProofRead",
                table: "Cabin",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                schema: "B1900ProofRead",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIfApplicable",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatusQTY",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIfApplicable",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatusQTY",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIfApplicable",
                schema: "LearjetProofRead",
                table: "AdditionalItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                schema: "LearjetProofRead",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatusQTY",
                schema: "LearjetProofRead",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "AdditionalItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateIfApplicable",
                schema: "B1900ProofRead",
                table: "AdditionalItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                schema: "B1900ProofRead",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevStatusQTY",
                schema: "B1900ProofRead",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "AdditionalItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment");

            migrationBuilder.DropColumn(
                name: "DateIfApplicable",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment");

            migrationBuilder.DropColumn(
                name: "RevStatus",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment");

            migrationBuilder.DropColumn(
                name: "RevStatusFlagged",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "OperationDocuments");

            migrationBuilder.DropColumn(
                name: "DateIfApplicable",
                schema: "B1900ProofRead",
                table: "OperationDocuments");

            migrationBuilder.DropColumn(
                name: "RevStatus",
                schema: "B1900ProofRead",
                table: "OperationDocuments");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "OperationDocuments");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "PublicationNumber",
                schema: "B1900ProofRead",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "RevStatus",
                schema: "B1900ProofRead",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "SetNumberFO",
                schema: "B1900ProofRead",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "SetNumberPIC",
                schema: "B1900ProofRead",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "VolumeNumber",
                schema: "B1900ProofRead",
                table: "ManualsIPad");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "PublicationNumber",
                schema: "LearjetProofRead",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "RevStatus",
                schema: "LearjetProofRead",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "SetNumberFO",
                schema: "LearjetProofRead",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "SetNumberPIC",
                schema: "LearjetProofRead",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "VolumeNumber",
                schema: "LearjetProofRead",
                table: "ManualsEFB");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "DocumentFormat",
                schema: "LearjetProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "PublicationNumber",
                schema: "LearjetProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevStatus",
                schema: "LearjetProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "SetNumber",
                schema: "LearjetProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "VolumeNumber",
                schema: "LearjetProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "DocumentFormat",
                schema: "B1900ProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "PublicationNumber",
                schema: "B1900ProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevStatus",
                schema: "B1900ProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "SetNumber",
                schema: "B1900ProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "VolumeNumber",
                schema: "B1900ProofRead",
                table: "Manuals");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Interior");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "LearjetProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "RevStatusQTYFlagged",
                schema: "LearjetProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "LearjetProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "B1900ProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "B1900ProofRead",
                table: "Flight");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Exterior");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "DateIfApplicable",
                schema: "LearjetProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevStatusQTY",
                schema: "LearjetProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "DateIfApplicable",
                schema: "B1900ProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevStatusQTY",
                schema: "B1900ProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "LearjetProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "LearjetProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "B1900ProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "B1900ProofRead",
                table: "Cockpit");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "LearjetProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "LearjetProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "B1900ProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "Status",
                schema: "B1900ProofRead",
                table: "Cabin");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "DateIfApplicable",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevStatusQTY",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "DateIfApplicable",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevStatusQTY",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "AircraftFlipFile");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "LearjetProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "DateIfApplicable",
                schema: "LearjetProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "ItemName",
                schema: "LearjetProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "RevStatusQTY",
                schema: "LearjetProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "LearjetProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "B1900ProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "DateIfApplicable",
                schema: "B1900ProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "ItemName",
                schema: "B1900ProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "RevStatusQTY",
                schema: "B1900ProofRead",
                table: "AdditionalItems");

            migrationBuilder.DropColumn(
                name: "RevisionText",
                schema: "B1900ProofRead",
                table: "AdditionalItems");

            migrationBuilder.RenameColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "OperationDocumentsEquipment",
                newName: "RevStatusQTYFlagged");

            migrationBuilder.RenameColumn(
                name: "RevTextFlagged",
                schema: "LearjetProofRead",
                table: "Flight",
                newName: "RevStatuslagged");

            migrationBuilder.RenameColumn(
                name: "StatusFlagged",
                schema: "LearjetProofRead",
                table: "Cabin",
                newName: "QtyStatusFlagged");

            migrationBuilder.AlterColumn<int>(
                name: "VolumeNumber",
                schema: "LearjetProofs",
                table: "ManualsEFB",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SetNumberPIC",
                schema: "LearjetProofs",
                table: "ManualsEFB",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SetNumberFO",
                schema: "LearjetProofs",
                table: "ManualsEFB",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VolumeNumber",
                schema: "LearjetEntries",
                table: "ManualsEFB",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SetNumberPIC",
                schema: "LearjetEntries",
                table: "ManualsEFB",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SetNumberFO",
                schema: "LearjetEntries",
                table: "ManualsEFB",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VolumeNumber",
                schema: "LearjetProofs",
                table: "Manuals",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SetNumber",
                schema: "LearjetProofs",
                table: "Manuals",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VolumeNumber",
                schema: "LearjetEntries",
                table: "Manuals",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SetNumber",
                schema: "LearjetEntries",
                table: "Manuals",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpiryDate",
                schema: "LearjetProofs",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpiryDate",
                schema: "LearjetEntries",
                table: "Cockpit",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpiryDate",
                schema: "LearjetProofs",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpiryDate",
                schema: "LearjetEntries",
                table: "Cabin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
