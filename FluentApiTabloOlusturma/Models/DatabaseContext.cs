using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOlusturma.Models
{
    public class DatabaseContext:DbContext 
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {
         
        }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Suplier> Suplier { get; set; }
        public DbSet<SuplierProduct> SuplierProduct { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Firma>().ToTable("Tbl_Firma");
            modelBuilder.Entity<Personel>().ToTable("Tbl_Personel");
            modelBuilder.Entity<Firma>().Property(x => x.Unvan).HasColumnName("FirmaUnvan");
            //modelBuilder.Entity<Firma>().Property(x => x.ID).HasColumnName("Anahtar");
            modelBuilder.Entity<Firma>().HasKey(x => x.Anahtar);
            modelBuilder.Entity<Personel>().HasKey(x => x.Anahtar);
            //notmapped burdaki karşılığı
            modelBuilder.Entity<Firma>().Ignore(x => x.FirmaLisansKey);
            //required'ın burda kullanımı
            //boş geçilemez
            modelBuilder.Entity<Personel>().Property(x => x.Ad).IsRequired();
            modelBuilder.Entity<Firma>().Property(x => x.Unvan).IsRequired().HasMaxLength(100);
            //bire çok ilişki tanımlama
            //2 farklı bakış açısı
            //1.
            //modelBuilder.Entity<Personel>().HasOne(x => x.Firma).WithMany(x => x.personel).HasForeignKey(x => x.firID);
            //2.
            modelBuilder.Entity<Firma>().HasMany(x => x.personel).WithOne(x => x.Firma).HasForeignKey(x => x.firID).OnDelete(DeleteBehavior.Cascade);
            //------------------------
            //Çoka çok ilişki tanımla
            modelBuilder.Entity<SuplierProduct>().HasKey(x => new { x.ProductID, x.SupplierID });
            //composite key oluşturum.

            //----
            modelBuilder.Entity<SuplierProduct>().HasOne(x => x.Product).WithMany(x => x.SuplierProduct).HasForeignKey(x => x.ProductID);
            modelBuilder.Entity<SuplierProduct>().HasOne(x => x.Suplier).WithMany(x => x.SuplierProduct).HasForeignKey(x => x.SupplierID);
            modelBuilder.Entity<ProductDetails>().HasOne(x => x.Product).WithOne(x => x.ProductDetails).HasForeignKey<ProductDetails>(x => x.ProID);

        }
    }
}
