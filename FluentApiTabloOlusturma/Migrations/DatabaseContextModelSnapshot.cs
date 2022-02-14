﻿// <auto-generated />
using FluentApiTabloOlusturma.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluentApiTabloOlusturma.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.Firma", b =>
                {
                    b.Property<int>("Anahtar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirmaUnvan");

                    b.HasKey("Anahtar");

                    b.ToTable("Tbl_Firma");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.Personel", b =>
                {
                    b.Property<int>("Anahtar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("firID")
                        .HasColumnType("int");

                    b.HasKey("Anahtar");

                    b.HasIndex("firID");

                    b.ToTable("Tbl_Personel");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.Suplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Suplier");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.SuplierProduct", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("ProductID", "SupplierID");

                    b.HasIndex("SupplierID");

                    b.ToTable("SuplierProduct");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.Personel", b =>
                {
                    b.HasOne("FluentApiTabloOlusturma.Models.Firma", "Firma")
                        .WithMany("personel")
                        .HasForeignKey("firID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.SuplierProduct", b =>
                {
                    b.HasOne("FluentApiTabloOlusturma.Models.Product", "Product")
                        .WithMany("SuplierProduct")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FluentApiTabloOlusturma.Models.Suplier", "Suplier")
                        .WithMany("SuplierProduct")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Suplier");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.Firma", b =>
                {
                    b.Navigation("personel");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.Product", b =>
                {
                    b.Navigation("SuplierProduct");
                });

            modelBuilder.Entity("FluentApiTabloOlusturma.Models.Suplier", b =>
                {
                    b.Navigation("SuplierProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
