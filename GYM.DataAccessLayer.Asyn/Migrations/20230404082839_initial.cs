using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GYM.DataAccessLayer.Asyn.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseEntitity",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseEntitity", x => x.courseId);
                });

            migrationBuilder.CreateTable(
                name: "salonEntitity",
                columns: table => new
                {
                    salonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salonName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salonEntitity", x => x.salonId);
                });

            migrationBuilder.CreateTable(
                name: "tranierEntitity",
                columns: table => new
                {
                    tranierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tranierName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tranierEntitity", x => x.tranierId);
                });

            migrationBuilder.CreateTable(
                name: "userEntitity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salonId = table.Column<int>(type: "int", nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    tranierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userEntitity", x => x.id);
                    table.ForeignKey(
                        name: "FK_userEntitity_courseEntitity_courseId",
                        column: x => x.courseId,
                        principalTable: "courseEntitity",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userEntitity_salonEntitity_salonId",
                        column: x => x.salonId,
                        principalTable: "salonEntitity",
                        principalColumn: "salonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userEntitity_tranierEntitity_tranierId",
                        column: x => x.tranierId,
                        principalTable: "tranierEntitity",
                        principalColumn: "tranierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_userEntitity_courseId",
                table: "userEntitity",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_userEntitity_salonId",
                table: "userEntitity",
                column: "salonId");

            migrationBuilder.CreateIndex(
                name: "IX_userEntitity_tranierId",
                table: "userEntitity",
                column: "tranierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userEntitity");

            migrationBuilder.DropTable(
                name: "courseEntitity");

            migrationBuilder.DropTable(
                name: "salonEntitity");

            migrationBuilder.DropTable(
                name: "tranierEntitity");
        }
    }
}
