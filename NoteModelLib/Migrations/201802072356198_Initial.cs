namespace NoteModelLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActionAccount",
                c => new
                    {
                        IdAction = c.Int(nullable: false, identity: true),
                        Libelle = c.String(maxLength: 100),
                        IdType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAction)
                .ForeignKey("dbo.TypeAction", t => t.IdType, cascadeDelete: true)
                .Index(t => t.IdType);
            
            CreateTable(
                "dbo.DoAction",
                c => new
                    {
                        IdCompte = c.Int(nullable: false),
                        IdAction = c.Int(nullable: false),
                        Details = c.String(maxLength: 300),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                        Amont = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.IdCompte, t.IdAction })
                .ForeignKey("dbo.ActionAccount", t => t.IdAction, cascadeDelete: true)
                .ForeignKey("dbo.Account", t => t.IdCompte, cascadeDelete: true)
                .Index(t => t.IdCompte)
                .Index(t => t.IdAction);
            
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        IdCompte = c.Int(nullable: false, identity: true),
                        CurrentAmont = c.Double(nullable: false),
                        BirthDay = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdCompte);
            
            CreateTable(
                "dbo.TypeAction",
                c => new
                    {
                        IdType = c.Int(nullable: false, identity: true),
                        Libelle = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.IdType);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActionAccount", "IdType", "dbo.TypeAction");
            DropForeignKey("dbo.DoAction", "IdCompte", "dbo.Account");
            DropForeignKey("dbo.DoAction", "IdAction", "dbo.ActionAccount");
            DropIndex("dbo.DoAction", new[] { "IdAction" });
            DropIndex("dbo.DoAction", new[] { "IdCompte" });
            DropIndex("dbo.ActionAccount", new[] { "IdType" });
            DropTable("dbo.TypeAction");
            DropTable("dbo.Account");
            DropTable("dbo.DoAction");
            DropTable("dbo.ActionAccount");
        }
    }
}
