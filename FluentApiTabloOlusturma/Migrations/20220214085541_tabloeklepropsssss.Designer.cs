// <auto-generated />
using FluentApiTabloOlusturma.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluentApiTabloOlusturma.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220214085541_tabloeklepropsssss")]
    partial class tabloeklepropsssss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(max)")
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

                    b.HasKey("Anahtar");

                    b.ToTable("Tbl_Personel");
                });
#pragma warning restore 612, 618
        }
    }
}
