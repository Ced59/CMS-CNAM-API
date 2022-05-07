﻿// <auto-generated />
using System;
using Entities.DatabasesContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220507090944_migrationAfterMerge")]
    partial class migrationAfterMerge
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.DescriptionsEntitie.Description", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateDescription")
                        .HasColumnType("datetime2");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActif")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("Entities.ExemplesEntitie.Exemple", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exemples");
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Commentaire", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.Property<Guid>("ProduitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProduitId");

                    b.ToTable("Commentaires");
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateAjout")
                        .HasColumnType("datetime2");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActif")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProduitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProduitId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Produit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateAjout")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActif")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<double>("Tva")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DescriptionId");

                    b.ToTable("Produits");
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Stock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateReapprovisionnement")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ProduitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProduitId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateAjout")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActif")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Variant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateAjout")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriptif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActif")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Variants");
                });

            modelBuilder.Entity("Entities.UsersEntities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Civilite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProduitTag", b =>
                {
                    b.Property<Guid>("ProduitsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProduitsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("ProduitTag");
                });

            modelBuilder.Entity("ProduitVariant", b =>
                {
                    b.Property<Guid>("ProduitsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VariantsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProduitsId", "VariantsId");

                    b.HasIndex("VariantsId");

                    b.ToTable("ProduitVariant");
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Commentaire", b =>
                {
                    b.HasOne("Entities.ProduitsEntities.Produit", null)
                        .WithMany("Commentaires")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Image", b =>
                {
                    b.HasOne("Entities.ProduitsEntities.Produit", "Produit")
                        .WithMany("Images")
                        .HasForeignKey("ProduitId");

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Produit", b =>
                {
                    b.HasOne("Entities.DescriptionsEntitie.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionId");

                    b.Navigation("Description");
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Stock", b =>
                {
                    b.HasOne("Entities.ProduitsEntities.Produit", "Produit")
                        .WithMany()
                        .HasForeignKey("ProduitId");

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("ProduitTag", b =>
                {
                    b.HasOne("Entities.ProduitsEntities.Produit", null)
                        .WithMany()
                        .HasForeignKey("ProduitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.ProduitsEntities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProduitVariant", b =>
                {
                    b.HasOne("Entities.ProduitsEntities.Produit", null)
                        .WithMany()
                        .HasForeignKey("ProduitsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.ProduitsEntities.Variant", null)
                        .WithMany()
                        .HasForeignKey("VariantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.ProduitsEntities.Produit", b =>
                {
                    b.Navigation("Commentaires");

                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
