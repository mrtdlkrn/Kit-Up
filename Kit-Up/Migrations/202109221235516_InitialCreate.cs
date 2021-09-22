namespace Kit_Up.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        UrunId = c.Int(nullable: false, identity: true),
                        UrunImg = c.String(),
                        UrunAdi = c.String(),
                        UrunAciklama = c.String(),
                        UrunYazar = c.String(),
                        UrunFiyat = c.Double(nullable: false),
                        UrunStok = c.Int(nullable: false),
                        UrunKategori = c.String(),
                        UrunSatistami = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UrunId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uruns");
        }
    }
}
