using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class updateproperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Commentaires_ProduitId",
                table: "Commentaires",
                column: "ProduitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commentaires_Produits_ProduitId",
                table: "Commentaires",
                column: "ProduitId",
                principalTable: "Produits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentaires_Produits_ProduitId",
                table: "Commentaires");

            migrationBuilder.DropIndex(
                name: "IX_Commentaires_ProduitId",
                table: "Commentaires");
        }
    }
}
