using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class DataBaseModifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Descriptions_DescriptionId",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_Produits_Stocks_StockId",
                table: "Produits");

            migrationBuilder.DropForeignKey(
                name: "FK_ProduitTag_Produits_ProduitId",
                table: "ProduitTag");

            migrationBuilder.DropTable(
                name: "ImageProduit");

            migrationBuilder.DropIndex(
                name: "IX_Produits_DescriptionId",
                table: "Produits");

            migrationBuilder.DropIndex(
                name: "IX_Produits_StockId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Produits");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Produits");

            migrationBuilder.RenameColumn(
                name: "ProduitId",
                table: "ProduitTag",
                newName: "ProduitsId");

            migrationBuilder.AddColumn<int>(
                name: "ProduitId",
                table: "Stocks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProduitId",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProduitId",
                table: "Descriptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProduitId",
                table: "Stocks",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProduitId",
                table: "Images",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_ProduitId",
                table: "Descriptions",
                column: "ProduitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Descriptions_Produits_ProduitId",
                table: "Descriptions",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Produits_ProduitId",
                table: "Images",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitTag_Produits_ProduitsId",
                table: "ProduitTag",
                column: "ProduitsId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Produits_ProduitId",
                table: "Stocks",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descriptions_Produits_ProduitId",
                table: "Descriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Produits_ProduitId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_ProduitTag_Produits_ProduitsId",
                table: "ProduitTag");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Produits_ProduitId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_ProduitId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProduitId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Descriptions_ProduitId",
                table: "Descriptions");

            migrationBuilder.DropColumn(
                name: "ProduitId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "ProduitId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ProduitId",
                table: "Descriptions");

            migrationBuilder.RenameColumn(
                name: "ProduitsId",
                table: "ProduitTag",
                newName: "ProduitId");

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Produits",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockId",
                table: "Produits",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ImageProduit",
                columns: table => new
                {
                    ImagesId = table.Column<int>(type: "int", nullable: false),
                    ProduitsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageProduit", x => new { x.ImagesId, x.ProduitsId });
                    table.ForeignKey(
                        name: "FK_ImageProduit_Images_ImagesId",
                        column: x => x.ImagesId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageProduit_Produits_ProduitsId",
                        column: x => x.ProduitsId,
                        principalTable: "Produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produits_DescriptionId",
                table: "Produits",
                column: "DescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_StockId",
                table: "Produits",
                column: "StockId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageProduit_ProduitsId",
                table: "ImageProduit",
                column: "ProduitsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Descriptions_DescriptionId",
                table: "Produits",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Produits_Stocks_StockId",
                table: "Produits",
                column: "StockId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProduitTag_Produits_ProduitId",
                table: "ProduitTag",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
