using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hugin.Sample.Migrations
{
    public partial class AppendStadium : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Sample_BookShop",
                type: "char(36)",
                nullable: true,
                comment: "UserId",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldComment: "UserId");

            migrationBuilder.CreateTable(
                name: "Sample_Stadium",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false, comment: "名称"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, comment: "租户Id"),
                    ExtraProperties = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample_Stadium", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sample_Stadium");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Sample_BookShop",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "UserId",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true,
                oldComment: "UserId");
        }
    }
}
