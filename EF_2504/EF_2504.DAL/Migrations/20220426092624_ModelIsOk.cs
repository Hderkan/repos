using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_2504.DAL.Migrations
{
    public partial class ModelIsOk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookCreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 12, 26, 23, 881, DateTimeKind.Local).AddTicks(6452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 25, 14, 54, 52, 560, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 12, 26, 23, 865, DateTimeKind.Local).AddTicks(179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 25, 14, 54, 52, 528, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    BookAuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => x.BookAuthorId);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookImageUrl", "BookName", "CategoryId" },
                values: new object[] { 1, "https://www.kelepirkitap.com/Uploads/UrunResimleri/nobel-yayinlari-yonetim-bilisim-sistemle-7411.jpg", "yönetim bilisim sistemleri", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookImageUrl", "BookName", "CategoryId" },
                values: new object[] { 2, "https://yandex.com.tr/gorsel/search?from=tabbar&text=a%20dan%20zye&pos=3&img_url=https%3A%2F%2Fcdn1.bumudur.com%2FproductImages%2F4de123d4b88eb5f19de6d1a62315a6d8_org_1.jpg&rpt=simage", "a dan z ye", 2 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookImageUrl", "BookName", "CategoryId" },
                values: new object[] { 3, "https://kitapdostum.com/Content/Images/Kitap/302276.jpg", "sefiller", 3 });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "BookDetailId", "BookDetailCity", "BookDetailCountry", "BookDetailYear", "BookId" },
                values: new object[,]
                {
                    { 1, null, null, 2021, 1 },
                    { 2, null, null, 2021, 2 },
                    { 3, null, null, 2021, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookId",
                table: "BookDetails",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetails_Books_BookId",
                table: "BookDetails",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetails_Books_BookId",
                table: "BookDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropIndex(
                name: "IX_BookDetails_BookId",
                table: "BookDetails");

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "BookDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "BookDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookDetails",
                keyColumn: "BookDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BookDetails");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookCreatedDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 25, 14, 54, 52, 560, DateTimeKind.Local).AddTicks(9468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 12, 26, 23, 881, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreatedDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 25, 14, 54, 52, 528, DateTimeKind.Local).AddTicks(6053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 12, 26, 23, 865, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
