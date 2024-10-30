using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SPMB_T._DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class createDbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AkCarta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DebitKredit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UmumDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baki = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EnJenis = table.Column<int>(type: "int", nullable: false),
                    EnParas = table.Column<int>(type: "int", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkCarta", x => x.Id);
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
                name: "ExceptionLogger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrlRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExceptionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExceptionMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExceptionStackTrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraceIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionLogger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JAgama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JAgama", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JBahagian",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JBahagian", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JBangsa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JBangsa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodBNMEFT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length1 = table.Column<int>(type: "int", nullable: false),
                    Length2 = table.Column<int>(type: "int", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JBank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JCaraBayar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLimit = table.Column<bool>(type: "bit", nullable: false),
                    MaksAmaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JCaraBayar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JCukai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnKategoriCukai = table.Column<int>(type: "int", nullable: false),
                    Peratus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KodItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JCukai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JElaunPotongan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JElaunPotongan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JKategoriPCB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JKategoriPCB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JKonfigPenyata",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JKonfigPenyata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JKW",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JKW", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JNegeri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JNegeri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JPTJ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JPTJ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LHDNKodKlasifikasi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LHDNKodKlasifikasi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LHDNMSIC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSICCategoryReference = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LHDNMSIC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LHDNUnitUkuran",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LHDNUnitUkuran", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiAppInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KodSistem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarVersi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NamaSyarikat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoPendaftaran = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlamatSyarikat1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlamatSyarikat2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlamatSyarikat3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bandar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poskod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Daerah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Negeri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelSyarikat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaksSyarikat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmelSyarikat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyLogoWeb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyLogoPrintPDF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlMaintainance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiAppInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuGajiBulanan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bulan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuGajiBulanan", x => x.Id);
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
                name: "JKonfigPenyataBaris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bil = table.Column<int>(type: "int", nullable: false),
                    JKonfigPenyataId = table.Column<int>(type: "int", nullable: false),
                    EnKategoriTajuk = table.Column<int>(type: "int", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Susunan = table.Column<int>(type: "int", nullable: false),
                    IsFormula = table.Column<bool>(type: "bit", nullable: false),
                    EnKategoriJumlah = table.Column<int>(type: "int", nullable: false),
                    JumlahSusunanList = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JKonfigPenyataBaris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JKonfigPenyataBaris_JKonfigPenyata_JKonfigPenyataId",
                        column: x => x.JKonfigPenyataId,
                        principalTable: "JKonfigPenyata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoAkaun = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JBankId = table.Column<int>(type: "int", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkBank_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkBank_JBank_JBankId",
                        column: x => x.JBankId,
                        principalTable: "JBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkBank_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JKonfigPerubahanEkuiti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnLajurJadual = table.Column<int>(type: "int", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: true),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JKonfigPerubahanEkuiti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JKonfigPerubahanEkuiti_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DDaftarAwam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JNegeriId = table.Column<int>(type: "int", nullable: true),
                    JBankId = table.Column<int>(type: "int", nullable: true),
                    NoPendaftaran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoKPLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poskod = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Bandar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Handphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NoAkaunBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnKategoriDaftarAwam = table.Column<int>(type: "int", nullable: false),
                    EnKategoriAhli = table.Column<int>(type: "int", nullable: false),
                    Faks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsBekalan = table.Column<bool>(type: "bit", nullable: false),
                    IsPerkhidmatan = table.Column<bool>(type: "bit", nullable: false),
                    IsKerja = table.Column<bool>(type: "bit", nullable: false),
                    JangkaMasaDari = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JangkaMasaHingga = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KodM2E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnJenisId = table.Column<int>(type: "int", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DDaftarAwam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DDaftarAwam_JBank_JBankId",
                        column: x => x.JBankId,
                        principalTable: "JBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DDaftarAwam_JNegeri_JNegeriId",
                        column: x => x.JNegeriId,
                        principalTable: "JNegeri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DPenerimaZakat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JNegeriId = table.Column<int>(type: "int", nullable: true),
                    JBankId = table.Column<int>(type: "int", nullable: true),
                    NoPendaftaran = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoKPLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poskod = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Bandar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Handphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NoAkaunBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnKategoriDaftarAwam = table.Column<int>(type: "int", nullable: false),
                    EnKategoriAhli = table.Column<int>(type: "int", nullable: false),
                    Faks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JangkaMasaDari = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JangkaMasaHingga = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KodM2E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnJenisId = table.Column<int>(type: "int", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPenerimaZakat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DPenerimaZakat_JBank_JBankId",
                        column: x => x.JBankId,
                        principalTable: "JBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPenerimaZakat_JNegeri_JNegeriId",
                        column: x => x.JNegeriId,
                        principalTable: "JNegeri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkAkaun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    JPTJId = table.Column<int>(type: "int", nullable: true),
                    JBahagianId = table.Column<int>(type: "int", nullable: true),
                    AkCarta1Id = table.Column<int>(type: "int", nullable: false),
                    AkCarta2Id = table.Column<int>(type: "int", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kredit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoSlip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarikhSlip = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPadan = table.Column<bool>(type: "bit", nullable: false),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkAkaun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkAkaun_AkCarta_AkCarta1Id",
                        column: x => x.AkCarta1Id,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkAkaun_AkCarta_AkCarta2Id",
                        column: x => x.AkCarta2Id,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkAkaun_JBahagian_JBahagianId",
                        column: x => x.JBahagianId,
                        principalTable: "JBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkAkaun_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkAkaun_JPTJ_JPTJId",
                        column: x => x.JPTJId,
                        principalTable: "JPTJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JKWPTJBahagian",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    JPTJId = table.Column<int>(type: "int", nullable: false),
                    JBahagianId = table.Column<int>(type: "int", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JKWPTJBahagian", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JKWPTJBahagian_JBahagian_JBahagianId",
                        column: x => x.JBahagianId,
                        principalTable: "JBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JKWPTJBahagian_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JKWPTJBahagian_JPTJ_JPTJId",
                        column: x => x.JPTJId,
                        principalTable: "JPTJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JKonfigPenyataBarisFormula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarisBil = table.Column<int>(type: "int", nullable: false),
                    JKonfigPenyataBarisId = table.Column<int>(type: "int", nullable: false),
                    EnJenisOperasi = table.Column<int>(type: "int", nullable: false),
                    IsPukal = table.Column<bool>(type: "bit", nullable: false),
                    EnJenisCartaList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsKecuali = table.Column<bool>(type: "bit", nullable: false),
                    KodList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetKodList = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JKonfigPenyataBarisFormula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JKonfigPenyataBarisFormula_JKonfigPenyataBaris_JKonfigPenyataBarisId",
                        column: x => x.JKonfigPenyataBarisId,
                        principalTable: "JKonfigPenyataBaris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkEFT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaFail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TarikhBayar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BilPenerima = table.Column<int>(type: "int", nullable: false),
                    Produk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnStatusEFT = table.Column<int>(type: "int", nullable: false),
                    AkBankId = table.Column<int>(type: "int", nullable: false),
                    JBankId = table.Column<int>(type: "int", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkEFT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkEFT_AkBank_AkBankId",
                        column: x => x.AkBankId,
                        principalTable: "AkBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkEFT_JBank_JBankId",
                        column: x => x.JBankId,
                        principalTable: "JBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JCawangan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkBankId = table.Column<int>(type: "int", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JCawangan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JCawangan_AkBank_AkBankId",
                        column: x => x.AkBankId,
                        principalTable: "AkBank",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "JKonfigPerubahanEkuitiBaris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JKonfigPerubahanEkuitiId = table.Column<int>(type: "int", nullable: false),
                    EnBaris = table.Column<int>(type: "int", nullable: false),
                    EnJenisOperasi = table.Column<int>(type: "int", nullable: false),
                    IsPukal = table.Column<bool>(type: "bit", nullable: false),
                    EnJenisCartaList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsKecuali = table.Column<bool>(type: "bit", nullable: false),
                    KodList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetKodList = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JKonfigPerubahanEkuitiBaris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JKonfigPerubahanEkuitiBaris_JKonfigPerubahanEkuiti_JKonfigPerubahanEkuitiId",
                        column: x => x.JKonfigPerubahanEkuitiId,
                        principalTable: "JKonfigPerubahanEkuiti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbBukuVot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    JPTJId = table.Column<int>(type: "int", nullable: false),
                    JBahagianId = table.Column<int>(type: "int", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: true),
                    VotId = table.Column<int>(type: "int", nullable: false),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kredit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tanggungan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tbs = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Baki = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rizab = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Liabiliti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Belanja = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbBukuVot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbBukuVot_AkCarta_VotId",
                        column: x => x.VotId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbBukuVot_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AbBukuVot_JBahagian_JBahagianId",
                        column: x => x.JBahagianId,
                        principalTable: "JBahagian",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AbBukuVot_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbBukuVot_JPTJ_JPTJId",
                        column: x => x.JPTJId,
                        principalTable: "JPTJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkAnggarLejar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Baki = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkAnggarLejar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkAnggarLejar_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkAnggarLejar_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkJanaanProfil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JCawanganId = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnJenisModulProfil = table.Column<int>(type: "int", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkJanaanProfil", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkJanaanProfil_JCawangan_JCawanganId",
                        column: x => x.JCawanganId,
                        principalTable: "JCawangan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DPanjar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: true),
                    JCawanganId = table.Column<int>(type: "int", nullable: false),
                    Catatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    HadJumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPanjar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DPanjar_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DPanjar_JCawangan_JCawanganId",
                        column: x => x.JCawanganId,
                        principalTable: "JCawangan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DPanjar_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DPekerja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoGaji = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodPekerja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoKp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoKpLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarikhLahir = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Alamat1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alamat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poskod = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    Bandar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JNegeriId = table.Column<int>(type: "int", nullable: false),
                    TelefonRumah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonBimbit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TarikhMasukKerja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TarikhBerhentiKerja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JBankId = table.Column<int>(type: "int", nullable: true),
                    JBangsaId = table.Column<int>(type: "int", nullable: true),
                    Jawatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoAkaunBank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    KodM2E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoCukai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoPerkeso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoKWAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoKWSP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JBahagianId = table.Column<int>(type: "int", nullable: false),
                    JCawanganId = table.Column<int>(type: "int", nullable: false),
                    JPTJId = table.Column<int>(type: "int", nullable: false),
                    EnJenisId = table.Column<int>(type: "int", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPekerja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DPekerja_JBahagian_JBahagianId",
                        column: x => x.JBahagianId,
                        principalTable: "JBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DPekerja_JBangsa_JBangsaId",
                        column: x => x.JBangsaId,
                        principalTable: "JBangsa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPekerja_JBank_JBankId",
                        column: x => x.JBankId,
                        principalTable: "JBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPekerja_JCawangan_JCawanganId",
                        column: x => x.JCawanganId,
                        principalTable: "JCawangan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DPekerja_JNegeri_JNegeriId",
                        column: x => x.JNegeriId,
                        principalTable: "JNegeri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DPekerja_JPTJ_JPTJId",
                        column: x => x.JPTJId,
                        principalTable: "JPTJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DPenerimaCekGaji",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmaunGaji = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SuratNama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuratJabatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RujukanKami = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: true),
                    JCaraBayarId = table.Column<int>(type: "int", nullable: false),
                    JCawanganId = table.Column<int>(type: "int", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPenerimaCekGaji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DPenerimaCekGaji_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DPenerimaCekGaji_JCaraBayar_JCaraBayarId",
                        column: x => x.JCaraBayarId,
                        principalTable: "JCaraBayar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DPenerimaCekGaji_JCawangan_JCawanganId",
                        column: x => x.JCawanganId,
                        principalTable: "JCawangan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkRekup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPanjarId = table.Column<int>(type: "int", nullable: false),
                    IsLinked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkRekup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkRekup_DPanjar_DPanjarId",
                        column: x => x.DPanjarId,
                        principalTable: "DPanjar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LgDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LgModule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LgOperation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LgNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRujukan = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SysCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppLog_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tandatangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaId = table.Column<int>(type: "int", nullable: true),
                    JKWPTJBahagianList = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_AspNetUsers_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DKonfigKelulusan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DPekerjaId = table.Column<int>(type: "int", nullable: false),
                    JBahagianId = table.Column<int>(type: "int", nullable: true),
                    EnKategoriKelulusan = table.Column<int>(type: "int", nullable: false),
                    EnJenisModulKelulusan = table.Column<int>(type: "int", nullable: false),
                    MinAmaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaksAmaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KataLaluan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tandatangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAktif = table.Column<bool>(type: "bit", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DKonfigKelulusan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DKonfigKelulusan_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DKonfigKelulusan_JBahagian_JBahagianId",
                        column: x => x.JBahagianId,
                        principalTable: "JBahagian",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DPanjarPemegang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DPanjarId = table.Column<int>(type: "int", nullable: false),
                    DPekerjaId = table.Column<int>(type: "int", nullable: false),
                    JangkaMasaDari = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JangkaMasaHingga = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsAktif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPanjarPemegang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DPanjarPemegang_DPanjar_DPanjarId",
                        column: x => x.DPanjarId,
                        principalTable: "DPanjar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DPanjarPemegang_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DPekerjaElaunPotongan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DPekerjaId = table.Column<int>(type: "int", nullable: false),
                    JElaunPotonganId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPekerjaElaunPotongan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DPekerjaElaunPotongan_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DPekerjaElaunPotongan_JElaunPotongan_JElaunPotonganId",
                        column: x => x.JElaunPotonganId,
                        principalTable: "JElaunPotongan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DPenyelia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JCawanganId = table.Column<int>(type: "int", nullable: false),
                    DPekerjaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DPenyelia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DPenyelia_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DPenyelia_JCawangan_JCawanganId",
                        column: x => x.JCawanganId,
                        principalTable: "JCawangan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SuGajiBulananPekerja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DPekerjaId = table.Column<int>(type: "int", nullable: false),
                    SuGajiBulananId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuGajiBulananPekerja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuGajiBulananPekerja_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuGajiBulananPekerja_SuGajiBulanan_SuGajiBulananId",
                        column: x => x.SuGajiBulananId,
                        principalTable: "SuGajiBulanan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkJanaanProfilPenerima",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bil = table.Column<int>(type: "int", nullable: true),
                    AkJanaanProfilId = table.Column<int>(type: "int", nullable: false),
                    EnKategoriDaftarAwam = table.Column<int>(type: "int", nullable: false),
                    DPenerimaZakatId = table.Column<int>(type: "int", nullable: true),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: true),
                    DPekerjaId = table.Column<int>(type: "int", nullable: true),
                    NoPendaftaranPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoPendaftaranPemohon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JCaraBayarId = table.Column<int>(type: "int", nullable: false),
                    JBankId = table.Column<int>(type: "int", nullable: true),
                    NoAkaunBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodM2E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoRujukanMohon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkRekupId = table.Column<int>(type: "int", nullable: true),
                    EnJenisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkJanaanProfilPenerima", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkJanaanProfilPenerima_AkJanaanProfil_AkJanaanProfilId",
                        column: x => x.AkJanaanProfilId,
                        principalTable: "AkJanaanProfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkJanaanProfilPenerima_AkRekup_AkRekupId",
                        column: x => x.AkRekupId,
                        principalTable: "AkRekup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJanaanProfilPenerima_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJanaanProfilPenerima_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJanaanProfilPenerima_DPenerimaZakat_DPenerimaZakatId",
                        column: x => x.DPenerimaZakatId,
                        principalTable: "DPenerimaZakat",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJanaanProfilPenerima_JBank_JBankId",
                        column: x => x.JBankId,
                        principalTable: "JBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJanaanProfilPenerima_JCaraBayar_JCaraBayarId",
                        column: x => x.JCaraBayarId,
                        principalTable: "JCaraBayar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "AbWaran",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    EnJenisPeruntukan = table.Column<int>(type: "int", nullable: false),
                    FlJenisPindahan = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sebab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbWaran", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbWaran_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AbWaran_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AbWaran_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AbWaran_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AbWaran_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkAnggar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sebab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkAnggar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkAnggar_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkAnggar_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkAnggar_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkAnggar_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkAnggar_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkCV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPanjarId = table.Column<int>(type: "int", nullable: false),
                    EnKategoriPenerima = table.Column<int>(type: "int", nullable: false),
                    DPekerjaId = table.Column<int>(type: "int", nullable: true),
                    NoPendaftaranPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkCV", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkCV_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkCV_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkCV_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkCV_DPanjar_DPanjarId",
                        column: x => x.DPanjarId,
                        principalTable: "DPanjar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkCV_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkCV_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkNotaMinta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TarikhPerlu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnKaedahPerolehan = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sebab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    DPemohonId = table.Column<int>(type: "int", nullable: true),
                    Jawatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: false),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkNotaMinta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkNotaMinta_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkNotaMinta_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaMinta_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaMinta_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaMinta_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaMinta_DPekerja_DPemohonId",
                        column: x => x.DPemohonId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaMinta_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkNotaMinta_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPenilaianPerolehan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoSebutHarga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TarikhPerlu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnKaedahPerolehan = table.Column<int>(type: "int", nullable: false),
                    HargaTawaran = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sebab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BilSebutharga = table.Column<int>(type: "int", nullable: true),
                    MaklumatSebutHarga = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    DPemohonId = table.Column<int>(type: "int", nullable: true),
                    Jawatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlPOInden = table.Column<int>(type: "int", nullable: false),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: false),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPenilaianPerolehan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehan_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehan_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehan_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehan_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehan_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehan_DPekerja_DPemohonId",
                        column: x => x.DPemohonId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehan_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehan_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPenyataPemungut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoSlip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JCaraBayarId = table.Column<int>(type: "int", nullable: false),
                    AkBankId = table.Column<int>(type: "int", nullable: false),
                    JCawanganId = table.Column<int>(type: "int", nullable: false),
                    JPTJId = table.Column<int>(type: "int", nullable: false),
                    EnJenisCek = table.Column<int>(type: "int", nullable: false),
                    BilResit = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPenyataPemungut", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungut_AkBank_AkBankId",
                        column: x => x.AkBankId,
                        principalTable: "AkBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungut_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungut_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungut_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungut_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungut_JCaraBayar_JCaraBayarId",
                        column: x => x.JCaraBayarId,
                        principalTable: "JCaraBayar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungut_JCawangan_JCawanganId",
                        column: x => x.JCawanganId,
                        principalTable: "JCawangan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungut_JPTJ_JPTJId",
                        column: x => x.JPTJId,
                        principalTable: "JPTJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkPenyesuaianBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bulan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaFail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AkBankId = table.Column<int>(type: "int", nullable: false),
                    IsMuatNaik = table.Column<bool>(type: "bit", nullable: false),
                    TarikhMuatNaik = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsKunci = table.Column<bool>(type: "bit", nullable: false),
                    TarikhKunci = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BakiPenyata = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPenyesuaianBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPenyesuaianBank_AkBank_AkBankId",
                        column: x => x.AkBankId,
                        principalTable: "AkBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPenyesuaianBank_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenyesuaianBank_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenyesuaianBank_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenyesuaianBank_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JCawanganId = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsInvois = table.Column<bool>(type: "bit", nullable: false),
                    IsAkru = table.Column<bool>(type: "bit", nullable: false),
                    IsTanggungan = table.Column<bool>(type: "bit", nullable: false),
                    AkBankId = table.Column<int>(type: "int", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkJanaanProfilId = table.Column<int>(type: "int", nullable: true),
                    SuGajiBulananId = table.Column<int>(type: "int", nullable: true),
                    TarikhJanaanProfil = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NamaPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsGanda = table.Column<bool>(type: "bit", nullable: false),
                    EnJenisBayaran = table.Column<int>(type: "int", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPV", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPV_AkBank_AkBankId",
                        column: x => x.AkBankId,
                        principalTable: "AkBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPV_AkJanaanProfil_AkJanaanProfilId",
                        column: x => x.AkJanaanProfilId,
                        principalTable: "AkJanaanProfil",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPV_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPV_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPV_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPV_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPV_JCawangan_JCawanganId",
                        column: x => x.JCawanganId,
                        principalTable: "JCawangan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkPV_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkPV_SuGajiBulanan_SuGajiBulananId",
                        column: x => x.SuGajiBulananId,
                        principalTable: "SuGajiBulanan",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LHDNEInvois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeIssued = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LHDNMSICCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierTaxIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierIdType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierPIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierAddress3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierPostalZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierStateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerTaxIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerIdType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerPIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerAddress3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerPostalZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuyerStateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalNetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalExclusiceTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalInclusiveTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPayableAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LHDNEInvois", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LHDNEInvois_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LHDNEInvois_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LHDNEInvois_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LHDNEInvois_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SuGajiElaunPotongan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuGajiBulananPekerjaId = table.Column<int>(type: "int", nullable: false),
                    JElaunPotonganId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuGajiElaunPotongan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuGajiElaunPotongan_JElaunPotongan_JElaunPotonganId",
                        column: x => x.JElaunPotonganId,
                        principalTable: "JElaunPotongan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SuGajiElaunPotongan_SuGajiBulananPekerja_SuGajiBulananPekerjaId",
                        column: x => x.SuGajiBulananPekerjaId,
                        principalTable: "SuGajiBulananPekerja",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbWaranObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbWaranId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TK = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbWaranObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbWaranObjek_AbWaran_AbWaranId",
                        column: x => x.AbWaranId,
                        principalTable: "AbWaran",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbWaranObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AbWaranObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkAnggarObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkAnggarId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkAnggarObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkAnggarObjek_AkAnggar_AkAnggarId",
                        column: x => x.AkAnggarId,
                        principalTable: "AkAnggar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkAnggarObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkAnggarObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkCVObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkCVId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkCVObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkCVObjek_AkCV_AkCVId",
                        column: x => x.AkCVId,
                        principalTable: "AkCV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkCVObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkCVObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkNotaMintaObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkNotaMintaId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkNotaMintaObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkNotaMintaObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaMintaObjek_AkNotaMinta_AkNotaMintaId",
                        column: x => x.AkNotaMintaId,
                        principalTable: "AkNotaMinta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaMintaObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkNotaMintaPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkNotaMintaId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkNotaMintaPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkNotaMintaPerihal_AkNotaMinta_AkNotaMintaId",
                        column: x => x.AkNotaMintaId,
                        principalTable: "AkNotaMinta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaMintaPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaMintaPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkInden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AkPenilaianPerolehanId = table.Column<int>(type: "int", nullable: false),
                    JangkaMasaDari = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JangkaMasaHingga = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkInden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkInden_AkPenilaianPerolehan_AkPenilaianPerolehanId",
                        column: x => x.AkPenilaianPerolehanId,
                        principalTable: "AkPenilaianPerolehan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkInden_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkInden_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInden_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInden_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInden_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInden_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkInden_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPenilaianPerolehanObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPenilaianPerolehanId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPenilaianPerolehanObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehanObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehanObjek_AkPenilaianPerolehan_AkPenilaianPerolehanId",
                        column: x => x.AkPenilaianPerolehanId,
                        principalTable: "AkPenilaianPerolehan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehanObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkPenilaianPerolehanPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPenilaianPerolehanId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPenilaianPerolehanPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehanPerihal_AkPenilaianPerolehan_AkPenilaianPerolehanId",
                        column: x => x.AkPenilaianPerolehanId,
                        principalTable: "AkPenilaianPerolehan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehanPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPenilaianPerolehanPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AkPenilaianPerolehanId = table.Column<int>(type: "int", nullable: false),
                    EnJenisPerolehan = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: false),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPO_AkPenilaianPerolehan_AkPenilaianPerolehanId",
                        column: x => x.AkPenilaianPerolehanId,
                        principalTable: "AkPenilaianPerolehan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkPO_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPO_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPO_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPO_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPO_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPO_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPO_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPenyesuaianBankPenyataBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPenyesuaianBankId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Indeks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoAkaunBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KodCawanganBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodTransaksi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerihalTransaksi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoDokumen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoDokumenTambahan1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoDokumenTambahan2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoDokumenTambahan3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kredit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SignDebitKredit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Baki = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPadan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPenyesuaianBankPenyataBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPenyesuaianBankPenyataBank_AkPenyesuaianBank_AkPenyesuaianBankId",
                        column: x => x.AkPenyesuaianBankId,
                        principalTable: "AkPenyesuaianBank",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkEFTPenerima",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkEFTId = table.Column<int>(type: "int", nullable: false),
                    AkPVId = table.Column<int>(type: "int", nullable: false),
                    EnStatusEFT = table.Column<int>(type: "int", nullable: false),
                    SebabGagal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarikhKredit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bil = table.Column<int>(type: "int", nullable: true),
                    NoPendaftaranPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JCaraBayarId = table.Column<int>(type: "int", nullable: false),
                    JBankId = table.Column<int>(type: "int", nullable: true),
                    NoAkaunBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodM2E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukanCaraBayar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EnJenisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkEFTPenerima", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkEFTPenerima_AkEFT_AkEFTId",
                        column: x => x.AkEFTId,
                        principalTable: "AkEFT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkEFTPenerima_AkPV_AkPVId",
                        column: x => x.AkPVId,
                        principalTable: "AkPV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkEFTPenerima_JBank_JBankId",
                        column: x => x.JBankId,
                        principalTable: "JBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkEFTPenerima_JCaraBayar_JCaraBayarId",
                        column: x => x.JCaraBayarId,
                        principalTable: "JCaraBayar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkJurnal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnJenisJurnal = table.Column<int>(type: "int", nullable: false),
                    JumlahDebit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahKredit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkPVId = table.Column<int>(type: "int", nullable: true),
                    IsAKB = table.Column<bool>(type: "bit", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkJurnal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkJurnal_AkPV_AkPVId",
                        column: x => x.AkPVId,
                        principalTable: "AkPV",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJurnal_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJurnal_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJurnal_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJurnal_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkJurnal_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkPVObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPVId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    JCukaiId = table.Column<int>(type: "int", nullable: true),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPVObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPVObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPVObjek_AkPV_AkPVId",
                        column: x => x.AkPVId,
                        principalTable: "AkPV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPVObjek_JCukai_JCukaiId",
                        column: x => x.JCukaiId,
                        principalTable: "JCukai",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPVObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkPVPenerima",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPVId = table.Column<int>(type: "int", nullable: false),
                    AkJanaanProfilPenerimaId = table.Column<int>(type: "int", nullable: true),
                    EnKategoriDaftarAwam = table.Column<int>(type: "int", nullable: false),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: true),
                    DPekerjaId = table.Column<int>(type: "int", nullable: true),
                    NoPendaftaranPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoPendaftaranPemohon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JCaraBayarId = table.Column<int>(type: "int", nullable: false),
                    JBankId = table.Column<int>(type: "int", nullable: true),
                    NoAkaunBank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodM2E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukanCaraBayar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarikhCaraBayar = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoRujukanMohon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AkRekupId = table.Column<int>(type: "int", nullable: true),
                    DPanjarId = table.Column<int>(type: "int", nullable: true),
                    IsCekDitunaikan = table.Column<bool>(type: "bit", nullable: false),
                    TarikhCekDitunaikan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusEFT = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<int>(type: "int", nullable: true),
                    EnJenisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPVPenerima", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPVPenerima_AkJanaanProfilPenerima_AkJanaanProfilPenerimaId",
                        column: x => x.AkJanaanProfilPenerimaId,
                        principalTable: "AkJanaanProfilPenerima",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPVPenerima_AkPV_AkPVId",
                        column: x => x.AkPVId,
                        principalTable: "AkPV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPVPenerima_AkRekup_AkRekupId",
                        column: x => x.AkRekupId,
                        principalTable: "AkRekup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPVPenerima_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPVPenerima_DPanjar_DPanjarId",
                        column: x => x.DPanjarId,
                        principalTable: "DPanjar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPVPenerima_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPVPenerima_JBank_JBankId",
                        column: x => x.JBankId,
                        principalTable: "JBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPVPenerima_JCaraBayar_JCaraBayarId",
                        column: x => x.JCaraBayarId,
                        principalTable: "JCaraBayar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkTerima",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JCawanganId = table.Column<int>(type: "int", nullable: true),
                    EnJenisTerimaan = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AkPVId = table.Column<int>(type: "int", nullable: true),
                    AkBankId = table.Column<int>(type: "int", nullable: true),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnKategoriDaftarAwam = table.Column<int>(type: "int", nullable: false),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: true),
                    DPekerjaId = table.Column<int>(type: "int", nullable: true),
                    NoPendaftaranPembayar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlCetak = table.Column<int>(type: "int", nullable: false),
                    JNegeriId = table.Column<int>(type: "int", nullable: true),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkTerima", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkTerima_AkBank_AkBankId",
                        column: x => x.AkBankId,
                        principalTable: "AkBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerima_AkPV_AkPVId",
                        column: x => x.AkPVId,
                        principalTable: "AkPV",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerima_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerima_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerima_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerima_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerima_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerima_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerima_JCawangan_JCawanganId",
                        column: x => x.JCawanganId,
                        principalTable: "JCawangan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkTerima_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkTerima_JNegeri_JNegeriId",
                        column: x => x.JNegeriId,
                        principalTable: "JNegeri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkTerimaTunggal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JCawanganId = table.Column<int>(type: "int", nullable: true),
                    EnJenisTerimaan = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AkPVId = table.Column<int>(type: "int", nullable: true),
                    AkBankId = table.Column<int>(type: "int", nullable: true),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnKategoriDaftarAwam = table.Column<int>(type: "int", nullable: false),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: true),
                    DPekerjaId = table.Column<int>(type: "int", nullable: true),
                    NoPendaftaranPembayar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlCetak = table.Column<int>(type: "int", nullable: false),
                    JNegeriId = table.Column<int>(type: "int", nullable: true),
                    JCaraBayarId = table.Column<int>(type: "int", nullable: false),
                    NoCekMK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnJenisCek = table.Column<int>(type: "int", nullable: false),
                    KodBankCek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TempatCek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoSlip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarikhSlip = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkTerimaTunggal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_AkBank_AkBankId",
                        column: x => x.AkBankId,
                        principalTable: "AkBank",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_AkPV_AkPVId",
                        column: x => x.AkPVId,
                        principalTable: "AkPV",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_DPekerja_DPekerjaId",
                        column: x => x.DPekerjaId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_JCaraBayar_JCaraBayarId",
                        column: x => x.JCaraBayarId,
                        principalTable: "JCaraBayar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_JCawangan_JCawanganId",
                        column: x => x.JCawanganId,
                        principalTable: "JCawangan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggal_JNegeri_JNegeriId",
                        column: x => x.JNegeriId,
                        principalTable: "JNegeri",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkInvois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: false),
                    AkAkaunAkruId = table.Column<int>(type: "int", nullable: true),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LHDNEInvoisId = table.Column<int>(type: "int", nullable: true),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    UUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KodPbklLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkInvois", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkInvois_AkCarta_AkAkaunAkruId",
                        column: x => x.AkAkaunAkruId,
                        principalTable: "AkCarta",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInvois_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkInvois_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInvois_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInvois_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInvois_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInvois_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkInvois_LHDNEInvois_LHDNEInvoisId",
                        column: x => x.LHDNEInvoisId,
                        principalTable: "LHDNEInvois",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInvois_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LHDNEInvoisPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LHDNEInvoisId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNClassificationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    LHDNUnitOfMeasurementCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNTaxTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxExemptionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxExemptionAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountExemptedFromTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LHDNEInvoisPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LHDNEInvoisPerihal_LHDNEInvois_LHDNEInvoisId",
                        column: x => x.LHDNEInvoisId,
                        principalTable: "LHDNEInvois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkIndenObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkIndenId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkIndenObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkIndenObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkIndenObjek_AkInden_AkIndenId",
                        column: x => x.AkIndenId,
                        principalTable: "AkInden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkIndenObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkIndenPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkIndenId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkIndenPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkIndenPerihal_AkInden_AkIndenId",
                        column: x => x.AkIndenId,
                        principalTable: "AkInden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkIndenPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkIndenPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPelarasanInden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AkIndenId = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPelarasanInden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPelarasanInden_AkInden_AkIndenId",
                        column: x => x.AkIndenId,
                        principalTable: "AkInden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPelarasanInden_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanInden_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanInden_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanInden_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanInden_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkPelarasanInden_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkBelian",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TarikhTerimaBahagian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TarikhTerimaKewangan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TarikhAkuanKewangan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnJenisBayaranBelian = table.Column<int>(type: "int", nullable: false),
                    AkIndenId = table.Column<int>(type: "int", nullable: true),
                    AkPOId = table.Column<int>(type: "int", nullable: true),
                    AkNotaMintaId = table.Column<int>(type: "int", nullable: true),
                    DDaftarAwamId = table.Column<int>(type: "int", nullable: false),
                    AkAkaunAkruId = table.Column<int>(type: "int", nullable: true),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LHDNEInvoisId = table.Column<int>(type: "int", nullable: true),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    UUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KodPbklLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkBelian", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkBelian_AkCarta_AkAkaunAkruId",
                        column: x => x.AkAkaunAkruId,
                        principalTable: "AkCarta",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelian_AkInden_AkIndenId",
                        column: x => x.AkIndenId,
                        principalTable: "AkInden",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelian_AkNotaMinta_AkNotaMintaId",
                        column: x => x.AkNotaMintaId,
                        principalTable: "AkNotaMinta",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelian_AkPO_AkPOId",
                        column: x => x.AkPOId,
                        principalTable: "AkPO",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelian_DDaftarAwam_DDaftarAwamId",
                        column: x => x.DDaftarAwamId,
                        principalTable: "DDaftarAwam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkBelian_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelian_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelian_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelian_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelian_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkBelian_LHDNEInvois_LHDNEInvoisId",
                        column: x => x.LHDNEInvoisId,
                        principalTable: "LHDNEInvois",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelian_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPelarasanPO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AkPOId = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoRujukanLama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPelarasanPO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPelarasanPO_AkPO_AkPOId",
                        column: x => x.AkPOId,
                        principalTable: "AkPO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPelarasanPO_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanPO_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanPO_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanPO_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanPO_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkPelarasanPO_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPOObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPOId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPOObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPOObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPOObjek_AkPO_AkPOId",
                        column: x => x.AkPOId,
                        principalTable: "AkPO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPOObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkPOPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPOId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPOPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPOPerihal_AkPO_AkPOId",
                        column: x => x.AkPOId,
                        principalTable: "AkPO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPOPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPOPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkJurnalObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkJurnalId = table.Column<int>(type: "int", nullable: false),
                    AkCartaDebitId = table.Column<int>(type: "int", nullable: false),
                    AkCartaKreditId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianDebitId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianKreditId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDebitAbBukuVot = table.Column<bool>(type: "bit", nullable: false),
                    IsKreditAbBukuVot = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkJurnalObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkJurnalObjek_AkCarta_AkCartaDebitId",
                        column: x => x.AkCartaDebitId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkJurnalObjek_AkCarta_AkCartaKreditId",
                        column: x => x.AkCartaKreditId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkJurnalObjek_AkJurnal_AkJurnalId",
                        column: x => x.AkJurnalId,
                        principalTable: "AkJurnal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkJurnalObjek_JKWPTJBahagian_JKWPTJBahagianDebitId",
                        column: x => x.JKWPTJBahagianDebitId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkJurnalObjek_JKWPTJBahagian_JKWPTJBahagianKreditId",
                        column: x => x.JKWPTJBahagianKreditId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkJurnalPenerimaCekBatal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkJurnalId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<int>(type: "int", nullable: false),
                    AkPVId = table.Column<int>(type: "int", nullable: false),
                    NamaPenerima = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoCek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkJurnalPenerimaCekBatal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkJurnalPenerimaCekBatal_AkJurnal_AkJurnalId",
                        column: x => x.AkJurnalId,
                        principalTable: "AkJurnal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkJurnalPenerimaCekBatal_AkPV_AkPVId",
                        column: x => x.AkPVId,
                        principalTable: "AkPV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkPanjarLejar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    DPanjarId = table.Column<int>(type: "int", nullable: false),
                    AkCVId = table.Column<int>(type: "int", nullable: true),
                    AkPVId = table.Column<int>(type: "int", nullable: true),
                    AkJurnalId = table.Column<int>(type: "int", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kredit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AkRekupId = table.Column<int>(type: "int", nullable: true),
                    NoRekup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPanjarLejar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPanjarLejar_AkCV_AkCVId",
                        column: x => x.AkCVId,
                        principalTable: "AkCV",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPanjarLejar_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPanjarLejar_AkJurnal_AkJurnalId",
                        column: x => x.AkJurnalId,
                        principalTable: "AkJurnal",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPanjarLejar_AkPV_AkPVId",
                        column: x => x.AkPVId,
                        principalTable: "AkPV",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPanjarLejar_AkRekup_AkRekupId",
                        column: x => x.AkRekupId,
                        principalTable: "AkRekup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPanjarLejar_DPanjar_DPanjarId",
                        column: x => x.DPanjarId,
                        principalTable: "DPanjar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPanjarLejar_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkAkaunPenyataBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkAkaunId = table.Column<int>(type: "int", nullable: true),
                    AkPenyesuaianBankPenyataBankId = table.Column<int>(type: "int", nullable: false),
                    AkPVPenerimaId = table.Column<int>(type: "int", nullable: true),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAutoMatch = table.Column<bool>(type: "bit", nullable: false),
                    JCaraBayarId = table.Column<int>(type: "int", nullable: true),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kredit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkAkaunPenyataBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkAkaunPenyataBank_AkAkaun_AkAkaunId",
                        column: x => x.AkAkaunId,
                        principalTable: "AkAkaun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkAkaunPenyataBank_AkPVPenerima_AkPVPenerimaId",
                        column: x => x.AkPVPenerimaId,
                        principalTable: "AkPVPenerima",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkAkaunPenyataBank_AkPenyesuaianBankPenyataBank_AkPenyesuaianBankPenyataBankId",
                        column: x => x.AkPenyesuaianBankPenyataBankId,
                        principalTable: "AkPenyesuaianBankPenyataBank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkAkaunPenyataBank_JCaraBayar_JCaraBayarId",
                        column: x => x.JCaraBayarId,
                        principalTable: "JCaraBayar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkTerimaCaraBayar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkTerimaId = table.Column<int>(type: "int", nullable: false),
                    JCaraBayarId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NoCekMK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnJenisCek = table.Column<int>(type: "int", nullable: false),
                    KodBankCek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TempatCek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoSlip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarikhSlip = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReconTarikhTunai = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReconIsAutoMatch = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkTerimaCaraBayar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkTerimaCaraBayar_AkTerima_AkTerimaId",
                        column: x => x.AkTerimaId,
                        principalTable: "AkTerima",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkTerimaCaraBayar_JCaraBayar_JCaraBayarId",
                        column: x => x.JCaraBayarId,
                        principalTable: "JCaraBayar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkTerimaObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkTerimaId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkTerimaObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkTerimaObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkTerimaObjek_AkTerima_AkTerimaId",
                        column: x => x.AkTerimaId,
                        principalTable: "AkTerima",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkTerimaObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkPenyataPemungutObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPenyataPemungutId = table.Column<int>(type: "int", nullable: false),
                    AkTerimaTunggalId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPenyataPemungutObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungutObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungutObjek_AkPenyataPemungut_AkPenyataPemungutId",
                        column: x => x.AkPenyataPemungutId,
                        principalTable: "AkPenyataPemungut",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungutObjek_AkTerimaTunggal_AkTerimaTunggalId",
                        column: x => x.AkTerimaTunggalId,
                        principalTable: "AkTerimaTunggal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPenyataPemungutObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkTerimaTunggalObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkTerimaTunggalId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkTerimaTunggalObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggalObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggalObjek_AkTerimaTunggal_AkTerimaTunggalId",
                        column: x => x.AkTerimaTunggalId,
                        principalTable: "AkTerimaTunggal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggalObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkInvoisObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkInvoisId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkInvoisObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkInvoisObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkInvoisObjek_AkInvois_AkInvoisId",
                        column: x => x.AkInvoisId,
                        principalTable: "AkInvois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkInvoisObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkInvoisPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkInvoisId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkInvoisPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkInvoisPerihal_AkInvois_AkInvoisId",
                        column: x => x.AkInvoisId,
                        principalTable: "AkInvois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkInvoisPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkInvoisPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkNotaDebitKreditDikeluarkan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlDebitKredit = table.Column<int>(type: "int", nullable: false),
                    AkInvoisId = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LHDNEInvoisId = table.Column<int>(type: "int", nullable: true),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    UUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkNotaDebitKreditDikeluarkan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkan_AkInvois_AkInvoisId",
                        column: x => x.AkInvoisId,
                        principalTable: "AkInvois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkan_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkan_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkan_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkan_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkan_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkan_LHDNEInvois_LHDNEInvoisId",
                        column: x => x.LHDNEInvoisId,
                        principalTable: "LHDNEInvois",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkan_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkTerimaInvois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkTerimaId = table.Column<int>(type: "int", nullable: false),
                    AkInvoisId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkTerimaInvois", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkTerimaInvois_AkInvois_AkInvoisId",
                        column: x => x.AkInvoisId,
                        principalTable: "AkInvois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkTerimaInvois_AkTerima_AkTerimaId",
                        column: x => x.AkTerimaId,
                        principalTable: "AkTerima",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkTerimaTunggalInvois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkTerimaTunggalId = table.Column<int>(type: "int", nullable: false),
                    AkInvoisId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkTerimaTunggalInvois", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggalInvois_AkInvois_AkInvoisId",
                        column: x => x.AkInvoisId,
                        principalTable: "AkInvois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkTerimaTunggalInvois_AkTerimaTunggal_AkTerimaTunggalId",
                        column: x => x.AkTerimaTunggalId,
                        principalTable: "AkTerimaTunggal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkPelarasanIndenObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPelarasanIndenId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPelarasanIndenObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPelarasanIndenObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPelarasanIndenObjek_AkPelarasanInden_AkPelarasanIndenId",
                        column: x => x.AkPelarasanIndenId,
                        principalTable: "AkPelarasanInden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPelarasanIndenObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkPelarasanIndenPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPelarasanIndenId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPelarasanIndenPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPelarasanIndenPerihal_AkPelarasanInden_AkPelarasanIndenId",
                        column: x => x.AkPelarasanIndenId,
                        principalTable: "AkPelarasanInden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPelarasanIndenPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanIndenPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkBelianObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkBelianId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    JCukaiId = table.Column<int>(type: "int", nullable: true),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkBelianObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkBelianObjek_AkBelian_AkBelianId",
                        column: x => x.AkBelianId,
                        principalTable: "AkBelian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkBelianObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkBelianObjek_JCukai_JCukaiId",
                        column: x => x.JCukaiId,
                        principalTable: "JCukai",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelianObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkBelianPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkBelianId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkBelianPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkBelianPerihal_AkBelian_AkBelianId",
                        column: x => x.AkBelianId,
                        principalTable: "AkBelian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkBelianPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkBelianPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkNotaDebitKreditDiterima",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tahun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoRujukan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlDebitKredit = table.Column<int>(type: "int", nullable: false),
                    AkBelianId = table.Column<int>(type: "int", nullable: false),
                    Jumlah = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JKWId = table.Column<int>(type: "int", nullable: false),
                    Ringkasan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LHDNEInvoisId = table.Column<int>(type: "int", nullable: true),
                    LHDNMSICId = table.Column<int>(type: "int", nullable: true),
                    UUID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumlahCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JumlahTanpaCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPekerjaMasukId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarMasuk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DPekerjaKemaskiniId = table.Column<int>(type: "int", nullable: true),
                    UserIdKemaskini = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarKemaskini = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FlHapus = table.Column<int>(type: "int", nullable: false),
                    TarHapus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabHapus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlBatal = table.Column<int>(type: "int", nullable: false),
                    TarBatal = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SebabBatal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DPengesahId = table.Column<int>(type: "int", nullable: true),
                    TarikhSah = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPenyemakId = table.Column<int>(type: "int", nullable: true),
                    TarikhSemak = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPelulusId = table.Column<int>(type: "int", nullable: true),
                    TarikhLulus = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DPekerjaPostingId = table.Column<int>(type: "int", nullable: true),
                    FlPosting = table.Column<int>(type: "int", nullable: false),
                    TarikhPosting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnStatusBorang = table.Column<int>(type: "int", nullable: false),
                    Tindakan = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkNotaDebitKreditDiterima", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterima_AkBelian_AkBelianId",
                        column: x => x.AkBelianId,
                        principalTable: "AkBelian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterima_DKonfigKelulusan_DPelulusId",
                        column: x => x.DPelulusId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterima_DKonfigKelulusan_DPengesahId",
                        column: x => x.DPengesahId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterima_DKonfigKelulusan_DPenyemakId",
                        column: x => x.DPenyemakId,
                        principalTable: "DKonfigKelulusan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterima_DPekerja_DPekerjaPostingId",
                        column: x => x.DPekerjaPostingId,
                        principalTable: "DPekerja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterima_JKW_JKWId",
                        column: x => x.JKWId,
                        principalTable: "JKW",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterima_LHDNEInvois_LHDNEInvoisId",
                        column: x => x.LHDNEInvoisId,
                        principalTable: "LHDNEInvois",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterima_LHDNMSIC_LHDNMSICId",
                        column: x => x.LHDNMSICId,
                        principalTable: "LHDNMSIC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkPVInvois",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPVId = table.Column<int>(type: "int", nullable: false),
                    IsTanggungan = table.Column<bool>(type: "bit", nullable: false),
                    AkBelianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPVInvois", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPVInvois_AkBelian_AkBelianId",
                        column: x => x.AkBelianId,
                        principalTable: "AkBelian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPVInvois_AkPV_AkPVId",
                        column: x => x.AkPVId,
                        principalTable: "AkPV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkPelarasanPOObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPelarasanPOId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPelarasanPOObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPelarasanPOObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPelarasanPOObjek_AkPelarasanPO_AkPelarasanPOId",
                        column: x => x.AkPelarasanPOId,
                        principalTable: "AkPelarasanPO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPelarasanPOObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AkPelarasanPOPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkPelarasanPOId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkPelarasanPOPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkPelarasanPOPerihal_AkPelarasanPO_AkPelarasanPOId",
                        column: x => x.AkPelarasanPOId,
                        principalTable: "AkPelarasanPO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkPelarasanPOPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkPelarasanPOPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkNotaDebitKreditDikeluarkanObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkNotaDebitKreditDikeluarkanId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkNotaDebitKreditDikeluarkanObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkanObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkanObjek_AkNotaDebitKreditDikeluarkan_AkNotaDebitKreditDikeluarkanId",
                        column: x => x.AkNotaDebitKreditDikeluarkanId,
                        principalTable: "AkNotaDebitKreditDikeluarkan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkanObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkNotaDebitKreditDikeluarkanPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkNotaDebitKreditDikeluarkanId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkNotaDebitKreditDikeluarkanPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkanPerihal_AkNotaDebitKreditDikeluarkan_AkNotaDebitKreditDikeluarkanId",
                        column: x => x.AkNotaDebitKreditDikeluarkanId,
                        principalTable: "AkNotaDebitKreditDikeluarkan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkanPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDikeluarkanPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AkNotaDebitKreditDiterimaObjek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkNotaDebitKreditDiterimaId = table.Column<int>(type: "int", nullable: false),
                    AkCartaId = table.Column<int>(type: "int", nullable: false),
                    JKWPTJBahagianId = table.Column<int>(type: "int", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkNotaDebitKreditDiterimaObjek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterimaObjek_AkCarta_AkCartaId",
                        column: x => x.AkCartaId,
                        principalTable: "AkCarta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterimaObjek_AkNotaDebitKreditDiterima_AkNotaDebitKreditDiterimaId",
                        column: x => x.AkNotaDebitKreditDiterimaId,
                        principalTable: "AkNotaDebitKreditDiterima",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterimaObjek_JKWPTJBahagian_JKWPTJBahagianId",
                        column: x => x.JKWPTJBahagianId,
                        principalTable: "JKWPTJBahagian",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AkNotaDebitKreditDiterimaPerihal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AkNotaDebitKreditDiterimaId = table.Column<int>(type: "int", nullable: false),
                    Bil = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Perihal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kuantiti = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LHDNKodKlasifikasiId = table.Column<int>(type: "int", nullable: true),
                    LHDNUnitUkuranId = table.Column<int>(type: "int", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnLHDNJenisCukai = table.Column<int>(type: "int", nullable: false),
                    KadarCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmaunCukai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Harga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amaun = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AkNotaDebitKreditDiterimaPerihal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterimaPerihal_AkNotaDebitKreditDiterima_AkNotaDebitKreditDiterimaId",
                        column: x => x.AkNotaDebitKreditDiterimaId,
                        principalTable: "AkNotaDebitKreditDiterima",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterimaPerihal_LHDNKodKlasifikasi_LHDNKodKlasifikasiId",
                        column: x => x.LHDNKodKlasifikasiId,
                        principalTable: "LHDNKodKlasifikasi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AkNotaDebitKreditDiterimaPerihal_LHDNUnitUkuran_LHDNUnitUkuranId",
                        column: x => x.LHDNUnitUkuranId,
                        principalTable: "LHDNUnitUkuran",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbBukuVot_DDaftarAwamId",
                table: "AbBukuVot",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AbBukuVot_JBahagianId",
                table: "AbBukuVot",
                column: "JBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AbBukuVot_JKWId",
                table: "AbBukuVot",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AbBukuVot_JPTJId",
                table: "AbBukuVot",
                column: "JPTJId");

            migrationBuilder.CreateIndex(
                name: "IX_AbBukuVot_VotId",
                table: "AbBukuVot",
                column: "VotId");

            migrationBuilder.CreateIndex(
                name: "IX_AbWaran_DPekerjaPostingId",
                table: "AbWaran",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AbWaran_DPelulusId",
                table: "AbWaran",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AbWaran_DPengesahId",
                table: "AbWaran",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AbWaran_DPenyemakId",
                table: "AbWaran",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AbWaran_JKWId",
                table: "AbWaran",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AbWaranObjek_AbWaranId",
                table: "AbWaranObjek",
                column: "AbWaranId");

            migrationBuilder.CreateIndex(
                name: "IX_AbWaranObjek_AkCartaId",
                table: "AbWaranObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AbWaranObjek_JKWPTJBahagianId",
                table: "AbWaranObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAkaun_AkCarta1Id",
                table: "AkAkaun",
                column: "AkCarta1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AkAkaun_AkCarta2Id",
                table: "AkAkaun",
                column: "AkCarta2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AkAkaun_JBahagianId",
                table: "AkAkaun",
                column: "JBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAkaun_JKWId",
                table: "AkAkaun",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAkaun_JPTJId",
                table: "AkAkaun",
                column: "JPTJId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAkaunPenyataBank_AkAkaunId",
                table: "AkAkaunPenyataBank",
                column: "AkAkaunId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAkaunPenyataBank_AkPenyesuaianBankPenyataBankId",
                table: "AkAkaunPenyataBank",
                column: "AkPenyesuaianBankPenyataBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAkaunPenyataBank_AkPVPenerimaId",
                table: "AkAkaunPenyataBank",
                column: "AkPVPenerimaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAkaunPenyataBank_JCaraBayarId",
                table: "AkAkaunPenyataBank",
                column: "JCaraBayarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggar_DPekerjaPostingId",
                table: "AkAnggar",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggar_DPelulusId",
                table: "AkAnggar",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggar_DPengesahId",
                table: "AkAnggar",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggar_DPenyemakId",
                table: "AkAnggar",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggar_JKWId",
                table: "AkAnggar",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggarLejar_AkCartaId",
                table: "AkAnggarLejar",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggarLejar_JKWPTJBahagianId",
                table: "AkAnggarLejar",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggarObjek_AkAnggarId",
                table: "AkAnggarObjek",
                column: "AkAnggarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggarObjek_AkCartaId",
                table: "AkAnggarObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkAnggarObjek_JKWPTJBahagianId",
                table: "AkAnggarObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBank_AkCartaId",
                table: "AkBank",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBank_JBankId",
                table: "AkBank",
                column: "JBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBank_JKWId",
                table: "AkBank",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_AkAkaunAkruId",
                table: "AkBelian",
                column: "AkAkaunAkruId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_AkIndenId",
                table: "AkBelian",
                column: "AkIndenId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_AkNotaMintaId",
                table: "AkBelian",
                column: "AkNotaMintaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_AkPOId",
                table: "AkBelian",
                column: "AkPOId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_DDaftarAwamId",
                table: "AkBelian",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_DPekerjaPostingId",
                table: "AkBelian",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_DPelulusId",
                table: "AkBelian",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_DPengesahId",
                table: "AkBelian",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_DPenyemakId",
                table: "AkBelian",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_JKWId",
                table: "AkBelian",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_LHDNEInvoisId",
                table: "AkBelian",
                column: "LHDNEInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelian_LHDNMSICId",
                table: "AkBelian",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelianObjek_AkBelianId",
                table: "AkBelianObjek",
                column: "AkBelianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelianObjek_AkCartaId",
                table: "AkBelianObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelianObjek_JCukaiId",
                table: "AkBelianObjek",
                column: "JCukaiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelianObjek_JKWPTJBahagianId",
                table: "AkBelianObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelianPerihal_AkBelianId",
                table: "AkBelianPerihal",
                column: "AkBelianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelianPerihal_LHDNKodKlasifikasiId",
                table: "AkBelianPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkBelianPerihal_LHDNUnitUkuranId",
                table: "AkBelianPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkCV_DPanjarId",
                table: "AkCV",
                column: "DPanjarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkCV_DPekerjaId",
                table: "AkCV",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkCV_DPekerjaPostingId",
                table: "AkCV",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkCV_DPelulusId",
                table: "AkCV",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkCV_DPengesahId",
                table: "AkCV",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkCV_DPenyemakId",
                table: "AkCV",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkCVObjek_AkCartaId",
                table: "AkCVObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkCVObjek_AkCVId",
                table: "AkCVObjek",
                column: "AkCVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkCVObjek_JKWPTJBahagianId",
                table: "AkCVObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkEFT_AkBankId",
                table: "AkEFT",
                column: "AkBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkEFT_JBankId",
                table: "AkEFT",
                column: "JBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkEFTPenerima_AkEFTId",
                table: "AkEFTPenerima",
                column: "AkEFTId");

            migrationBuilder.CreateIndex(
                name: "IX_AkEFTPenerima_AkPVId",
                table: "AkEFTPenerima",
                column: "AkPVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkEFTPenerima_JBankId",
                table: "AkEFTPenerima",
                column: "JBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkEFTPenerima_JCaraBayarId",
                table: "AkEFTPenerima",
                column: "JCaraBayarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInden_AkPenilaianPerolehanId",
                table: "AkInden",
                column: "AkPenilaianPerolehanId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInden_DDaftarAwamId",
                table: "AkInden",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInden_DPekerjaPostingId",
                table: "AkInden",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInden_DPelulusId",
                table: "AkInden",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInden_DPengesahId",
                table: "AkInden",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInden_DPenyemakId",
                table: "AkInden",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInden_JKWId",
                table: "AkInden",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInden_LHDNMSICId",
                table: "AkInden",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkIndenObjek_AkCartaId",
                table: "AkIndenObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkIndenObjek_AkIndenId",
                table: "AkIndenObjek",
                column: "AkIndenId");

            migrationBuilder.CreateIndex(
                name: "IX_AkIndenObjek_JKWPTJBahagianId",
                table: "AkIndenObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkIndenPerihal_AkIndenId",
                table: "AkIndenPerihal",
                column: "AkIndenId");

            migrationBuilder.CreateIndex(
                name: "IX_AkIndenPerihal_LHDNKodKlasifikasiId",
                table: "AkIndenPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkIndenPerihal_LHDNUnitUkuranId",
                table: "AkIndenPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvois_AkAkaunAkruId",
                table: "AkInvois",
                column: "AkAkaunAkruId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvois_DDaftarAwamId",
                table: "AkInvois",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvois_DPekerjaPostingId",
                table: "AkInvois",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvois_DPelulusId",
                table: "AkInvois",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvois_DPengesahId",
                table: "AkInvois",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvois_DPenyemakId",
                table: "AkInvois",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvois_JKWId",
                table: "AkInvois",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvois_LHDNEInvoisId",
                table: "AkInvois",
                column: "LHDNEInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvois_LHDNMSICId",
                table: "AkInvois",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvoisObjek_AkCartaId",
                table: "AkInvoisObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvoisObjek_AkInvoisId",
                table: "AkInvoisObjek",
                column: "AkInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvoisObjek_JKWPTJBahagianId",
                table: "AkInvoisObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvoisPerihal_AkInvoisId",
                table: "AkInvoisPerihal",
                column: "AkInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvoisPerihal_LHDNKodKlasifikasiId",
                table: "AkInvoisPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkInvoisPerihal_LHDNUnitUkuranId",
                table: "AkInvoisPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJanaanProfil_JCawanganId",
                table: "AkJanaanProfil",
                column: "JCawanganId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJanaanProfilPenerima_AkJanaanProfilId",
                table: "AkJanaanProfilPenerima",
                column: "AkJanaanProfilId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJanaanProfilPenerima_AkRekupId",
                table: "AkJanaanProfilPenerima",
                column: "AkRekupId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJanaanProfilPenerima_DDaftarAwamId",
                table: "AkJanaanProfilPenerima",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJanaanProfilPenerima_DPekerjaId",
                table: "AkJanaanProfilPenerima",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJanaanProfilPenerima_DPenerimaZakatId",
                table: "AkJanaanProfilPenerima",
                column: "DPenerimaZakatId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJanaanProfilPenerima_JBankId",
                table: "AkJanaanProfilPenerima",
                column: "JBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJanaanProfilPenerima_JCaraBayarId",
                table: "AkJanaanProfilPenerima",
                column: "JCaraBayarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnal_AkPVId",
                table: "AkJurnal",
                column: "AkPVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnal_DPekerjaPostingId",
                table: "AkJurnal",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnal_DPelulusId",
                table: "AkJurnal",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnal_DPengesahId",
                table: "AkJurnal",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnal_DPenyemakId",
                table: "AkJurnal",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnal_JKWId",
                table: "AkJurnal",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnalObjek_AkCartaDebitId",
                table: "AkJurnalObjek",
                column: "AkCartaDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnalObjek_AkCartaKreditId",
                table: "AkJurnalObjek",
                column: "AkCartaKreditId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnalObjek_AkJurnalId",
                table: "AkJurnalObjek",
                column: "AkJurnalId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnalObjek_JKWPTJBahagianDebitId",
                table: "AkJurnalObjek",
                column: "JKWPTJBahagianDebitId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnalObjek_JKWPTJBahagianKreditId",
                table: "AkJurnalObjek",
                column: "JKWPTJBahagianKreditId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnalPenerimaCekBatal_AkJurnalId",
                table: "AkJurnalPenerimaCekBatal",
                column: "AkJurnalId");

            migrationBuilder.CreateIndex(
                name: "IX_AkJurnalPenerimaCekBatal_AkPVId",
                table: "AkJurnalPenerimaCekBatal",
                column: "AkPVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkan_AkInvoisId",
                table: "AkNotaDebitKreditDikeluarkan",
                column: "AkInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkan_DPekerjaPostingId",
                table: "AkNotaDebitKreditDikeluarkan",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkan_DPelulusId",
                table: "AkNotaDebitKreditDikeluarkan",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkan_DPengesahId",
                table: "AkNotaDebitKreditDikeluarkan",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkan_DPenyemakId",
                table: "AkNotaDebitKreditDikeluarkan",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkan_JKWId",
                table: "AkNotaDebitKreditDikeluarkan",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkan_LHDNEInvoisId",
                table: "AkNotaDebitKreditDikeluarkan",
                column: "LHDNEInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkan_LHDNMSICId",
                table: "AkNotaDebitKreditDikeluarkan",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkanObjek_AkCartaId",
                table: "AkNotaDebitKreditDikeluarkanObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkanObjek_AkNotaDebitKreditDikeluarkanId",
                table: "AkNotaDebitKreditDikeluarkanObjek",
                column: "AkNotaDebitKreditDikeluarkanId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkanObjek_JKWPTJBahagianId",
                table: "AkNotaDebitKreditDikeluarkanObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkanPerihal_AkNotaDebitKreditDikeluarkanId",
                table: "AkNotaDebitKreditDikeluarkanPerihal",
                column: "AkNotaDebitKreditDikeluarkanId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkanPerihal_LHDNKodKlasifikasiId",
                table: "AkNotaDebitKreditDikeluarkanPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDikeluarkanPerihal_LHDNUnitUkuranId",
                table: "AkNotaDebitKreditDikeluarkanPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterima_AkBelianId",
                table: "AkNotaDebitKreditDiterima",
                column: "AkBelianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterima_DPekerjaPostingId",
                table: "AkNotaDebitKreditDiterima",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterima_DPelulusId",
                table: "AkNotaDebitKreditDiterima",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterima_DPengesahId",
                table: "AkNotaDebitKreditDiterima",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterima_DPenyemakId",
                table: "AkNotaDebitKreditDiterima",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterima_JKWId",
                table: "AkNotaDebitKreditDiterima",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterima_LHDNEInvoisId",
                table: "AkNotaDebitKreditDiterima",
                column: "LHDNEInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterima_LHDNMSICId",
                table: "AkNotaDebitKreditDiterima",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterimaObjek_AkCartaId",
                table: "AkNotaDebitKreditDiterimaObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterimaObjek_AkNotaDebitKreditDiterimaId",
                table: "AkNotaDebitKreditDiterimaObjek",
                column: "AkNotaDebitKreditDiterimaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterimaObjek_JKWPTJBahagianId",
                table: "AkNotaDebitKreditDiterimaObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterimaPerihal_AkNotaDebitKreditDiterimaId",
                table: "AkNotaDebitKreditDiterimaPerihal",
                column: "AkNotaDebitKreditDiterimaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterimaPerihal_LHDNKodKlasifikasiId",
                table: "AkNotaDebitKreditDiterimaPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaDebitKreditDiterimaPerihal_LHDNUnitUkuranId",
                table: "AkNotaDebitKreditDiterimaPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMinta_DDaftarAwamId",
                table: "AkNotaMinta",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMinta_DPekerjaPostingId",
                table: "AkNotaMinta",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMinta_DPelulusId",
                table: "AkNotaMinta",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMinta_DPemohonId",
                table: "AkNotaMinta",
                column: "DPemohonId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMinta_DPengesahId",
                table: "AkNotaMinta",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMinta_DPenyemakId",
                table: "AkNotaMinta",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMinta_JKWId",
                table: "AkNotaMinta",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMinta_LHDNMSICId",
                table: "AkNotaMinta",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMintaObjek_AkCartaId",
                table: "AkNotaMintaObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMintaObjek_AkNotaMintaId",
                table: "AkNotaMintaObjek",
                column: "AkNotaMintaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMintaObjek_JKWPTJBahagianId",
                table: "AkNotaMintaObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMintaPerihal_AkNotaMintaId",
                table: "AkNotaMintaPerihal",
                column: "AkNotaMintaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMintaPerihal_LHDNKodKlasifikasiId",
                table: "AkNotaMintaPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkNotaMintaPerihal_LHDNUnitUkuranId",
                table: "AkNotaMintaPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPanjarLejar_AkCartaId",
                table: "AkPanjarLejar",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPanjarLejar_AkCVId",
                table: "AkPanjarLejar",
                column: "AkCVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPanjarLejar_AkJurnalId",
                table: "AkPanjarLejar",
                column: "AkJurnalId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPanjarLejar_AkPVId",
                table: "AkPanjarLejar",
                column: "AkPVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPanjarLejar_AkRekupId",
                table: "AkPanjarLejar",
                column: "AkRekupId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPanjarLejar_DPanjarId",
                table: "AkPanjarLejar",
                column: "DPanjarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPanjarLejar_JKWPTJBahagianId",
                table: "AkPanjarLejar",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanInden_AkIndenId",
                table: "AkPelarasanInden",
                column: "AkIndenId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanInden_DPekerjaPostingId",
                table: "AkPelarasanInden",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanInden_DPelulusId",
                table: "AkPelarasanInden",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanInden_DPengesahId",
                table: "AkPelarasanInden",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanInden_DPenyemakId",
                table: "AkPelarasanInden",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanInden_JKWId",
                table: "AkPelarasanInden",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanInden_LHDNMSICId",
                table: "AkPelarasanInden",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanIndenObjek_AkCartaId",
                table: "AkPelarasanIndenObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanIndenObjek_AkPelarasanIndenId",
                table: "AkPelarasanIndenObjek",
                column: "AkPelarasanIndenId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanIndenObjek_JKWPTJBahagianId",
                table: "AkPelarasanIndenObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanIndenPerihal_AkPelarasanIndenId",
                table: "AkPelarasanIndenPerihal",
                column: "AkPelarasanIndenId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanIndenPerihal_LHDNKodKlasifikasiId",
                table: "AkPelarasanIndenPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanIndenPerihal_LHDNUnitUkuranId",
                table: "AkPelarasanIndenPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPO_AkPOId",
                table: "AkPelarasanPO",
                column: "AkPOId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPO_DPekerjaPostingId",
                table: "AkPelarasanPO",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPO_DPelulusId",
                table: "AkPelarasanPO",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPO_DPengesahId",
                table: "AkPelarasanPO",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPO_DPenyemakId",
                table: "AkPelarasanPO",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPO_JKWId",
                table: "AkPelarasanPO",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPO_LHDNMSICId",
                table: "AkPelarasanPO",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPOObjek_AkCartaId",
                table: "AkPelarasanPOObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPOObjek_AkPelarasanPOId",
                table: "AkPelarasanPOObjek",
                column: "AkPelarasanPOId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPOObjek_JKWPTJBahagianId",
                table: "AkPelarasanPOObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPOPerihal_AkPelarasanPOId",
                table: "AkPelarasanPOPerihal",
                column: "AkPelarasanPOId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPOPerihal_LHDNKodKlasifikasiId",
                table: "AkPelarasanPOPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPelarasanPOPerihal_LHDNUnitUkuranId",
                table: "AkPelarasanPOPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehan_DDaftarAwamId",
                table: "AkPenilaianPerolehan",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehan_DPekerjaPostingId",
                table: "AkPenilaianPerolehan",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehan_DPelulusId",
                table: "AkPenilaianPerolehan",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehan_DPemohonId",
                table: "AkPenilaianPerolehan",
                column: "DPemohonId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehan_DPengesahId",
                table: "AkPenilaianPerolehan",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehan_DPenyemakId",
                table: "AkPenilaianPerolehan",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehan_JKWId",
                table: "AkPenilaianPerolehan",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehan_LHDNMSICId",
                table: "AkPenilaianPerolehan",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehanObjek_AkCartaId",
                table: "AkPenilaianPerolehanObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehanObjek_AkPenilaianPerolehanId",
                table: "AkPenilaianPerolehanObjek",
                column: "AkPenilaianPerolehanId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehanObjek_JKWPTJBahagianId",
                table: "AkPenilaianPerolehanObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehanPerihal_AkPenilaianPerolehanId",
                table: "AkPenilaianPerolehanPerihal",
                column: "AkPenilaianPerolehanId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehanPerihal_LHDNKodKlasifikasiId",
                table: "AkPenilaianPerolehanPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenilaianPerolehanPerihal_LHDNUnitUkuranId",
                table: "AkPenilaianPerolehanPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungut_AkBankId",
                table: "AkPenyataPemungut",
                column: "AkBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungut_DPekerjaPostingId",
                table: "AkPenyataPemungut",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungut_DPelulusId",
                table: "AkPenyataPemungut",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungut_DPengesahId",
                table: "AkPenyataPemungut",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungut_DPenyemakId",
                table: "AkPenyataPemungut",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungut_JCaraBayarId",
                table: "AkPenyataPemungut",
                column: "JCaraBayarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungut_JCawanganId",
                table: "AkPenyataPemungut",
                column: "JCawanganId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungut_JPTJId",
                table: "AkPenyataPemungut",
                column: "JPTJId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungutObjek_AkCartaId",
                table: "AkPenyataPemungutObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungutObjek_AkPenyataPemungutId",
                table: "AkPenyataPemungutObjek",
                column: "AkPenyataPemungutId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungutObjek_AkTerimaTunggalId",
                table: "AkPenyataPemungutObjek",
                column: "AkTerimaTunggalId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyataPemungutObjek_JKWPTJBahagianId",
                table: "AkPenyataPemungutObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyesuaianBank_AkBankId",
                table: "AkPenyesuaianBank",
                column: "AkBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyesuaianBank_DPekerjaPostingId",
                table: "AkPenyesuaianBank",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyesuaianBank_DPelulusId",
                table: "AkPenyesuaianBank",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyesuaianBank_DPengesahId",
                table: "AkPenyesuaianBank",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyesuaianBank_DPenyemakId",
                table: "AkPenyesuaianBank",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPenyesuaianBankPenyataBank_AkPenyesuaianBankId",
                table: "AkPenyesuaianBankPenyataBank",
                column: "AkPenyesuaianBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPO_AkPenilaianPerolehanId",
                table: "AkPO",
                column: "AkPenilaianPerolehanId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPO_DDaftarAwamId",
                table: "AkPO",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPO_DPekerjaPostingId",
                table: "AkPO",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPO_DPelulusId",
                table: "AkPO",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPO_DPengesahId",
                table: "AkPO",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPO_DPenyemakId",
                table: "AkPO",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPO_JKWId",
                table: "AkPO",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPO_LHDNMSICId",
                table: "AkPO",
                column: "LHDNMSICId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPOObjek_AkCartaId",
                table: "AkPOObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPOObjek_AkPOId",
                table: "AkPOObjek",
                column: "AkPOId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPOObjek_JKWPTJBahagianId",
                table: "AkPOObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPOPerihal_AkPOId",
                table: "AkPOPerihal",
                column: "AkPOId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPOPerihal_LHDNKodKlasifikasiId",
                table: "AkPOPerihal",
                column: "LHDNKodKlasifikasiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPOPerihal_LHDNUnitUkuranId",
                table: "AkPOPerihal",
                column: "LHDNUnitUkuranId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPV_AkBankId",
                table: "AkPV",
                column: "AkBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPV_AkJanaanProfilId",
                table: "AkPV",
                column: "AkJanaanProfilId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPV_DPekerjaPostingId",
                table: "AkPV",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPV_DPelulusId",
                table: "AkPV",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPV_DPengesahId",
                table: "AkPV",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPV_DPenyemakId",
                table: "AkPV",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPV_JCawanganId",
                table: "AkPV",
                column: "JCawanganId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPV_JKWId",
                table: "AkPV",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPV_SuGajiBulananId",
                table: "AkPV",
                column: "SuGajiBulananId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVInvois_AkBelianId",
                table: "AkPVInvois",
                column: "AkBelianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVInvois_AkPVId",
                table: "AkPVInvois",
                column: "AkPVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVObjek_AkCartaId",
                table: "AkPVObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVObjek_AkPVId",
                table: "AkPVObjek",
                column: "AkPVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVObjek_JCukaiId",
                table: "AkPVObjek",
                column: "JCukaiId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVObjek_JKWPTJBahagianId",
                table: "AkPVObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVPenerima_AkJanaanProfilPenerimaId",
                table: "AkPVPenerima",
                column: "AkJanaanProfilPenerimaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVPenerima_AkPVId",
                table: "AkPVPenerima",
                column: "AkPVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVPenerima_AkRekupId",
                table: "AkPVPenerima",
                column: "AkRekupId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVPenerima_DDaftarAwamId",
                table: "AkPVPenerima",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVPenerima_DPanjarId",
                table: "AkPVPenerima",
                column: "DPanjarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVPenerima_DPekerjaId",
                table: "AkPVPenerima",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVPenerima_JBankId",
                table: "AkPVPenerima",
                column: "JBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkPVPenerima_JCaraBayarId",
                table: "AkPVPenerima",
                column: "JCaraBayarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkRekup_DPanjarId",
                table: "AkRekup",
                column: "DPanjarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_AkBankId",
                table: "AkTerima",
                column: "AkBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_AkPVId",
                table: "AkTerima",
                column: "AkPVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_DDaftarAwamId",
                table: "AkTerima",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_DPekerjaId",
                table: "AkTerima",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_DPekerjaPostingId",
                table: "AkTerima",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_DPelulusId",
                table: "AkTerima",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_DPengesahId",
                table: "AkTerima",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_DPenyemakId",
                table: "AkTerima",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_JCawanganId",
                table: "AkTerima",
                column: "JCawanganId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_JKWId",
                table: "AkTerima",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerima_JNegeriId",
                table: "AkTerima",
                column: "JNegeriId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaCaraBayar_AkTerimaId",
                table: "AkTerimaCaraBayar",
                column: "AkTerimaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaCaraBayar_JCaraBayarId",
                table: "AkTerimaCaraBayar",
                column: "JCaraBayarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaInvois_AkInvoisId",
                table: "AkTerimaInvois",
                column: "AkInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaInvois_AkTerimaId",
                table: "AkTerimaInvois",
                column: "AkTerimaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaObjek_AkCartaId",
                table: "AkTerimaObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaObjek_AkTerimaId",
                table: "AkTerimaObjek",
                column: "AkTerimaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaObjek_JKWPTJBahagianId",
                table: "AkTerimaObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_AkBankId",
                table: "AkTerimaTunggal",
                column: "AkBankId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_AkPVId",
                table: "AkTerimaTunggal",
                column: "AkPVId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_DDaftarAwamId",
                table: "AkTerimaTunggal",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_DPekerjaId",
                table: "AkTerimaTunggal",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_DPekerjaPostingId",
                table: "AkTerimaTunggal",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_DPelulusId",
                table: "AkTerimaTunggal",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_DPengesahId",
                table: "AkTerimaTunggal",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_DPenyemakId",
                table: "AkTerimaTunggal",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_JCaraBayarId",
                table: "AkTerimaTunggal",
                column: "JCaraBayarId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_JCawanganId",
                table: "AkTerimaTunggal",
                column: "JCawanganId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_JKWId",
                table: "AkTerimaTunggal",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggal_JNegeriId",
                table: "AkTerimaTunggal",
                column: "JNegeriId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggalInvois_AkInvoisId",
                table: "AkTerimaTunggalInvois",
                column: "AkInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggalInvois_AkTerimaTunggalId",
                table: "AkTerimaTunggalInvois",
                column: "AkTerimaTunggalId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggalObjek_AkCartaId",
                table: "AkTerimaTunggalObjek",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggalObjek_AkTerimaTunggalId",
                table: "AkTerimaTunggalObjek",
                column: "AkTerimaTunggalId");

            migrationBuilder.CreateIndex(
                name: "IX_AkTerimaTunggalObjek_JKWPTJBahagianId",
                table: "AkTerimaTunggalObjek",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_AppLog_DPekerjaId",
                table: "AppLog",
                column: "DPekerjaId");

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
                name: "IX_AspNetUsers_DPekerjaId",
                table: "AspNetUsers",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DDaftarAwam_JBankId",
                table: "DDaftarAwam",
                column: "JBankId");

            migrationBuilder.CreateIndex(
                name: "IX_DDaftarAwam_JNegeriId",
                table: "DDaftarAwam",
                column: "JNegeriId");

            migrationBuilder.CreateIndex(
                name: "IX_DKonfigKelulusan_DPekerjaId",
                table: "DKonfigKelulusan",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_DKonfigKelulusan_JBahagianId",
                table: "DKonfigKelulusan",
                column: "JBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_DPanjar_AkCartaId",
                table: "DPanjar",
                column: "AkCartaId");

            migrationBuilder.CreateIndex(
                name: "IX_DPanjar_JCawanganId",
                table: "DPanjar",
                column: "JCawanganId");

            migrationBuilder.CreateIndex(
                name: "IX_DPanjar_JKWPTJBahagianId",
                table: "DPanjar",
                column: "JKWPTJBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_DPanjarPemegang_DPanjarId",
                table: "DPanjarPemegang",
                column: "DPanjarId");

            migrationBuilder.CreateIndex(
                name: "IX_DPanjarPemegang_DPekerjaId",
                table: "DPanjarPemegang",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_DPekerja_JBahagianId",
                table: "DPekerja",
                column: "JBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_DPekerja_JBangsaId",
                table: "DPekerja",
                column: "JBangsaId");

            migrationBuilder.CreateIndex(
                name: "IX_DPekerja_JBankId",
                table: "DPekerja",
                column: "JBankId");

            migrationBuilder.CreateIndex(
                name: "IX_DPekerja_JCawanganId",
                table: "DPekerja",
                column: "JCawanganId");

            migrationBuilder.CreateIndex(
                name: "IX_DPekerja_JNegeriId",
                table: "DPekerja",
                column: "JNegeriId");

            migrationBuilder.CreateIndex(
                name: "IX_DPekerja_JPTJId",
                table: "DPekerja",
                column: "JPTJId");

            migrationBuilder.CreateIndex(
                name: "IX_DPekerjaElaunPotongan_DPekerjaId",
                table: "DPekerjaElaunPotongan",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_DPekerjaElaunPotongan_JElaunPotonganId",
                table: "DPekerjaElaunPotongan",
                column: "JElaunPotonganId");

            migrationBuilder.CreateIndex(
                name: "IX_DPenerimaCekGaji_DDaftarAwamId",
                table: "DPenerimaCekGaji",
                column: "DDaftarAwamId");

            migrationBuilder.CreateIndex(
                name: "IX_DPenerimaCekGaji_JCaraBayarId",
                table: "DPenerimaCekGaji",
                column: "JCaraBayarId");

            migrationBuilder.CreateIndex(
                name: "IX_DPenerimaCekGaji_JCawanganId",
                table: "DPenerimaCekGaji",
                column: "JCawanganId");

            migrationBuilder.CreateIndex(
                name: "IX_DPenerimaZakat_JBankId",
                table: "DPenerimaZakat",
                column: "JBankId");

            migrationBuilder.CreateIndex(
                name: "IX_DPenerimaZakat_JNegeriId",
                table: "DPenerimaZakat",
                column: "JNegeriId");

            migrationBuilder.CreateIndex(
                name: "IX_DPenyelia_DPekerjaId",
                table: "DPenyelia",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_DPenyelia_JCawanganId",
                table: "DPenyelia",
                column: "JCawanganId");

            migrationBuilder.CreateIndex(
                name: "IX_JCawangan_AkBankId",
                table: "JCawangan",
                column: "AkBankId");

            migrationBuilder.CreateIndex(
                name: "IX_JKonfigPenyataBaris_JKonfigPenyataId",
                table: "JKonfigPenyataBaris",
                column: "JKonfigPenyataId");

            migrationBuilder.CreateIndex(
                name: "IX_JKonfigPenyataBarisFormula_JKonfigPenyataBarisId",
                table: "JKonfigPenyataBarisFormula",
                column: "JKonfigPenyataBarisId");

            migrationBuilder.CreateIndex(
                name: "IX_JKonfigPerubahanEkuiti_JKWId",
                table: "JKonfigPerubahanEkuiti",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_JKonfigPerubahanEkuitiBaris_JKonfigPerubahanEkuitiId",
                table: "JKonfigPerubahanEkuitiBaris",
                column: "JKonfigPerubahanEkuitiId");

            migrationBuilder.CreateIndex(
                name: "IX_JKWPTJBahagian_JBahagianId",
                table: "JKWPTJBahagian",
                column: "JBahagianId");

            migrationBuilder.CreateIndex(
                name: "IX_JKWPTJBahagian_JKWId",
                table: "JKWPTJBahagian",
                column: "JKWId");

            migrationBuilder.CreateIndex(
                name: "IX_JKWPTJBahagian_JPTJId",
                table: "JKWPTJBahagian",
                column: "JPTJId");

            migrationBuilder.CreateIndex(
                name: "IX_LHDNEInvois_DPekerjaPostingId",
                table: "LHDNEInvois",
                column: "DPekerjaPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_LHDNEInvois_DPelulusId",
                table: "LHDNEInvois",
                column: "DPelulusId");

            migrationBuilder.CreateIndex(
                name: "IX_LHDNEInvois_DPengesahId",
                table: "LHDNEInvois",
                column: "DPengesahId");

            migrationBuilder.CreateIndex(
                name: "IX_LHDNEInvois_DPenyemakId",
                table: "LHDNEInvois",
                column: "DPenyemakId");

            migrationBuilder.CreateIndex(
                name: "IX_LHDNEInvoisPerihal_LHDNEInvoisId",
                table: "LHDNEInvoisPerihal",
                column: "LHDNEInvoisId");

            migrationBuilder.CreateIndex(
                name: "IX_SuGajiBulananPekerja_DPekerjaId",
                table: "SuGajiBulananPekerja",
                column: "DPekerjaId");

            migrationBuilder.CreateIndex(
                name: "IX_SuGajiBulananPekerja_SuGajiBulananId",
                table: "SuGajiBulananPekerja",
                column: "SuGajiBulananId");

            migrationBuilder.CreateIndex(
                name: "IX_SuGajiElaunPotongan_JElaunPotonganId",
                table: "SuGajiElaunPotongan",
                column: "JElaunPotonganId");

            migrationBuilder.CreateIndex(
                name: "IX_SuGajiElaunPotongan_SuGajiBulananPekerjaId",
                table: "SuGajiElaunPotongan",
                column: "SuGajiBulananPekerjaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbBukuVot");

            migrationBuilder.DropTable(
                name: "AbWaranObjek");

            migrationBuilder.DropTable(
                name: "AkAkaunPenyataBank");

            migrationBuilder.DropTable(
                name: "AkAnggarLejar");

            migrationBuilder.DropTable(
                name: "AkAnggarObjek");

            migrationBuilder.DropTable(
                name: "AkBelianObjek");

            migrationBuilder.DropTable(
                name: "AkBelianPerihal");

            migrationBuilder.DropTable(
                name: "AkCVObjek");

            migrationBuilder.DropTable(
                name: "AkEFTPenerima");

            migrationBuilder.DropTable(
                name: "AkIndenObjek");

            migrationBuilder.DropTable(
                name: "AkIndenPerihal");

            migrationBuilder.DropTable(
                name: "AkInvoisObjek");

            migrationBuilder.DropTable(
                name: "AkInvoisPerihal");

            migrationBuilder.DropTable(
                name: "AkJurnalObjek");

            migrationBuilder.DropTable(
                name: "AkJurnalPenerimaCekBatal");

            migrationBuilder.DropTable(
                name: "AkNotaDebitKreditDikeluarkanObjek");

            migrationBuilder.DropTable(
                name: "AkNotaDebitKreditDikeluarkanPerihal");

            migrationBuilder.DropTable(
                name: "AkNotaDebitKreditDiterimaObjek");

            migrationBuilder.DropTable(
                name: "AkNotaDebitKreditDiterimaPerihal");

            migrationBuilder.DropTable(
                name: "AkNotaMintaObjek");

            migrationBuilder.DropTable(
                name: "AkNotaMintaPerihal");

            migrationBuilder.DropTable(
                name: "AkPanjarLejar");

            migrationBuilder.DropTable(
                name: "AkPelarasanIndenObjek");

            migrationBuilder.DropTable(
                name: "AkPelarasanIndenPerihal");

            migrationBuilder.DropTable(
                name: "AkPelarasanPOObjek");

            migrationBuilder.DropTable(
                name: "AkPelarasanPOPerihal");

            migrationBuilder.DropTable(
                name: "AkPenilaianPerolehanObjek");

            migrationBuilder.DropTable(
                name: "AkPenilaianPerolehanPerihal");

            migrationBuilder.DropTable(
                name: "AkPenyataPemungutObjek");

            migrationBuilder.DropTable(
                name: "AkPOObjek");

            migrationBuilder.DropTable(
                name: "AkPOPerihal");

            migrationBuilder.DropTable(
                name: "AkPVInvois");

            migrationBuilder.DropTable(
                name: "AkPVObjek");

            migrationBuilder.DropTable(
                name: "AkTerimaCaraBayar");

            migrationBuilder.DropTable(
                name: "AkTerimaInvois");

            migrationBuilder.DropTable(
                name: "AkTerimaObjek");

            migrationBuilder.DropTable(
                name: "AkTerimaTunggalInvois");

            migrationBuilder.DropTable(
                name: "AkTerimaTunggalObjek");

            migrationBuilder.DropTable(
                name: "AppLog");

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
                name: "DPanjarPemegang");

            migrationBuilder.DropTable(
                name: "DPekerjaElaunPotongan");

            migrationBuilder.DropTable(
                name: "DPenerimaCekGaji");

            migrationBuilder.DropTable(
                name: "DPenyelia");

            migrationBuilder.DropTable(
                name: "ExceptionLogger");

            migrationBuilder.DropTable(
                name: "JAgama");

            migrationBuilder.DropTable(
                name: "JKategoriPCB");

            migrationBuilder.DropTable(
                name: "JKonfigPenyataBarisFormula");

            migrationBuilder.DropTable(
                name: "JKonfigPerubahanEkuitiBaris");

            migrationBuilder.DropTable(
                name: "LHDNEInvoisPerihal");

            migrationBuilder.DropTable(
                name: "SiAppInfo");

            migrationBuilder.DropTable(
                name: "SuGajiElaunPotongan");

            migrationBuilder.DropTable(
                name: "AbWaran");

            migrationBuilder.DropTable(
                name: "AkAkaun");

            migrationBuilder.DropTable(
                name: "AkPVPenerima");

            migrationBuilder.DropTable(
                name: "AkPenyesuaianBankPenyataBank");

            migrationBuilder.DropTable(
                name: "AkAnggar");

            migrationBuilder.DropTable(
                name: "AkEFT");

            migrationBuilder.DropTable(
                name: "AkNotaDebitKreditDikeluarkan");

            migrationBuilder.DropTable(
                name: "AkNotaDebitKreditDiterima");

            migrationBuilder.DropTable(
                name: "AkCV");

            migrationBuilder.DropTable(
                name: "AkJurnal");

            migrationBuilder.DropTable(
                name: "AkPelarasanInden");

            migrationBuilder.DropTable(
                name: "AkPelarasanPO");

            migrationBuilder.DropTable(
                name: "AkPenyataPemungut");

            migrationBuilder.DropTable(
                name: "LHDNKodKlasifikasi");

            migrationBuilder.DropTable(
                name: "LHDNUnitUkuran");

            migrationBuilder.DropTable(
                name: "JCukai");

            migrationBuilder.DropTable(
                name: "AkTerima");

            migrationBuilder.DropTable(
                name: "AkTerimaTunggal");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "JKonfigPenyataBaris");

            migrationBuilder.DropTable(
                name: "JKonfigPerubahanEkuiti");

            migrationBuilder.DropTable(
                name: "JElaunPotongan");

            migrationBuilder.DropTable(
                name: "SuGajiBulananPekerja");

            migrationBuilder.DropTable(
                name: "AkJanaanProfilPenerima");

            migrationBuilder.DropTable(
                name: "AkPenyesuaianBank");

            migrationBuilder.DropTable(
                name: "AkInvois");

            migrationBuilder.DropTable(
                name: "AkBelian");

            migrationBuilder.DropTable(
                name: "AkPV");

            migrationBuilder.DropTable(
                name: "JKonfigPenyata");

            migrationBuilder.DropTable(
                name: "AkRekup");

            migrationBuilder.DropTable(
                name: "DPenerimaZakat");

            migrationBuilder.DropTable(
                name: "JCaraBayar");

            migrationBuilder.DropTable(
                name: "AkInden");

            migrationBuilder.DropTable(
                name: "AkNotaMinta");

            migrationBuilder.DropTable(
                name: "AkPO");

            migrationBuilder.DropTable(
                name: "LHDNEInvois");

            migrationBuilder.DropTable(
                name: "AkJanaanProfil");

            migrationBuilder.DropTable(
                name: "SuGajiBulanan");

            migrationBuilder.DropTable(
                name: "DPanjar");

            migrationBuilder.DropTable(
                name: "AkPenilaianPerolehan");

            migrationBuilder.DropTable(
                name: "JKWPTJBahagian");

            migrationBuilder.DropTable(
                name: "DDaftarAwam");

            migrationBuilder.DropTable(
                name: "DKonfigKelulusan");

            migrationBuilder.DropTable(
                name: "LHDNMSIC");

            migrationBuilder.DropTable(
                name: "DPekerja");

            migrationBuilder.DropTable(
                name: "JBahagian");

            migrationBuilder.DropTable(
                name: "JBangsa");

            migrationBuilder.DropTable(
                name: "JCawangan");

            migrationBuilder.DropTable(
                name: "JNegeri");

            migrationBuilder.DropTable(
                name: "JPTJ");

            migrationBuilder.DropTable(
                name: "AkBank");

            migrationBuilder.DropTable(
                name: "AkCarta");

            migrationBuilder.DropTable(
                name: "JBank");

            migrationBuilder.DropTable(
                name: "JKW");
        }
    }
}
