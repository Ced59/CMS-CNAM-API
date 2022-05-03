using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class ajoutTableUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Users",
                newName: "Pseudo");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Civilite",
                table: "Users",
                newName: "Gender");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "PasswordId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Pseudo",
                table: "Users",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Users",
                newName: "Civilite");
        }
    }
}
