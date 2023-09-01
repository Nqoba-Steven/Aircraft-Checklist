using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NAC_Aircraft_Checklist.Migrations
{
    /// <inheritdoc />
    public partial class ServerMigration8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "B1900Entries");

            migrationBuilder.EnsureSchema(
                name: "B1900ProofRead");

            migrationBuilder.EnsureSchema(
                name: "B1900Proofs");

            migrationBuilder.EnsureSchema(
                name: "LearjetEntries");

            migrationBuilder.EnsureSchema(
                name: "LearjetProofRead");

            migrationBuilder.EnsureSchema(
                name: "LearjetProofs");

            migrationBuilder.EnsureSchema(
                name: "B1900MasterList");

            migrationBuilder.EnsureSchema(
                name: "LearjetMasterList");

            migrationBuilder.EnsureSchema(
                name: "Revisions");

            migrationBuilder.EnsureSchema(
                name: "Email");

            migrationBuilder.EnsureSchema(
                name: "Errors");

            migrationBuilder.EnsureSchema(
                name: "EmailLog");

            migrationBuilder.CreateTable(
                name: "AdditionalItems",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalItems",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIfApplicableFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusQTYFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ItemNameFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalItems",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalItems",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalItems",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIfApplicableFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusQTYFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ItemNameFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalItems",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftFlipFile",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftFlipFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftFlipFile",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftFlipFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftFlipFile",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIfApplicableFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusQTYFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftFlipFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftFlipFile",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftFlipFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftFlipFile",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftFlipFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftFlipFile",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftFlipFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftFlipFile",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIfApplicableFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusQTYFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftFlipFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AircraftFlipFile",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftFlipFile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reg = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseOfOperations = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => new { x.Id, x.Reg });
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B1900",
                schema: "Revisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevisionNumber = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B1900", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BaseManager",
                schema: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseManager", x => new { x.Id, x.EmailAddress });
                });

            migrationBuilder.CreateTable(
                name: "Cabin",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabin",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabin",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpiryDateFlagged = table.Column<bool>(type: "bit", nullable: false),
                    StatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabin",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabin",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QtyStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabin",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabin",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpiryDateFlagged = table.Column<bool>(type: "bit", nullable: false),
                    QtyStatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cabin",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QtyStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cockpit",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cockpit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cockpit",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cockpit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cockpit",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpiryDateFlagged = table.Column<bool>(type: "bit", nullable: false),
                    StatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cockpit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cockpit",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cockpit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cockpit",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cockpit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cockpit",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cockpit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cockpit",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpiryDateFlagged = table.Column<bool>(type: "bit", nullable: false),
                    StatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cockpit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cockpit",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cockpit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    CompletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseOfOperations = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entries",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    CompletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseOfOperations = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIfApplicableFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusQTYFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIfApplicableFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusQTYFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Errors",
                schema: "Errors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Errors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EscalationRecipients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EscalationRecipients", x => new { x.Id, x.EmailAddress });
                });

            migrationBuilder.CreateTable(
                name: "Escalations",
                schema: "EmailLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailRecipients = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escalations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exterior",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exterior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exterior",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exterior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exterior",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpiryDateFlagged = table.Column<bool>(type: "bit", nullable: false),
                    StatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exterior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exterior",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exterior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exterior",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exterior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exterior",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exterior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exterior",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exterior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exterior",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exterior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpiryDateFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusQTYFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpiryDateFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatuslagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interior",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interior",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interior",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interior",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interior",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interior",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interior",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interior",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interior", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Learjet",
                schema: "Revisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevisionNumber = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Learjet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    PublicationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    VolumeNumber = table.Column<int>(type: "int", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicationNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    VolumeNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    SetNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    DocumentFormatFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    PublicationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    VolumeNumber = table.Column<int>(type: "int", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    PublicationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    VolumeNumber = table.Column<int>(type: "int", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicationNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    VolumeNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    SetNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    DocumentFormatFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manuals",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    PublicationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    VolumeNumber = table.Column<int>(type: "int", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualsEFB",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    PublicationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumeNumber = table.Column<int>(type: "int", nullable: false),
                    SetNumberFO = table.Column<int>(type: "int", nullable: false),
                    SetNumberPIC = table.Column<int>(type: "int", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualsEFB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualsEFB",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualsEFB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualsEFB",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicationNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    VolumeNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    SetNumberFOFlagged = table.Column<bool>(type: "bit", nullable: false),
                    SetNumberPICFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualsEFB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualsEFB",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    PublicationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumeNumber = table.Column<int>(type: "int", nullable: false),
                    SetNumberFO = table.Column<int>(type: "int", nullable: false),
                    SetNumberPIC = table.Column<int>(type: "int", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualsEFB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualsIPad",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    PublicationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    VolumeNumber = table.Column<int>(type: "int", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualsIPad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualsIPad",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualsIPad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualsIPad",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicationNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    VolumeNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    SetNumberFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    DocumentFormatFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualsIPad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManualsIPad",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    PublicationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    VolumeNumber = table.Column<int>(type: "int", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualsIPad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationDocuments",
                schema: "B1900Entries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationDocuments",
                schema: "B1900MasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationDocuments",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIfApplicableFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationDocuments",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationDocumentsEquipment",
                schema: "LearjetEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationDocumentsEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationDocumentsEquipment",
                schema: "LearjetMasterList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    Descr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationDocumentsEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationDocumentsEquipment",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateIfApplicableFlagged = table.Column<bool>(type: "bit", nullable: false),
                    RevStatusQTYFlagged = table.Column<bool>(type: "bit", nullable: false),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    ProofReadId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationDocumentsEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationDocumentsEquipment",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryId = table.Column<int>(type: "int", nullable: false),
                    DescriptionId = table.Column<int>(type: "int", nullable: false),
                    ProofID = table.Column<int>(type: "int", nullable: false),
                    DateIfApplicable = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevStatusQTY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationDocumentsEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planner",
                schema: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planner", x => new { x.Id, x.EmailAddress });
                });

            migrationBuilder.CreateTable(
                name: "ProofRead",
                schema: "B1900ProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProofRead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProofRead",
                schema: "LearjetProofRead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProofId = table.Column<int>(type: "int", nullable: false),
                    EntryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProofRead", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proofs",
                schema: "B1900Proofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proofs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proofs",
                schema: "EmailLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UploadedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailRecipients = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proofs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proofs",
                schema: "LearjetProofs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proofs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                schema: "EmailLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailRecipients = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Revisions",
                schema: "EmailLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UploadedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Revision = table.Column<int>(type: "int", nullable: false),
                    AircraftType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailRecipients = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uploads",
                schema: "EmailLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UploadedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailRecipients = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uploads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UploadWaitList",
                schema: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadWaitList", x => new { x.Id, x.EmailAddress });
                });

            migrationBuilder.CreateTable(
                name: "Welcome",
                schema: "EmailLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailRecipients = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Welcome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalItems",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "AdditionalItems",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "AdditionalItems",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "AdditionalItems",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "AdditionalItems",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "AdditionalItems",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "AircraftFlipFile",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "AircraftFlipFile",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "AircraftFlipFile",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "AircraftFlipFile",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "AircraftFlipFile",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "AircraftFlipFile",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "AircraftFlipFile",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "AircraftFlipFile",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "Aircrafts");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "B1900",
                schema: "Revisions");

            migrationBuilder.DropTable(
                name: "BaseManager",
                schema: "Email");

            migrationBuilder.DropTable(
                name: "Cabin",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "Cabin",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "Cabin",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "Cabin",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "Cabin",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "Cabin",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "Cabin",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "Cabin",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "Cockpit",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "Cockpit",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "Cockpit",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "Cockpit",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "Cockpit",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "Cockpit",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "Cockpit",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "Cockpit",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "Entries",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "Entries",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "Equipment",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "Equipment",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "Equipment",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "Equipment",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "Equipment",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "Equipment",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "Equipment",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "Equipment",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "Errors",
                schema: "Errors");

            migrationBuilder.DropTable(
                name: "EscalationRecipients");

            migrationBuilder.DropTable(
                name: "Escalations",
                schema: "EmailLog");

            migrationBuilder.DropTable(
                name: "Exterior",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "Exterior",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "Exterior",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "Exterior",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "Exterior",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "Exterior",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "Exterior",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "Exterior",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "Flight",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "Interior",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "Interior",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "Interior",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "Interior",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "Interior",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "Interior",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "Interior",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "Interior",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "Learjet",
                schema: "Revisions");

            migrationBuilder.DropTable(
                name: "Manuals",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "Manuals",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "Manuals",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "Manuals",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "Manuals",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "Manuals",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "Manuals",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "Manuals",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "ManualsEFB",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "ManualsEFB",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "ManualsEFB",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "ManualsEFB",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "ManualsIPad",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "ManualsIPad",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "ManualsIPad",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "ManualsIPad",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "OperationDocuments",
                schema: "B1900Entries");

            migrationBuilder.DropTable(
                name: "OperationDocuments",
                schema: "B1900MasterList");

            migrationBuilder.DropTable(
                name: "OperationDocuments",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "OperationDocuments",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "OperationDocumentsEquipment",
                schema: "LearjetEntries");

            migrationBuilder.DropTable(
                name: "OperationDocumentsEquipment",
                schema: "LearjetMasterList");

            migrationBuilder.DropTable(
                name: "OperationDocumentsEquipment",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "OperationDocumentsEquipment",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "Planner",
                schema: "Email");

            migrationBuilder.DropTable(
                name: "ProofRead",
                schema: "B1900ProofRead");

            migrationBuilder.DropTable(
                name: "ProofRead",
                schema: "LearjetProofRead");

            migrationBuilder.DropTable(
                name: "Proofs",
                schema: "B1900Proofs");

            migrationBuilder.DropTable(
                name: "Proofs",
                schema: "EmailLog");

            migrationBuilder.DropTable(
                name: "Proofs",
                schema: "LearjetProofs");

            migrationBuilder.DropTable(
                name: "Reminders",
                schema: "EmailLog");

            migrationBuilder.DropTable(
                name: "Revisions",
                schema: "EmailLog");

            migrationBuilder.DropTable(
                name: "Uploads",
                schema: "EmailLog");

            migrationBuilder.DropTable(
                name: "UploadWaitList",
                schema: "Email");

            migrationBuilder.DropTable(
                name: "Welcome",
                schema: "EmailLog");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
