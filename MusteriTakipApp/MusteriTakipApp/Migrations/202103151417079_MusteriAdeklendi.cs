namespace MusteriTakipApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MusteriAdeklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Satis", "MusteriAd", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Satis", "MusteriAd");
        }
    }
}
