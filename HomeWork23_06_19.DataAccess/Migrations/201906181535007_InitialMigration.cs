namespace HomeWork23_06_19.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CatalogMoveTasks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SenderCatalog = c.String(),
                        GetterCatalog = c.String(),
                        BeginDate = c.DateTime(nullable: false),
                        Period_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Periods", t => t.Period_Id)
                .Index(t => t.Period_Id);
            
            CreateTable(
                "dbo.Periods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PeriodTime = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmailSendTasks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SenderEmail = c.String(),
                        GetterEmail = c.String(),
                        Header = c.String(),
                        MainText = c.String(),
                        BeginDate = c.DateTime(nullable: false),
                        Period_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Periods", t => t.Period_Id)
                .Index(t => t.Period_Id);
            
            CreateTable(
                "dbo.FileDownloadTasks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Url = c.String(),
                        FileName = c.String(),
                        BeginDate = c.DateTime(nullable: false),
                        Period_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Periods", t => t.Period_Id)
                .Index(t => t.Period_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FileDownloadTasks", "Period_Id", "dbo.Periods");
            DropForeignKey("dbo.EmailSendTasks", "Period_Id", "dbo.Periods");
            DropForeignKey("dbo.CatalogMoveTasks", "Period_Id", "dbo.Periods");
            DropIndex("dbo.FileDownloadTasks", new[] { "Period_Id" });
            DropIndex("dbo.EmailSendTasks", new[] { "Period_Id" });
            DropIndex("dbo.CatalogMoveTasks", new[] { "Period_Id" });
            DropTable("dbo.FileDownloadTasks");
            DropTable("dbo.EmailSendTasks");
            DropTable("dbo.Periods");
            DropTable("dbo.CatalogMoveTasks");
        }
    }
}
