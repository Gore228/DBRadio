using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBRadio.Migrations
{
    public partial class _100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GrafikRaboti",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffID = table.Column<long>(type: "bigint", nullable: false),
                    Time1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordID1 = table.Column<long>(type: "bigint", nullable: false),
                    Time2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordID2 = table.Column<long>(type: "bigint", nullable: false),
                    Time3 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecordID3 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrafikRaboti", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sotrudniki",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff_ID = table.Column<long>(type: "bigint", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionID = table.Column<long>(type: "bigint", nullable: false),
                    GrafikRabotiID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sotrudniki", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sotrudniki_GrafikRaboti_GrafikRabotiID",
                        column: x => x.GrafikRabotiID,
                        principalTable: "GrafikRaboti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zapisi",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Record_ID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerformerID = table.Column<long>(type: "bigint", nullable: false),
                    Albom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<long>(type: "bigint", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    GrafikRabotiID = table.Column<long>(type: "bigint", nullable: true),
                    GrafikRabotiID1 = table.Column<long>(type: "bigint", nullable: true),
                    GrafikRabotiID2 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zapisi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zapisi_GrafikRaboti_GrafikRabotiID",
                        column: x => x.GrafikRabotiID,
                        principalTable: "GrafikRaboti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zapisi_GrafikRaboti_GrafikRabotiID1",
                        column: x => x.GrafikRabotiID1,
                        principalTable: "GrafikRaboti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zapisi_GrafikRaboti_GrafikRabotiID2",
                        column: x => x.GrafikRabotiID2,
                        principalTable: "GrafikRaboti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dolzhnosti",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position_ID = table.Column<long>(type: "bigint", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Responsibilities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Demands = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SotrudnikiID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dolzhnosti", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dolzhnosti_Sotrudniki_SotrudnikiID",
                        column: x => x.SotrudnikiID,
                        principalTable: "Sotrudniki",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ispolniteli",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Perfomer_ID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZapisiID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ispolniteli", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ispolniteli_Zapisi_ZapisiID",
                        column: x => x.ZapisiID,
                        principalTable: "Zapisi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zhanri",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genre_ID = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZapisiID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zhanri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zhanri_Zapisi_ZapisiID",
                        column: x => x.ZapisiID,
                        principalTable: "Zapisi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dolzhnosti_SotrudnikiID",
                table: "Dolzhnosti",
                column: "SotrudnikiID");

            migrationBuilder.CreateIndex(
                name: "IX_Ispolniteli_ZapisiID",
                table: "Ispolniteli",
                column: "ZapisiID");

            migrationBuilder.CreateIndex(
                name: "IX_Sotrudniki_GrafikRabotiID",
                table: "Sotrudniki",
                column: "GrafikRabotiID");

            migrationBuilder.CreateIndex(
                name: "IX_Zapisi_GrafikRabotiID",
                table: "Zapisi",
                column: "GrafikRabotiID");

            migrationBuilder.CreateIndex(
                name: "IX_Zapisi_GrafikRabotiID1",
                table: "Zapisi",
                column: "GrafikRabotiID1");

            migrationBuilder.CreateIndex(
                name: "IX_Zapisi_GrafikRabotiID2",
                table: "Zapisi",
                column: "GrafikRabotiID2");

            migrationBuilder.CreateIndex(
                name: "IX_Zhanri_ZapisiID",
                table: "Zhanri",
                column: "ZapisiID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dolzhnosti");

            migrationBuilder.DropTable(
                name: "Ispolniteli");

            migrationBuilder.DropTable(
                name: "Zhanri");

            migrationBuilder.DropTable(
                name: "Sotrudniki");

            migrationBuilder.DropTable(
                name: "Zapisi");

            migrationBuilder.DropTable(
                name: "GrafikRaboti");
        }
    }
}
