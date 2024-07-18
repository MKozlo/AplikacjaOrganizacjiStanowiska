using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplikacja_organizacji_stanowiska_fizycznego_i_wirtualnego.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Odpowiedzialni",
                columns: table => new
                {
                    idOdpowiedzialnego = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odpowiedzialni", x => x.idOdpowiedzialnego);
                });

            migrationBuilder.CreateTable(
                name: "Sprawdzanie",
                columns: table => new
                {
                    idSprawdzajacego = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprawdzanie", x => x.idSprawdzajacego);
                });

            migrationBuilder.CreateTable(
                name: "Kontrole",
                columns: table => new
                {
                    idKontroli = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idOdpowiedzialnego = table.Column<int>(type: "int", nullable: true),
                    idSprawdzajacego = table.Column<int>(type: "int", nullable: true),
                    obszarStanowisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataKontroli = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kontrole", x => x.idKontroli);
                    table.ForeignKey(
                        name: "FK_Kontrole_Odpowiedzialni_idOdpowiedzialnego",
                        column: x => x.idOdpowiedzialnego,
                        principalTable: "Odpowiedzialni",
                        principalColumn: "idOdpowiedzialnego");
                    table.ForeignKey(
                        name: "FK_Kontrole_Sprawdzanie_idSprawdzajacego",
                        column: x => x.idSprawdzajacego,
                        principalTable: "Sprawdzanie",
                        principalColumn: "idSprawdzajacego");
                });

            migrationBuilder.CreateTable(
                name: "PlanyDzialan",
                columns: table => new
                {
                    idPlanuDzialan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idKontroli = table.Column<int>(type: "int", nullable: true),
                    temat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dzial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    obszar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idSprawdzajacego = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanyDzialan", x => x.idPlanuDzialan);
                    table.ForeignKey(
                        name: "FK_PlanyDzialan_Kontrole_idKontroli",
                        column: x => x.idKontroli,
                        principalTable: "Kontrole",
                        principalColumn: "idKontroli");
                    table.ForeignKey(
                        name: "FK_PlanyDzialan_Sprawdzanie_idSprawdzajacego",
                        column: x => x.idSprawdzajacego,
                        principalTable: "Sprawdzanie",
                        principalColumn: "idSprawdzajacego");
                });

            migrationBuilder.CreateTable(
                name: "Pozycje",
                columns: table => new
                {
                    idPozycji = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    poprzedniWynik = table.Column<int>(type: "int", nullable: true),
                    wynikCalkowity = table.Column<int>(type: "int", nullable: true),
                    idKontroli = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pozycje", x => x.idPozycji);
                    table.ForeignKey(
                        name: "FK_Pozycje_Kontrole_idKontroli",
                        column: x => x.idKontroli,
                        principalTable: "Kontrole",
                        principalColumn: "idKontroli");
                });

            migrationBuilder.CreateTable(
                name: "Dzialania",
                columns: table => new
                {
                    idDzialania = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPlanuDzialan = table.Column<int>(type: "int", nullable: true),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    miejsceTemat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    obserwacjeProblemy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dzialania = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idOdpowiedzialnego = table.Column<int>(type: "int", nullable: false),
                    doKiedy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    komentarz = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dzialania", x => x.idDzialania);
                    table.ForeignKey(
                        name: "FK_Dzialania_Odpowiedzialni_idOdpowiedzialnego",
                        column: x => x.idOdpowiedzialnego,
                        principalTable: "Odpowiedzialni",
                        principalColumn: "idOdpowiedzialnego",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dzialania_PlanyDzialan_idPlanuDzialan",
                        column: x => x.idPlanuDzialan,
                        principalTable: "PlanyDzialan",
                        principalColumn: "idPlanuDzialan");
                });

            migrationBuilder.CreateTable(
                name: "Kroki",
                columns: table => new
                {
                    idKroku = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tresc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idPozycji = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kroki", x => x.idKroku);
                    table.ForeignKey(
                        name: "FK_Kroki_Pozycje_idPozycji",
                        column: x => x.idPozycji,
                        principalTable: "Pozycje",
                        principalColumn: "idPozycji",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pytania",
                columns: table => new
                {
                    idPytania = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tresc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idKroku = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pytania", x => x.idPytania);
                    table.ForeignKey(
                        name: "FK_Pytania_Kroki_idKroku",
                        column: x => x.idKroku,
                        principalTable: "Kroki",
                        principalColumn: "idKroku",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Odpowiedzi",
                columns: table => new
                {
                    idOdpowiedzi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tresc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idPytania = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odpowiedzi", x => x.idOdpowiedzi);
                    table.ForeignKey(
                        name: "FK_Odpowiedzi_Pytania_idPytania",
                        column: x => x.idPytania,
                        principalTable: "Pytania",
                        principalColumn: "idPytania",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WynikiOdpowiedzi",
                columns: table => new
                {
                    idWynikuOdpowiedzi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idPozycji = table.Column<int>(type: "int", nullable: true),
                    idOdpowiedzi = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WynikiOdpowiedzi", x => x.idWynikuOdpowiedzi);
                    table.ForeignKey(
                        name: "FK_WynikiOdpowiedzi_Odpowiedzi_idOdpowiedzi",
                        column: x => x.idOdpowiedzi,
                        principalTable: "Odpowiedzi",
                        principalColumn: "idOdpowiedzi");
                    table.ForeignKey(
                        name: "FK_WynikiOdpowiedzi_Pozycje_idPozycji",
                        column: x => x.idPozycji,
                        principalTable: "Pozycje",
                        principalColumn: "idPozycji");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dzialania_idOdpowiedzialnego",
                table: "Dzialania",
                column: "idOdpowiedzialnego");

            migrationBuilder.CreateIndex(
                name: "IX_Dzialania_idPlanuDzialan",
                table: "Dzialania",
                column: "idPlanuDzialan");

            migrationBuilder.CreateIndex(
                name: "IX_Kontrole_idOdpowiedzialnego",
                table: "Kontrole",
                column: "idOdpowiedzialnego");

            migrationBuilder.CreateIndex(
                name: "IX_Kontrole_idSprawdzajacego",
                table: "Kontrole",
                column: "idSprawdzajacego");

            migrationBuilder.CreateIndex(
                name: "IX_Kroki_idPozycji",
                table: "Kroki",
                column: "idPozycji");

            migrationBuilder.CreateIndex(
                name: "IX_Odpowiedzi_idPytania",
                table: "Odpowiedzi",
                column: "idPytania");

            migrationBuilder.CreateIndex(
                name: "IX_PlanyDzialan_idKontroli",
                table: "PlanyDzialan",
                column: "idKontroli");

            migrationBuilder.CreateIndex(
                name: "IX_PlanyDzialan_idSprawdzajacego",
                table: "PlanyDzialan",
                column: "idSprawdzajacego");

            migrationBuilder.CreateIndex(
                name: "IX_Pozycje_idKontroli",
                table: "Pozycje",
                column: "idKontroli");

            migrationBuilder.CreateIndex(
                name: "IX_Pytania_idKroku",
                table: "Pytania",
                column: "idKroku");

            migrationBuilder.CreateIndex(
                name: "IX_WynikiOdpowiedzi_idOdpowiedzi",
                table: "WynikiOdpowiedzi",
                column: "idOdpowiedzi");

            migrationBuilder.CreateIndex(
                name: "IX_WynikiOdpowiedzi_idPozycji",
                table: "WynikiOdpowiedzi",
                column: "idPozycji");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dzialania");

            migrationBuilder.DropTable(
                name: "WynikiOdpowiedzi");

            migrationBuilder.DropTable(
                name: "PlanyDzialan");

            migrationBuilder.DropTable(
                name: "Odpowiedzi");

            migrationBuilder.DropTable(
                name: "Pytania");

            migrationBuilder.DropTable(
                name: "Kroki");

            migrationBuilder.DropTable(
                name: "Pozycje");

            migrationBuilder.DropTable(
                name: "Kontrole");

            migrationBuilder.DropTable(
                name: "Odpowiedzialni");

            migrationBuilder.DropTable(
                name: "Sprawdzanie");
        }
    }
}
