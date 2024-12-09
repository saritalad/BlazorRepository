using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWebApi.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    location = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DeptInfo_VMs",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: true),
                    TotalSalary = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptInfo_VMs", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    salary = table.Column<int>(type: "int", nullable: true),
                    deptid = table.Column<int>(type: "int", nullable: true),
                    email = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    dob = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp", x => x.id);
                    table.ForeignKey(
                        name: "FK__Emp__deptid__1920BF5C",
                        column: x => x.deptid,
                        principalTable: "Dept",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emp_deptid",
                table: "Emp",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "UQ__Emp__AB6E6164085FB7E5",
                table: "Emp",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeptInfo_VMs");

            migrationBuilder.DropTable(
                name: "Emp");

            migrationBuilder.DropTable(
                name: "Dept");
        }
    }
}
