namespace MusteriTakipApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        KategoriId = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.KategoriId);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunAd = c.String(),
                        KategoriId = c.Int(nullable: false),
                        TedarikciId = c.Int(nullable: false),
                        Miktar = c.Int(nullable: false),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BarkodNo = c.Long(nullable: false),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.UrunId)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Tedarikci", t => t.TedarikciId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.TedarikciId);
            
            CreateTable(
                "dbo.Tedarikci",
                c => new
                    {
                        TedarikciId = c.Int(nullable: false, identity: true),
                        TedarikciAd = c.String(),
                        Telefon = c.Long(nullable: false),
                        EMail = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.TedarikciId);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        MusteriId = c.Int(nullable: false, identity: true),
                        MusteriAd = c.String(),
                        Soyad = c.String(),
                        Telefon = c.Long(nullable: false),
                        Adres = c.String(),
                        EMail = c.String(),
                    })
                .PrimaryKey(t => t.MusteriId);
            
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        SatisId = c.Int(nullable: false, identity: true),
                        FaturaNo = c.Int(nullable: false),
                        MusteriId = c.Int(nullable: false),
                        UrunId = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SatisId)
                .ForeignKey("dbo.Musteri", t => t.MusteriId, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.MusteriId)
                .Index(t => t.UrunId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satis", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.Satis", "MusteriId", "dbo.Musteri");
            DropForeignKey("dbo.Urun", "TedarikciId", "dbo.Tedarikci");
            DropForeignKey("dbo.Urun", "KategoriId", "dbo.Kategori");
            DropIndex("dbo.Satis", new[] { "UrunId" });
            DropIndex("dbo.Satis", new[] { "MusteriId" });
            DropIndex("dbo.Urun", new[] { "TedarikciId" });
            DropIndex("dbo.Urun", new[] { "KategoriId" });
            DropTable("dbo.Satis");
            DropTable("dbo.Musteri");
            DropTable("dbo.Tedarikci");
            DropTable("dbo.Urun");
            DropTable("dbo.Kategori");
        }
    }
}
