using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LG.NetCore.Sample.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sample_Author",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(64) CHARACTER SET utf8mb4", maxLength: 64, nullable: false, comment: "姓名"),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, comment: "出生日期"),
                    Profile = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true, comment: "个人简介"),
                    ExtraProperties = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sample_Book",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false, comment: "名称"),
                    BookType = table.Column<int>(type: "int", nullable: false, comment: "类型"),
                    PublishDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, comment: "出版日期"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "价格"),
                    AuthorId = table.Column<Guid>(type: "char(36)", nullable: true, comment: "作者Id"),
                    CoverUrl = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: true, comment: "封面"),
                    ExtraProperties = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sample_BookInBookShop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    BookId = table.Column<Guid>(type: "char(36)", nullable: false, comment: "书籍Id"),
                    BookShopId = table.Column<Guid>(type: "char(36)", nullable: false, comment: "书店Id"),
                    Num = table.Column<int>(type: "int", nullable: false, comment: "数量")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample_BookInBookShop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sample_BookShop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Code = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false, comment: "编码"),
                    Name = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false, comment: "名称"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true, comment: "租户Id"),
                    OwnerId = table.Column<Guid>(type: "char(36)", nullable: true, comment: "Boss"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, comment: "UserId"),
                    ExtraProperties = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40) CHARACTER SET utf8mb4", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsStop = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    StopUserId = table.Column<Guid>(type: "char(36)", nullable: true),
                    StopTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample_BookShop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sample_BookShopOwner",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false, comment: "名称")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample_BookShopOwner", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sample_Author_Name",
                table: "Sample_Author",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sample_Author");

            migrationBuilder.DropTable(
                name: "Sample_Book");

            migrationBuilder.DropTable(
                name: "Sample_BookInBookShop");

            migrationBuilder.DropTable(
                name: "Sample_BookShop");

            migrationBuilder.DropTable(
                name: "Sample_BookShopOwner");
        }
    }
}
