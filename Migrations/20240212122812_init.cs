using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LAST_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GENDER = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMP_ADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHONE_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMAIL_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DATEOFBIRTH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DATEOFJOINING = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHOTO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DEPT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
