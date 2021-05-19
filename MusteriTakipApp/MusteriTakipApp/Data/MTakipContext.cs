using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MusteriTakipApp
{
    public class MTakipContext : DbContext
    {
        // Your context has been configured to use a 'MTakipContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MusteriTakipApp.MTakipContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MTakipContext' 
        // connection string in the application configuration file.
        public MTakipContext()
            : base("name=Baglanti")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Kategori> Kategorilers { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Tedarikci> Tedarikciler { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Satis> Satislars { get; set; }
    }

    [Table("Kategori")]
    public class Kategori
    {
        public Kategori()
        {
            this.Urunler = new HashSet<Urun>();
        }
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Urun> Urunler { get; set; }
    }
    [Table("Urun")]

    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public Kategori Kategori { get; set; }
        public int TedarikciId { get; set; }
        [ForeignKey("TedarikciId")]
        public Tedarikci Tedarikci { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public long BarkodNo { get; set; }
        public string Aciklama { get; set; }
    }
    [Table("Musteri")]
    public class Musteri
    {
        [Key]
        public int MusteriId { get; set; }
        public string MusteriAd { get; set; }
        public string Soyad { get; set; }
        public long Telefon { get; set; }
        public string Adres { get; set; }
        public string EMail { get; set; }

    }
    [Table("Tedarikci")]
    public class Tedarikci
    {
        public Tedarikci()
        {
            this.Urunler = new HashSet<Urun>();
        }
        [Key]
        public int TedarikciId { get; set; }
        public string TedarikciAd { get; set; }
        public long Telefon { get; set; }
        public string EMail { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Urun> Urunler { get; set; }
    }
    [Table("Satis")]
    public class Satis
    {
        [Key]
        public int SatisId { get; set; }
        public int FaturaNo { get; set; }
        public string MusteriAd { get; set; }
        public int MusteriId { get; set; }
        [ForeignKey("MusteriId")]
        public Musteri Musteri { get; set; }
        public int UrunId { get; set; }
        [ForeignKey("UrunId")]
        public Urun Urun { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
    }
}