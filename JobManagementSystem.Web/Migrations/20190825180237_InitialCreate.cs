using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobManagementSystem.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    CreateByEmail = table.Column<string>(nullable: true),
                    CreateBy = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 30, nullable: true),
                    BrithDay = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<bool>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    CreateByEmail = table.Column<string>(nullable: true),
                    CreateBy = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    UpdateAt = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Users_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    CreateByEmail = table.Column<string>(nullable: true),
                    CreateBy = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    FeedbackContent = table.Column<string>(type: "ntext", nullable: true),
                    HandlerUserEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Users_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BrithDay", "CreateAt", "CreateBy", "CreateByEmail", "Email", "FullName", "Gender", "Password", "PhoneNumber", "Role", "Status", "UpdateAt" },
                values: new object[] { 1, "Ha Noi", new DateTime(2019, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 26, 1, 2, 35, 897, DateTimeKind.Local).AddTicks(617), 0, null, "admin@job.com.vn", "Admin", true, "e10adc3949ba59abbe56e057f20f883e", "0123456789", 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CreateBy",
                table: "Categories",
                column: "CreateBy");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Id_Name",
                table: "Categories",
                columns: new[] { "Id", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CreateBy",
                table: "Contacts",
                column: "CreateBy");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Title",
                table: "Contacts",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Id_CreateBy",
                table: "Contacts",
                columns: new[] { "Id", "CreateBy" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_FullName_CreateBy",
                table: "Users",
                columns: new[] { "Role", "FullName", "CreateBy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
